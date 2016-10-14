using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Encryption.SymmetricEncryption
{
    struct LetterCoord
    {
        public LetterCoord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

       public int x, y;
    }

    public class PolybiusCode : IEncryption
    {
        private string passwordKey;
        private Dictionary<int, LetterCoord> matrix;

        
        public PolybiusCode(string passwordKey)
        {
            this.passwordKey = passwordKey;
            CreateMatrix();
        }

        private void CreateMatrix()
        {
            matrix = new Dictionary<int, LetterCoord>();
            var size = (int)Math.Sqrt(char.MaxValue);
            var sbPasswordKey = new StringBuilder(passwordKey);
            var numberChr = 0;
            for (int i = 1; i < size; ++i)
            {
                for (int j = 1; j < size; ++j)
                {
                    if (sbPasswordKey.Length > 0)
                    {
                        int chr = sbPasswordKey[0];
                        if (!matrix.ContainsKey(chr))
                        {
                            matrix.Add(sbPasswordKey[0], new LetterCoord(i, j));
                        }
                        
                        sbPasswordKey.Remove(0, 1);
                    }
                    else
                    {
                        int chr = numberChr;
                        while (matrix.ContainsKey(chr))
                        {
                            chr = ++numberChr;
                        }

                        matrix.Add(numberChr, new LetterCoord(i, j));
                    }
                }
            }
        }

        public string Decoding(string text)
        {
            return Substitution(text);
        }

        public string Encoding(string text)
        {
            return Substitution(text);
        }

        private string Substitution(string text)
        {
            var sbResult = new StringBuilder();
            List<LetterCoord> codeLet = new List<LetterCoord>();
            foreach (var chr in text)
            {
                codeLet.Add(matrix[chr]);
            }

            for (int i = 0; i < codeLet.Count-1; i += 2)
            {
                int x1 = codeLet[i].x,
                    y1 = codeLet[i + 1].x,
                    x2 = codeLet[i].y,
                    y2 = codeLet[i + 1].y;

                char chr1 = (char)matrix.FirstOrDefault(p => p.Value.x == x1 && p.Value.y == y1).Key,
                     chr2 = (char)matrix.FirstOrDefault(p => p.Value.x == x2 && p.Value.y == y2).Key;

                sbResult.Append(chr1).Append(chr2);
            }

            return sbResult.ToString();
        }
    }
}

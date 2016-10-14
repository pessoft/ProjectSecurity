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
        private Dictionary<LetterCoord, int> matrix;
        private Dictionary<int, LetterCoord> matrixLettr;

        public PolybiusCode(string passwordKey)
        {
            this.passwordKey = passwordKey;
            CreateMatrix();
        }

        private void CreateMatrix()
        {
            matrix = new Dictionary<LetterCoord, int>();
            matrixLettr = new Dictionary<int, LetterCoord>();
            var size = (int)Math.Sqrt(char.MaxValue);
            var sbPasswordKey = new StringBuilder(passwordKey);
            var numberChr = 0;
            for (int i = 1; i < size; ++i)
            {
                for (int j = 1; j < size; ++j)
                {
                    if (sbPasswordKey.Length > 0)
                    {
                        if (!matrixLettr.ContainsKey(sbPasswordKey[0]))
                        {
                            matrixLettr.Add(sbPasswordKey[0], new LetterCoord(i, j));
                            matrix.Add(new LetterCoord(i, j), sbPasswordKey[0]);
                        }

                        sbPasswordKey.Remove(0, 1);
                    }
                    else
                    {
                        char chr = (char)numberChr;
                        while (matrixLettr.ContainsKey(chr))
                        {
                            chr = (char)++numberChr;
                        }

                        matrix.Add(new LetterCoord(i, j), numberChr);
                        matrixLettr.Add(numberChr, new LetterCoord(i, j));
                        ++numberChr;
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

            Action coderTwoLet = () =>
            {
                for (int i = 0; i < codeLet.Count - 1; i += 2)
                {
                    int x1 = codeLet[i].x,
                        y1 = codeLet[i + 1].x,
                        x2 = codeLet[i].y,
                        y2 = codeLet[i + 1].y;

                    char chr1 = (char)matrix[new LetterCoord(x1, y1)],
                         chr2 = (char)matrix[new LetterCoord(x2, y2)];

                    sbResult.Append(chr1).Append(chr2);
                }
            };

            foreach (var chr in text)
            {
                codeLet.Add(matrixLettr[chr]);
                if (codeLet.Count == 2)
                {
                    coderTwoLet();
                    codeLet.Clear();
                }
            }

            if (codeLet.Count != 0)
            {
                sbResult.Append((char)matrix[new LetterCoord(codeLet[0].x, codeLet[0].y)]);
            }

           
            

            return sbResult.ToString();
        }
    }
}

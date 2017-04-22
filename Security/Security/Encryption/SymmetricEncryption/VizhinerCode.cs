using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Security.Encryption.SymmetricEncryption
{
    public class VizhinerCode : BaseEncryption, IEncryption
    {
        private string key;
        private Dictionary<LetterCoord, int> matrix;

        public VizhinerCode(string key)
        {
            this.key = key;
            CreateMatrix();
        }


        private StringBuilder KeyAppender(string text)
        {
            var sbKey = new StringBuilder(key);
            while (sbKey.Length < text.Length)
            {
                sbKey.Append(key);
            }

            if (sbKey.Length > text.Length)
            {
                sbKey.Remove(text.Length, sbKey.Length - text.Length);
            }

            return sbKey;

        }

        private void CreateMatrix()
        {
            matrix = new Dictionary<LetterCoord, int>();

            foreach (var x in Alphabet.Keys)
            {
                var alp1 = Alphabet.Where(p=>p.Value>=Alphabet[x]).ToDictionary(k=>k.Key, v=>v.Value).Keys.ToList();
                var alp2 = Alphabet.Keys.Except(alp1).ToList();
                foreach (var y in Alphabet.Keys)
                {
                    if (alp1.Count > 0)
                    {
                        matrix.Add(new LetterCoord(x, y), alp1[0]);
                        alp1.RemoveAt(0);
                    }
                    else if (alp2.Count > 0)
                    {
                        matrix.Add(new LetterCoord(x, y), alp2[0]);
                        alp2.RemoveAt(0);
                    }
                }
            }

        }

        #region New logic

        public string Decoding(string text)
        {
            var result = new StringBuilder();
            var sbKey = KeyAppender(text);

            for (int i = 0; i < text.Length; ++i)
            {
                char chr = (char)((text[i] - sbKey[i] + char.MaxValue) % char.MaxValue);
                result.Append(chr);
            }

            return result.ToString();
        }

        public string Encoding(string text)
        {
            var result = new StringBuilder();
            var sbKey = KeyAppender(text);

            for (int i = 0; i < text.Length; ++i)
            {
                char chr = (char)((text[i] + sbKey[i]) % char.MaxValue);
                result.Append(chr);
            }

            return result.ToString();
        }

        #endregion

        #region Old logic
        //public string Decoding(string text)
        //{
        //    var sbKey = KeyAppender(text);
        //    var result = new StringBuilder();

        //    for (int i = 0; i < text.Length; ++i)
        //    {
        //        char chr = (char)matrix.FirstOrDefault(p => p.Key.x == sbKey[i] && text[i] == p.Value).Key.y;
        //        result.Append(chr);
        //    }
        //    return result.ToString();
        //}

        //public string Encoding(string text)
        //{
        //    var sbKey = KeyAppender(text);
        //    var result = new StringBuilder();

        //    for (int i = 0; i < text.Length; ++i)
        //    {
        //        char chr = (char)matrix[new LetterCoord(sbKey[i], text[i])];
        //        result.Append(chr);
        //    }
        //    return result.ToString();
        //}
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Encryption.SymmetricEncryption
{
    public class PairedСipher : BaseEncryption, IEncryption
    {
        private string key;
        private Dictionary<int, int> pairChar;
        private Dictionary<int, int> pairCharRevers;

        public PairedСipher(string key)
        {
            this.key = key;
            GeneratePairChar();
            GenerateKey();
        }

        private void GenerateKey()
        {
            var _key = string.Empty;
            var count = Alphabet.Count / 2;
            var index = 0;
            var rnd = new Random();
            while (index <= count)
            {
                char chr;

                do
                {
                    chr = (char)Alphabet.Keys.ToList()[rnd.Next(Alphabet.Count)];
                }
                while (_key.ToLower().Contains(chr.ToString().ToLower()));

                _key += chr;
                ++index;
            }
            _key = _key.ToString();
        }

        private void GeneratePairChar()
        {
            var chars = key.ToList().Select(p => (int)p).Distinct().ToList();
            var chrPair = Alphabet
                .Where(p => !chars.Exists(chr => chr == p.Key))
                .Select(p => p.Key)
                .ToList();
            pairChar = new Dictionary<int, int>();
            pairCharRevers = new Dictionary<int, int>();

            for (var i = 0; i < chars.Count; ++i)
            {
                pairChar.Add(chars[i], chrPair[i]);
                pairCharRevers.Add(chrPair[i], chars[i]);
            }
        }

        public string Decoding(string text)
        {
            return EncDec(text);
        }

        public string Encoding(string text)
        {
            return EncDec(text);
        }

        private string EncDec(string text)
        {
            var sbText = new StringBuilder();
            int chrInt = 0;
            foreach (var chr in text)
            {
                if (pairChar.TryGetValue(chr, out chrInt))
                {
                    sbText.Append((char)pairChar[chr]);
                }
                else if (pairCharRevers.TryGetValue(chr, out chrInt))
                {
                    sbText.Append((char)pairCharRevers[chr]);
                }
            }

            return sbText.ToString();
        }
    }
}

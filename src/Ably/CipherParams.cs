using System.Security.Cryptography;

namespace Ably
{
    public class CipherParams
    {
        public string Algorithm { get; private set; }
        public byte[] Key { get; private set; }
        public CipherMode Mode { get; private set; }
        public int KeyLength { get; private set; }

        public string CipherType
        {
            get { return string.Format("{0}-{1}-{2}", Algorithm, KeyLength, Mode); }
        }

        public CipherParams(byte[] key)
        {
            Algorithm = Crypto.DefaultAlgorithm;
            Key = key;
        }

        public CipherParams(string algorithm, byte[] key, CipherMode? mode = null, int? keyLength = null)
        {
            Algorithm = algorithm.IsEmpty() ? Crypto.DefaultAlgorithm : algorithm;
            Key = key;
            Mode = mode ?? Crypto.DefaultMode;
            KeyLength = keyLength ?? Crypto.DefaultKeylength;
        }

    }
}
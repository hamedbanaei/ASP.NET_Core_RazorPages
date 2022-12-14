namespace CryptographyAlgorithmsBenchmark
{

    [BenchmarkDotNet.Attributes.MemoryDiagnoser]
    public class HashAlgorithms : System.Object
    {
        public HashAlgorithms()
        {
            System.Security.Cryptography.RandomNumberGenerator.Create().GetNonZeroBytes(InputValue);
        }

        public byte[] InputValue = new byte[5000];

        [BenchmarkDotNet.Attributes.Benchmark]
        public void MD5HashAlgorithm()
        {
            System.Security.Cryptography.MD5.HashData(InputValue);
        }

        [BenchmarkDotNet.Attributes.Benchmark]
        public void Sha1HashAlgorithm()
        {
            System.Security.Cryptography.SHA1.HashData(InputValue);
        }

        [BenchmarkDotNet.Attributes.Benchmark]
        public void Sha256HashAlgorithm()
        {
            System.Security.Cryptography.SHA256.HashData(InputValue);
        }

        [BenchmarkDotNet.Attributes.Benchmark]
        public void Sha384HashAlgorithm()
        {
            System.Security.Cryptography.SHA384.HashData(InputValue);
        }

        [BenchmarkDotNet.Attributes.Benchmark]
        public void Sha512HashAlgorithm()
        {
            System.Security.Cryptography.SHA512.HashData(InputValue);
        }
    }
}

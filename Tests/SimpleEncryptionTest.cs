using Xunit;
using Katas;

namespace Tests
{
    public class SimpleEncryptionTest
    {
        public class AlternatingSplitTest
        {
            [Fact]
            public void EncryptExampleTests()
            {
                Assert.Equal("This is a test!", SimpleEncryption.AlternatingSplit.Encrypt("This is a test!", 0));
                Assert.Equal("hsi  etTi sats!", SimpleEncryption.AlternatingSplit.Encrypt("This is a test!", 1));
                Assert.Equal("s eT ashi tist!", SimpleEncryption.AlternatingSplit.Encrypt("This is a test!", 2));
                Assert.Equal(" Tah itse sits!", SimpleEncryption.AlternatingSplit.Encrypt("This is a test!", 3));
                Assert.Equal("This is a test!", SimpleEncryption.AlternatingSplit.Encrypt("This is a test!", 4));
                Assert.Equal("This is a test!", SimpleEncryption.AlternatingSplit.Encrypt("This is a test!", -1));
                Assert.Equal("hskt svr neetn!Ti aai eyitrsig", SimpleEncryption.AlternatingSplit.Encrypt("This kata is very interesting!", 1));
            }

            [Fact]
            public void DecryptExampleTests()
            {
                Assert.Equal("This is a test!", SimpleEncryption.AlternatingSplit.Decrypt("This is a test!", 0));
                Assert.Equal("This is a test!", SimpleEncryption.AlternatingSplit.Decrypt("hsi  etTi sats!", 1));
                Assert.Equal("This is a test!", SimpleEncryption.AlternatingSplit.Decrypt("s eT ashi tist!", 2));
                Assert.Equal("This is a test!", SimpleEncryption.AlternatingSplit.Decrypt(" Tah itse sits!", 3));
                Assert.Equal("This is a test!", SimpleEncryption.AlternatingSplit.Decrypt("This is a test!", 4));
                Assert.Equal("This is a test!", SimpleEncryption.AlternatingSplit.Decrypt("This is a test!", -1));
                Assert.Equal("This kata is very interesting!", SimpleEncryption.AlternatingSplit.Decrypt("hskt svr neetn!Ti aai eyitrsig", 1));
            }

            [Fact]
            public void EmptyTests()
            {
                Assert.Equal("", SimpleEncryption.AlternatingSplit.Encrypt("", 0));
                Assert.Equal("", SimpleEncryption.AlternatingSplit.Decrypt("", 0));
            }

            [Fact]
            public void NullTests()
            {
                Assert.Null(SimpleEncryption.AlternatingSplit.Encrypt(null, 0));
                Assert.Null(SimpleEncryption.AlternatingSplit.Decrypt(null, 0));
            }
        }
    }
}

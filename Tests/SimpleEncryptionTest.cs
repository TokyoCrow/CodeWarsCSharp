using Xunit;
using Katas;

namespace Tests
{
    public class SimpleEncryptionTest
    {
        public class AlternatingSplitTest
        {
            [Theory]
            [InlineData("This is a test!", 0, "This is a test!")]
            [InlineData("This is a test!", 1, "hsi  etTi sats!")]
            [InlineData("This is a test!", 2, "s eT ashi tist!")]
            [InlineData("This is a test!", 3, " Tah itse sits!")]
            [InlineData("This is a test!", 4, "This is a test!")]
            [InlineData("This is a test!", -1, "This is a test!")]
            [InlineData("This kata is very interesting!", 1, "hskt svr neetn!Ti aai eyitrsig")]
            public void EncryptExampleTests(string inputText, int inputRepeats, string output)
            {
                Assert.Equal(output, SimpleEncryption.AlternatingSplit.Encrypt(inputText, inputRepeats));
            }

            [Theory]
            [InlineData("This is a test!", 0, "This is a test!")]
            [InlineData("hsi  etTi sats!", 1, "This is a test!")]
            [InlineData("s eT ashi tist!", 2, "This is a test!")]
            [InlineData(" Tah itse sits!", 3, "This is a test!")]
            [InlineData("This is a test!", 4, "This is a test!")]
            [InlineData("This is a test!", -1, "This is a test!")]
            [InlineData("hskt svr neetn!Ti aai eyitrsig", 1, "This kata is very interesting!")]
            public void DecryptExampleTests(string inputText, int inputRepeats, string output)
            {
                Assert.Equal(output, SimpleEncryption.AlternatingSplit.Decrypt(inputText, inputRepeats));
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

using PhoneKeyPad;

namespace PhoneKeyPadTest
{
    [TestClass]
    public sealed class PhoneProcessorTests
    {
        [TestMethod]
        public void Test_EmptyString()
        {
            string input = "";

            string output = PhoneProcessor.OldPhonePad(input);
            Assert.AreEqual(output, string.Empty);
        }

        [TestMethod]
        public void Test_EmptyStringWithHash()
        {
            string input = "#";

            string output = PhoneProcessor.OldPhonePad(input);
            Assert.AreEqual(output, string.Empty);
        }

        [TestMethod]
        public void Test_SingleChar()
        {
            string input = "3#";

            string output = PhoneProcessor.OldPhonePad(input);
            Assert.AreEqual(output, "D");
        }

        [TestMethod]
        public void Test_MultipleCharWithoutBack()
        {
            string input = "33#";

            string output = PhoneProcessor.OldPhonePad(input);
            Assert.AreEqual(output, "E");
        }

        [TestMethod]
        public void Test_MultipleCharWithBack()
        {
            string input = "22277*#";

            string output = PhoneProcessor.OldPhonePad(input);
            Assert.AreEqual(output, "C");
        }

        [TestMethod]
        public void Test_MultipleCharWithSpace()
        {
            string input = "222 2 22#";

            string output = PhoneProcessor.OldPhonePad(input);
            Assert.AreEqual(output, "CAB");
        }

        [TestMethod]
        public void Test_MultipleCharWithoutSpace()
        {
            string input = "2233555#";

            string output = PhoneProcessor.OldPhonePad(input);
            Assert.AreEqual(output, "BEL");
        }

        [TestMethod]
        public void Test_MultipleCharWithSpaceAndWithBack()
        {
            string input = "8 88777444666*664#";

            string output = PhoneProcessor.OldPhonePad(input);
            Assert.AreEqual(output, "TURING");
        }

        [TestMethod]
        public void Test_MultipleCharWithSpaceAndNoBack()
        {
            string input = "8 88777444666#";

            string output = PhoneProcessor.OldPhonePad(input);
            Assert.AreEqual(output, "TURIO");
        }

        [TestMethod]
        public void Test_MultipleCharNoSpaceAndWithBack()
        {
            string input = "888777444666*#";

            string output = PhoneProcessor.OldPhonePad(input);
            Assert.AreEqual(output, "VRI");
        }        
    }
}

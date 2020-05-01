using System.IO;
using NUnit.Framework;

namespace nunit_attachment_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            File.WriteAllText("file.txt", "abc\nあいうえお\n😆");
            TestContext.AddTestAttachment("file.txt");
            Assert.Pass();
        }
    }
}
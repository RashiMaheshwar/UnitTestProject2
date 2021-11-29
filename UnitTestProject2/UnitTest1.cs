using System;
using NUnit.Framework;

namespace UnitTestProject2
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Console.WriteLine("hello ");
        }
        [Test]
        public void TestMethod2()
        {
            Console.WriteLine("hello 12345");
        }
    }
}

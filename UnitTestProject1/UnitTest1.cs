using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppCoreTool;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            if (Program.Calculation(10, 5).Equals(15))
            {
                //hkjh
            }
            else
            {
                throw new Exception("test failed");
            }

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppCoreTool;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public static void TestMethod1()
        {
            if (Program.Calculation(10, 5) == 15)
            {
                
            }
            else
            {
                throw new Exception("test failed");
            }

        }
    }
}

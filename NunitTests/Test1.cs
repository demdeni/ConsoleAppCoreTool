using ConsoleAppCoreTool;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTests
{

    public class Test1
    {
        [Test]
        public static void TestMethodNunit()
        {
            var calc = Program.Calculation(10, 5);
            if (calc == 15)
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

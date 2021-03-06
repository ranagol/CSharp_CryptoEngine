﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Honti.CryptoEngine.Test
{
    [TestClass]
    public class AESTest
    {
        [TestMethod]
        public void TestwithoutSpecialCharacters()
        {
            for (var iloop = 0; iloop < 1000; iloop++)
            {
                var originalString = RandomGenerator.Generator.RandomString(500);
                var encrypted = AES.Encrypt(originalString);
                Console.WriteLine("Original string: " + originalString);
                Console.WriteLine("Encrypted string: " + encrypted);
                Assert.AreEqual(AES.Decrypt(encrypted), originalString);
            }
        }

        [TestMethod]
        public void TestwithSpecialCharacters()
        {
            for (var iloop = 0; iloop < 1000; iloop++)
            {
                var originalString = RandomGenerator.Generator.GeneratePassword(500, 500);
                var encrypted = AES.Encrypt(originalString);
                Console.WriteLine("Original string: " + originalString);
                Console.WriteLine("Encrypted string: " + encrypted);
                Assert.AreEqual(AES.Decrypt(encrypted), originalString);
            }
        }
    }
}

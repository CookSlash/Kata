using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RomanNumeral
{
    [TestFixture]
    class RomanNumeralTest
    {
        [TestCase("I",1)]
        [TestCase("V",5)]
        [TestCase("X",10)]
        [TestCase("L",50)]
        [TestCase("C",100)]
        [TestCase("D",500)]
        [TestCase("M",1000)]
        public void ShouldReturnBasicValuesForBasicNumbers(string expected, int inputNumber)
        {
            Assert.AreEqual(expected,inputNumber.ToRomanNumeral());
        }

        [TestCase("XV", 15)]
        public void ShouldReturnBasicRomanNumeralForNumber(string expected, int inputNumber)
        {
            Assert.AreEqual(expected, inputNumber.ToRomanNumeral());
        }

        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("XX", 20)]
        [TestCase("XXX", 30)]
        [TestCase("CC", 200)]
        [TestCase("CCC", 300)]
        [TestCase("MM", 2000)]
        [TestCase("MMM", 3000)]
        
        public void ShouldRepeatUnitLetter(string expected, int inputNumber)
        {
            Assert.AreEqual(expected, inputNumber.ToRomanNumeral());
        }


        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("XL", 40)]
        [TestCase("XC", 90)]
        [TestCase("CD", 400)]
        [TestCase("CM", 900)]

        public void ShouldSubstractfromGreaterValue(string expected, int inputNumber)
        {
            Assert.AreEqual(expected, inputNumber.ToRomanNumeral());
        }

        [TestCase(1903, "MCMIII")]
        public void ToRomanNumeral_Should_BreakNumberInDigit(int number, string expected)
        {
            var result = number.ToRomanNumeral();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ToRomanNumeralAndFromRomanNumeral_Should_RevertToInitialValue()
        {
            for (int i = 1; i < 3001; i++)
            {
                var roman = i.ToRomanNumeral();
                var revert = roman.FromRomanNumeral();
                Assert.AreEqual(i, revert);
            }
        }
    }
}

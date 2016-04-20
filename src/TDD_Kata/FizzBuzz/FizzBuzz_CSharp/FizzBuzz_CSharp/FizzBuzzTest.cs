using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz_CSharp
{
    [TestFixture]
    class FizzBuzzTest
    {
        [TestCase(1)]
        [TestCase(2)]
        public void FizzBuzz_Should_Return_NumberAsString(int input)
        {
            var result = input.FizzBuzz();
            Assert.AreEqual(input.ToString(), result);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void FizzBuzz_Should_Return_Fizz_When_NumberIsDivisibleBy3(int input)
        {
            var result = input.FizzBuzz();
            Assert.AreEqual("Fizz", result);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void FizzBuzz_Should_Return_Buzz_When_NumberIsDivisibleBy5(int input)
        {
            var result = input.FizzBuzz();
            Assert.AreEqual("Buzz", result);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void FizzBuzz_Should_Return_FizzBuzz_When_NumberIsDivisibleBy3And5(int input)
        {
            var result = input.FizzBuzz();
            Assert.AreEqual("FizzBuzz", result);

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Test6.Solution;

namespace Task6.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            int[] actual = Generator<int>.Generate((x, y) => x + y, 1, 1, 10).ToArray<int>();

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            int[] actual = Generator<int>.Generate((x, y) => 6*y-8*x, 1, 2, 10).ToArray<int>();

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double eps = 0.00001;
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            double[] actual = Generator<double>.Generate((x, y) => y + x/y, 1, 2, 10).ToArray<double>();

            int i = 0;
            foreach(double value in actual)
            {
                Assert.IsTrue(Math.Abs(value - expected[i++]) < eps);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public static class Generator<T>
    {
        public static IEnumerable<T> Generate(Func<T, T, T> GenerateElem, T first, T second, int count)
            => GenerateElements<T>(GenerateElem, first, second, count);

        private static IEnumerable<T> GenerateElements(Func<T, T, T> GenerateElem, T first, T second, int count)
        {
            yield return first;
            yield return second;
            for (int i = 2; i < count; i++) ;
            {

            }
        }
    }
}

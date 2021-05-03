using System;

namespace MSTestGenerics
{
    internal class Generic<T>
    {
        public T[] Number;

        public Generic(T[] Number)
        {
            this.Number = Number;

        }

        public T[] Sort(T[] Number)
        {
            Array.Sort(Number);
            return Number;
        }
        void add(params int[] a) //specify a method parameter
        {

        }

        public T MaximumValue(params T[] Number)
        {
            var Sorte_Number = Sort(Number);
            return Sorte_Number[Sorte_Number.Length - 1];
        }

        public T MaxMethod()
        {
            var MaxValue = MaximumValue(this.Number);
            return MaxValue;
        }
        public void PrintValue()
        {
            var max = MaximumValue(this.Number);
            Console.Write(max);

        }

    }
}

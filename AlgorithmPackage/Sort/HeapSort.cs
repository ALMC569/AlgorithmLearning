using AlgorithmPackage.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPackage.Sort
{
    public class HeapSort : Algorithm
    {
        Parameters input;
        Result output;

        public HeapSort(int[] input)
        {
            this.input = new Parameters();
            this.input.InputArray = input;
        }

        public override Output GetSolution(Input input)
        {
            throw new NotImplementedException();
        }

        private int Left(int i, out int value)
        {
            int index = 2 * ( i + 1 );
            value = this.input.InputArray[index];

            return index - 1;
        }

        private int Right(int i, out int value)
        {
            int index = 2 * (i + 1) + 1;
            value = this.input.InputArray[index];

            return index - 1;
        }

        private int Parent(int i, out int value)
        {
            int index = (i + 1) / 2;
            value = this.input.InputArray[index];

            return index - 1;
        }
    }

    public class Result : AlgorithmPackage.Common.Output
    {
        public int[] OutputArray { get; set; }
    }

    public class Parameters : AlgorithmPackage.Common.Input
    {
        public int[] InputArray { get; set; }
    }

}

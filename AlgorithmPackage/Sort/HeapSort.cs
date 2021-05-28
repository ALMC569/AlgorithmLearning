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
            int[] resultArr = new int[this.input.InputArray.Length];
            this.input.InputArray.CopyTo(resultArr, 0);
            return new Result() { OutputArray = Solve(resultArr) };
        }

        public int[] Solve(int[] input)
        {
            int heapSize = this.input.InputArray.Length;
            while (heapSize > 2)
            { 
                
            }

            return input;
        }
        public void BuildMaxHeap(int begin, int[] arr)
        {
            //从叶子节点上一层开始
            for (int i = (arr.Length - begin) / 2; i >= begin; i--)
            {
                MaxHeapfy(arr, i) ;
            }
        }
        /// <summary>
        /// 从根节点开始 大顶堆化
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rootIndex"></param>
        public void MaxHeapfy(int[] arr, int rootIndex)
        {
            int largest = arr[rootIndex];
            int largestValue = 0;
            int leftValue = 0;
            int rightValue = 0;

            int left = Left(rootIndex,out leftValue);
            int right = Right(rootIndex, out rightValue);

            if (largestValue < leftValue)
            {
                largestValue = leftValue;
                largest = left;
            }

            if (largestValue < rightValue)
            {
                largestValue = rightValue;
                largest = right;
            }

            Util.Swap(arr, largest, rootIndex);

            if (largest != rootIndex)
                MaxHeapfy(arr, largest);
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

}

using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPackage.Sort
{
    public interface ISort
    {
    }

    public class Result : AlgorithmPackage.Common.Output
    {
        public int[] OutputArray { get; set; }
    }

    public class Parameters : AlgorithmPackage.Common.Input
    {
        public int[] InputArray { get; set; }
    }

    public static class Util
    {
        public static void Swap(this int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = index2;
            arr[index2] = temp;
        }
    }
}

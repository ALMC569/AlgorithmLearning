using AlgorithmPackage.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPackage.DivideAndConquer.MaximumSumOfChildArray
{
    public class MaximumSumOfChildArray : Algorithm
    {
        public MaximumSumOfChildArray(Parameters p)
        {
            this.parameters = p;
        }
        public override Output GetSolution(Input input)
        {
            Result r = Solve(0, this.parameters.InputArray.Length - 1);

            return r;
        }

        public Parameters parameters { get; set; }
        private Result Solve(int begin, int end)
        {
            #region 规模足够小时求解
            if (end - begin == 0)
                return new Result() { begin = begin, end = end, Sum = this.parameters.InputArray[begin] };
            #endregion 

            #region 分解
            //左中右，三部分寻找SUM最大子数组
            int mid = GetMid(begin, end);
            
            int a = mid - 1;
            int b = mid + 1;

            Result leftResult = null;
            Result rightResult = null;
                
            //如果区间溢出就默认为空
            leftResult = a < begin ? null : Solve(begin, a);
            rightResult = b > end ? null : Solve(b, end);

            //如果最大子数组在中间，则必然经过arr[mid]，可以分别从arr[mid]向两侧开始找
            int maxSum = parameters.InputArray[mid];

            int maxSumA = mid;
            int sum = maxSum;
            for (int i = a; i >= begin; i--)
            {
                sum = parameters.InputArray[i] + sum;
                if (sum > maxSum)
                {
                    maxSumA = i;
                    maxSum = sum;
                }
            }

            int maxSumB = mid;
            sum = maxSum;
            for (int i = b; i <= end; i++)
            {
                sum = parameters.InputArray[i] + sum;
                if (sum > maxSum)
                {
                    maxSumB = i;
                    maxSum = sum;
                }
            }

            var midResult = new Result() { begin = maxSumA, end = maxSumB, Sum = maxSum };
            #endregion

            #region 合并
            //将找到的三个部分的结果进行对比,作为子问题的结果返回
            Result r = midResult.Max(leftResult, rightResult);
            return r;
            #endregion
        }

        private int GetMid(int begin, int end)
        {
            return (begin + end) / 2;
        }
    }
    public static class Util{
        public static Result Max(this Result r, params Result[] resultArr)
        {
            Result max = r;
            foreach (Result i in resultArr)
            {
                if(i != null)
                    max = max.Sum > i.Sum ? max : i;
            }

            return max;
        }
    }
    public class Result : AlgorithmPackage.Common.Output
    {
        public int begin { get; set; }

        public int end { get; set; }

        public int Sum { get; set; }

        public override void Result2Console()
        {
            Console.WriteLine($"结果:【begin={begin}】【end={end}】【sum={Sum}】");
        }
    }

    public class Parameters : AlgorithmPackage.Common.Input
    { 
        public int[] InputArray { get; set; }
    }

}

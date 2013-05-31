using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Given a sorted array and a target value, return the index if the target is found.
// If not, return the index where it would be if it were inserted in order.

// You may assume no duplicates in the array.

// Here are few examples.
// [1,3,5,6], 5 �� 2
// [1,3,5,6], 2 �� 1
// [1,3,5,6], 7 �� 4
// [1,3,5,6], 0 �� 0

namespace LeetSharp
{
    [TestClass]
    public class Q035_SearchInsertPosition
    {
        public int SearchInsert(int[] input, int target)
        {
            return -1;
        }

        public string SolveQuestion(string input)
        {
            return TestHelper.Serialize(SearchInsert(input.GetToken(0).ToIntArray(), input.GetToken(1).ToInt()));
        }

        [TestMethod]
        public void Q035_Small()
        {
            TestHelper.Run(s => SolveQuestion(s));
        }
        [TestMethod]
        public void Q035_Large()
        {
            TestHelper.Run(s => SolveQuestion(s));
        }
    }
}

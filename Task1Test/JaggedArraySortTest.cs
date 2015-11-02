using NUnit.Framework;
using System;
using System.Collections;
using Task1;
//using NUnit.Framework;

namespace Task1Test
{
    [TestFixture]
    public class JaggedArraySortTest
    {
        
        [Test]
        public void SortByPositiveSumTest()
        {
            int[][] array = { null,new[] { 3, -1, 5, -21, 31 }, new[] { 0, 24, -4, 10 },null,null, new[] { 5, 5, -10, 20 },null ,new[] { 7, -4, -3, 25, 15 } };
            int[][] arrayCompareIsPositive = { new[] { 3, -1, 5, -21, 31 }, new[] { 5, 5, -10, 20 }, new[] { 0, 24, -4, 10 }, new[] { 7, -4, -3, 25, 15 },null,null,null,null };           
            IArrayCompare sumPositiveCompare = new CompareByPositiveSum();
            JaggedArraySort.Sort(array,sumPositiveCompare);
            IStructuralEquatable arraySort = array;
            Assert.AreEqual(arraySort.Equals(arrayCompareIsPositive , StructuralComparisons.StructuralEqualityComparer), true);
        }
        [Test]
        public void SortByNegativeSumTest()
        {
            int[][] array = { null, new[] { 3, -1, 5, -21, 31 }, new[] { 0, 24, -4, 10 }, null, null, new[] { 5, 5, -10, 20 }, null, new[] { 7, -4, -3, 25, 15 } };
            int[][] arrayCompareIsNegative = { new[] { 7, -4, -3, 25, 15 }, new[] { 0, 24, -4, 10 }, new[] { 5, 5, -10, 20 }, new[] { 3, -1, 5, -21, 31 }, null, null, null, null };
            IArrayCompare sumNegativeCompare = new CompareByNegativeSum();
            JaggedArraySort.Sort(array, sumNegativeCompare);
            IStructuralEquatable arraySort = array;
            Assert.AreEqual(arraySort.Equals(arrayCompareIsNegative, StructuralComparisons.StructuralEqualityComparer), true);

        }

        [Test]
        public void SortByPositiveMaxElementTest()
        {
            int[][] array = { null, new[] { 3, -1, 5, -21, 31 }, new[] { 0, 24, -4, 10 }, null, null, new[] { 5, 5, -10, 20 }, null, new[] { 7, -4, -3, 25, 15 } };
            int[][] arrayCompareIsPositive = { new[] { 5, 5, -10, 20 }, new[] { 0, 24, -4, 10 }, new[] { 7, -4, -3, 25, 15 },new[] { 3, -1, 5, -21, 31 }, null, null, null, null };
            
            IArrayCompare maxElementCompare = new CompareByPositiveMaxElement();
            JaggedArraySort.Sort(array, maxElementCompare);
            IStructuralEquatable arraySort = array;
            Assert.AreEqual(arraySort.Equals(arrayCompareIsPositive, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [Test]
        public void SortByNegativeMaxElementTest()
        {
            int[][] array = { null, new[] { 3, -1, 5, -21, 31 }, new[] { 0, 24, -4, 10 }, null, null, new[] { 5, 5, -10, 20 }, null, new[] { 7, -4, -3, 25, 15 } };
            int[][] arrayCompareIsNegative = { new[] { 3, -1, 5, -21, 31 }, new[] { 7, -4, -3, 25, 15 }, new[] { 0, 24, -4, 10 }, new[] { 5, 5, -10, 20 }, null, null, null, null };
            IArrayCompare maxElementCompare = new CompareByNegativeMaxElement();
            JaggedArraySort.Sort(array, maxElementCompare);
            IStructuralEquatable arraySort = array;
            Assert.AreEqual(arraySort.Equals(arrayCompareIsNegative, StructuralComparisons.StructuralEqualityComparer), true);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MergeTwoLists;

using LeetcodeTrainer.Common;

namespace LeetcodeTrainer.Tests;

[TestClass]
public sealed class MergeTwoSortedLists
{
    [TestMethod]
    public void Case1()
    {
        //Arrange
        int[] l1 = [1, 2, 4];
        int[] l2 = [1, 3, 4];
        int[] expected = [1, 1, 2, 3, 4, 4];

        //Act
        var result = Problem.MergeTwoLists(l1.ToListNode(), l2.ToListNode()).ToArray();

        //Assert
        CollectionAssert.AreEqual(result, expected);
    }

    [TestMethod]
    public void Case2()
    {
        //Arrange
        int[] l1 = [];
        int[] l2 = [];
        int[] expected = [];

        //Act
        var result = Problem.MergeTwoLists(l1.ToListNode(), l2.ToListNode()).ToArray();

        //Assert
        CollectionAssert.AreEqual(result, expected);
    }

    [TestMethod]
    public void Case3()
    {
        //Arrange
        int[] l1 = [];
        int[] l2 = [0];
        int[] expected = [0];

        //Act
        var result = Problem.MergeTwoLists(l1.ToListNode(), l2.ToListNode()).ToArray();

        //Assert
        CollectionAssert.AreEqual(result, expected);
    }
}

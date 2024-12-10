using AddTwoNumbers;

using LeetcodeTrainer.Common;

namespace Tests;

[TestClass]
public sealed class AddTwoNumbers
{
    [TestMethod]
    public void Case1()
    {
        //Arrange
        int[] l1 = [2, 4, 3];
        int[] l2 = [5, 6, 4];
        int[] expected = [7, 0, 8];

        //Act
        var result = Problem.AddTwoNumbers(l1.ToListNode(), l2.ToListNode()).ToArray();

        //Assert
        CollectionAssert.AreEqual(result, expected);
    }

    [TestMethod]
    public void Case2()
    {
        //Arrange
        int[] l1 = [0];
        int[] l2 = [0];
        int[] expected = [0];

        //Act
        var result = Problem.AddTwoNumbers(l1.ToListNode(), l2.ToListNode()).ToArray();

        //Assert
        CollectionAssert.AreEqual(result, expected);
    }

    [TestMethod]
    public void Case3()
    {
        //Arrange
        int[] l1 = [9, 9, 9, 9, 9, 9, 9];
        int[] l2 = [9, 9, 9, 9];
        int[] expected = [8, 9, 9, 9, 0, 0, 0, 1];

        //Act
        var result = Problem.AddTwoNumbers(l1.ToListNode(), l2.ToListNode()).ToArray();

        //Assert
        CollectionAssert.AreEqual(result, expected);
    }
}

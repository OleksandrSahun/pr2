using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SolutionTests
{
    private Solution solution;

    [TestInitialize]
    public void Setup()
    {
        solution = new Solution();
    }

    [TestMethod]
    public void CanPlaceFlowers_EmptyBed_ReturnsTrue()
    {
        int[] flowerbed = new int[] { 0 };
        Assert.IsTrue(solution.CanPlaceFlowers(flowerbed, 1));
    }

    [TestMethod]
    public void CanPlaceFlowers_FullBed_ReturnsFalse()
    {
        int[] flowerbed = new int[] { 1, 0, 1 };
        Assert.IsFalse(solution.CanPlaceFlowers(flowerbed, 1));
    }

    [TestMethod]
    public void CanPlaceFlowers_LongBedWithGaps_ReturnsTrue()
    {
        int[] flowerbed = new int[] { 1, 0, 0, 0, 1 };
        Assert.IsTrue(solution.CanPlaceFlowers(flowerbed, 1));
    }

    [TestMethod]
    public void CanPlaceFlowers_ZeroFlowersNeeded_ReturnsTrue()
    {
        int[] flowerbed = new int[] { 1, 1, 1 };
        Assert.IsTrue(solution.CanPlaceFlowers(flowerbed, 0));
    }

    [TestMethod]
    public void CanPlaceFlowers_NotEnoughSpace_ReturnsFalse()
    {
        int[] flowerbed = new int[] { 1, 0, 1, 0, 1 };
        Assert.IsFalse(solution.CanPlaceFlowers(flowerbed, 2));
    }

    [TestMethod]
    public void CanPlaceFlowers_MultipleGaps_ReturnsTrue()
    {
        int[] flowerbed = new int[] { 0, 0, 0, 0, 0 };
        Assert.IsTrue(solution.CanPlaceFlowers(flowerbed, 3));
    }

    [TestMethod]
    public void CanPlaceFlowers_EdgeCases_ReturnsExpected()
    {
        int[] flowerbed = new int[] { 0, 0 };
        Assert.IsTrue(solution.CanPlaceFlowers(flowerbed, 1));
        Assert.IsFalse(solution.CanPlaceFlowers(flowerbed, 2));
    }
}

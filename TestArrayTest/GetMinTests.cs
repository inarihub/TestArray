using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestArrayTests;

public class GetMinTests
{
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(-1, 0, -1)]
    [InlineData(-1, 1, -1)]
    [InlineData(5, 10, 5)]
    public void IntArrayTest(int x, int y, int expected)
    {
        int[] arr = new int[] { x, y };

        var actual = TestArray.Program.GetMin(arr);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NullTest()
    {
        var rtnValue = TestArray.Program.GetMin(null);

        Assert.Null(rtnValue);
    }

    [Fact]
    public void GetMinTests_IsEmpty()
    {
        int[] array = Array.Empty<int>();

        var rtnValue = TestArray.Program.GetMin(array);

        Assert.Null(rtnValue);
    }
}
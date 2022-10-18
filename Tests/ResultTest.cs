using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var steps = 8;
        var path = "UDDDUDUU";

        var expected = 1;

        var actual = Result.countingValleys(steps, path);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var steps = 10;
        var path = "DUDDDUUDUU";

        var expected = 2;

        var actual = Result.countingValleys(steps, path);

        Assert.Equal(expected, actual);
    }
}
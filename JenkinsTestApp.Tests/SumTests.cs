using JenkinsTestApp.Code;
using Xunit;

namespace JenkinsTestApp.Tests;

public class SumTests
{
    [Fact]
    public void SumTwoPositiveNumbers()
    {
        int SumResult = Sum.SumTwoNumbers(2, 3);

        Assert.Equal(5, SumResult);
    }

    //[Fact]
    //public void SumTwoNegativeNumbers()
    //{
    //    int SumResult = Sum.SumTwoNumbers(-2, -3);

    //    Assert.Equal(-5, SumResult);
    //}

    //[Fact]
    //public void SumPositiveAndNegativeNumbers()
    //{
    //    int SumResult = Sum.SumTwoNumbers(2, -3);

    //    Assert.Equal(-1, SumResult);
    //}

    //[Fact]
    //public void SumNegativeAndPositiveNumbers()
    //{
    //    int SumResult = Sum.SumTwoNumbers(-2, 3);

    //    Assert.Equal(1, SumResult);
    //}
}

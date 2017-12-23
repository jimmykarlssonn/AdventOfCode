using AdventOfCode2017;
using AdventOfCode2017.Assignments;
using NUnit.Framework;

[TestFixture]
public class UnitTests
{
    [Test]
    public void DecemberFirst()
    {
        var input = "1122334451";

        var sut = new DecemberFirst();

        var result = sut.Calculate(input);

        Assert.AreEqual(result, 1 + 2 + 3 + 4 + 1);
    }

    [Test]
    public void DecemberSecond()
    {
        var input = @"123\t\n\456\t\n19 80";

        var input2 = @"5195
753
2468";

        var sut = new DecemberSecond();

        var result = sut.Calculate(input2);

        Assert.AreEqual(result, 18);
    }
}
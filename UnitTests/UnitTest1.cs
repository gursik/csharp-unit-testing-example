using MyProject;

namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void PassingTestOne()
    {
        int result = MyProject.Program.Add(5, 6);

        Assert.StrictEqual(11, result);
    }

    [Fact]
    public void PassingTestTwo()
    {
        int result = MyProject.Program.Add(5, 6);

        Assert.StrictEqual(11, result);
    }
}
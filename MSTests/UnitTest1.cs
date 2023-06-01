using MyProject;

namespace MSTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        int result = MyProject.Program.Add(4, 5);

        Assert.AreEqual(result, 9);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int result = MyProject.Program.Add(4, 5);

        Assert.AreEqual(result, 9);
    }
}

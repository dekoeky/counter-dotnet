namespace counter_dotnet.tests;

/// <summary>
/// <see cref="Counter{T}"/> related tests.
/// </summary>
[TestClass]
public class CounterTests
{
    [TestMethod]
    public void TestConstructor()
    {
        //Arrange
        ulong start = 1;
        ulong end = 100;
        TimeSpan delay = TimeSpan.FromSeconds(1);

        //Act
        var counter = new Counter<ulong>(start, end, delay);

        //Assert
        Assert.IsNotNull(counter);
    }
}
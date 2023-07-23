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

    [TestMethod]
    public void TestRun()
    {
        //Arrange
        ulong start = 1;
        ulong end = 100;
        TimeSpan delay = TimeSpan.FromMilliseconds(1);
        var counter = new Counter<ulong>(start, end, delay);

        //Act
        counter.Run();
        
        //Assert
        Assert.IsNotNull(counter);
    }

    [TestMethod]
    public async Task TestRunAsync()
    {
        //Arrange
        ulong start = 1;
        ulong end = 100;
        TimeSpan delay = TimeSpan.FromMilliseconds(1);
        var counter = new Counter<ulong>(start, end, delay);

        //Act
        await counter.RunAsync();
        
        //Assert
        Assert.IsNotNull(counter);
    }
}
namespace counter_dotnet.tests;

/// <summary>
/// <see cref="DefaultWelcomeBannerGenerator"/> related tests.
/// </summary>
[TestClass]
public class DefaultWelcomeBannerTests
{
    [TestMethod]
    public void TestConstructor()
    {
        //Arrange
        var generator = new DefaultWelcomeBannerGenerator();

        //Act
        var result = generator.GetBanner();

        //Assert
        Assert.IsNotNull(result);
        Assert.IsFalse(string.IsNullOrEmpty(result));
        Assert.IsFalse(string.IsNullOrWhiteSpace(result));
    }
}
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
        var banner = new DefaultWelcomeBannerGenerator();

        //Act
        var result = banner.GetBanner();

        //Assert
        Assert.IsNotNull(result);
        Assert.IsFalse(string.IsNullOrEmpty(result));
        Assert.IsFalse(string.IsNullOrWhiteSpace(result));
    }
}
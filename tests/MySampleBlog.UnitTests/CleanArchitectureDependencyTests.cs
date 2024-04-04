using NetArchTest.Rules;

namespace MySampleBlog.UnitTests;

public class CleanArchitectureDependencyTests
{
    [Fact]
    public void Application_Should_Have_Dependency_On_Domain()
    {
        //arrange
        var assembly = typeof(MySampleBolg.Application.Common.IAssemblyMarker).Assembly;

        //var result = Types.InAssembly(assembly).Should().HaveDependencyOn("MySampleBlog.Domain").GetResult();

        //act
        var result = Types.InAssembly(assembly) //Types.InCurrentDomain()
            .That()
            .ResideInNamespace("MySampleBlog.Application")
            .Should()
            .HaveDependencyOn("MySampleBlog.Domain")
            .GetResult();

        //assert
        Assert.True(result.IsSuccessful);
    }
}





















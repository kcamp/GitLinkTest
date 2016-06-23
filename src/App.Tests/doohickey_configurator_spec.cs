using FluentAssertions;
using NUnit.Framework;

namespace App.Tests
{
    [TestFixture]
    public class doohickey_configurator_spec
    {
        [Test]
        public void doohickey_configurator_should_return_correct_configuration()
        {
            var config = new DoohickeyConfigurator().WithCount(2).WithSize(10).Named("foobar").Build();
            config.Name.Should().Be("foobar");
            config.Count.Should().Be(2);
            config.Size.Should().Be(10);
        }
    }
}
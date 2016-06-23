using Moq;
using NUnit.Framework;

namespace App.Tests
{
    [TestFixture]
    public class doohickey_spec
    {
        [Test]
        public void doohickey_should_write_name_count_times()
        {
            var mockWriter = new Mock<IConsoleWriter>();
            mockWriter.Setup(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>())).Verifiable();
            var obj = new Doohickey(new DoohickeyConfiguration(5, "the doohickey", 10), mockWriter.Object);
            obj.Go();

            mockWriter.Verify(x => x.WriteLine("the doohickey", It.IsAny<object[]>()), Times.Exactly(5));
        }
    }
}

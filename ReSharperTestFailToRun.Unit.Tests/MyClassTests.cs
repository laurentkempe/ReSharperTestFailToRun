using NUnit.Framework;

namespace ReSharperTestFailToRun.Unit.Tests
{
    [TestFixture]
    public partial class MyClassTests
    {
        [Test]
        public void AnotherTest()
        {
            var myClass = new MyClass("name");

            Assert.That(myClass.Name, Is.EqualTo("name"));
        }
    }
}
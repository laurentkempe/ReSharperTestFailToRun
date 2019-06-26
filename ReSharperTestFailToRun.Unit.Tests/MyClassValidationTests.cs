using NUnit.Framework;

namespace ReSharperTestFailToRun.Unit.Tests
{
    [TestFixture]
    public partial class MyClassTests
    {
        [TestFixture]
        public class Validation
        {
            public class Name
            {
                [Test]
                public void NameIsCorrectlySet()
                {
                    var myClass = new MyClass("name");

                    Assert.That(myClass.Name, Is.EqualTo("name"));
                }
            }
        }
    }
}
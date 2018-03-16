using faradzen.utils.test.TestInfrastruct.Model;
using NUnit.Framework;
using System;

namespace faradzen.utils.test.Generic
{
    [TestFixture]
    public class PropertyHelperTests
    {
        [Test]
        public void GetPropertyTypeTest()
        {
            var helper = new utils.Generic.PropertyHelper(typeof(MyFoo));

            var res = helper.GetPropertyType("Name");
            Assert.AreEqual(typeof(string), res);

            res = helper.GetPropertyType("Oid");
            Assert.AreEqual(typeof(int), res);

            res = helper.GetPropertyType("Link");
            Assert.AreEqual(typeof(MyFooLink), res);

            res = helper.GetPropertyType("Price");
            Assert.AreEqual(typeof(int?), res);

            res = helper.GetPropertyType("Link.Value");
            Assert.AreEqual(typeof(string), res);

            res = helper.GetPropertyType("Link.Created");
            Assert.AreEqual(typeof(DateTime), res);

            res = helper.GetPropertyType("Link.Child");
            Assert.AreEqual(typeof(MyFooLink), res);

            res = helper.GetPropertyType("Link.Child.Value");
            Assert.AreEqual(typeof(string), res);
        }
    }
}

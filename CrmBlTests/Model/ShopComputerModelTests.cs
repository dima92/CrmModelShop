using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrmBl.Model.Tests
{
    [TestClass()]
    public class ShopComputerModelTests
    {
        [TestMethod()]
        public void StartTest()
        {
            var model = new ShopComputerModel();
            model.Start();
        }
    }
}
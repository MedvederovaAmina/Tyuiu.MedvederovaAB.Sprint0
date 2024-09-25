using Tyuiu.MedvederovaAB.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MedvederovaAB.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMessageValid()
        {
            var name = "Амина";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет , Амина", res);
        }
    }
}
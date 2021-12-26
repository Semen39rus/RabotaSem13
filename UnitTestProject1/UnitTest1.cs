using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RabotaSem13;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            AeroCar auto = new AeroCar("Аэромобиль");
            Tima auto2 = new Tima("Тьма");

            Assert.AreEqual("Аэромобиль", auto.name);
        }

        [TestMethod]
        public void TestMethod2()
        {
            AeroCar auto = new AeroCar("Аэромобиль");
            Assert.AreEqual("Аэромобиль, со скоростью, превышающей R17, вынес их по стальному туннелю на хмурую поверхность Магратеи, объятую мглистыми предрассветными сумерками.", auto.Deistvie());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Tima auto2 = new Tima("Тьма");
            Assert.AreEqual(auto2.name, "Тьма");
        }

        [TestMethod]
        public void TestMothod4()
        {
            Tima auto2 = new Tima("Тьма");
            Assert.AreEqual(auto2.Deistvie2(), "Сквозь тьму уже проступали пятна призрачного серого света.");
        }
    }
}

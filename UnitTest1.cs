using ClassLibrary10Lab;
namespace TestProjectLab10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NoParametrConctrTest()//часы без параметров 
        {
            //Arrange
            Watch clock = new Watch();
            //Act
            Watch watch = new Watch("NoBrand", 0, 1);
            //Assert
            Assert.AreEqual(watch.Brand, clock.Brand);
            Assert.AreEqual(watch.YearIssue, clock.YearIssue);
        }

        [TestMethod]
        public void BadParametrConctrTest() //некорректные парметры у часов
        {
            //Arrange
            Watch clock = new Watch("", 23, 1);
            //Act
            Watch watch = new Watch("", 0, 1);
            //Assert
            Assert.AreEqual(watch.Brand, clock.Brand);
            Assert.AreEqual(watch.YearIssue, clock.YearIssue);
        }

        [TestMethod]
        public void SmartNoParametrConctrTest()//умные часы без параметров
        {
            //Arrange
            SmartWatch clock = new SmartWatch();
            //Act
            SmartWatch watch = new SmartWatch("NoBrand", 0,1, "NoOS", false);
            //Assert
            Assert.AreEqual(watch.Brand, clock.Brand);
            Assert.AreEqual(watch.YearIssue, clock.YearIssue);
            Assert.AreEqual(watch.OS, clock.OS);
            Assert.AreEqual(watch.Pulsometer, clock.Pulsometer);
        }

        [TestMethod]
        public void SmartBadParametrConctrTest()//некорректные параметры умных часов
        {
            //Arrange
            SmartWatch clock = new SmartWatch("", 23, 1, "NoOS", false);
            //Act
            SmartWatch watch = new SmartWatch("", 0, 1, "NoOS", false);
            //Assert
            Assert.AreEqual(watch.Brand, clock.Brand);
            Assert.AreEqual(watch.YearIssue, clock.YearIssue);
            Assert.AreEqual(watch.OS, clock.OS);
            Assert.AreEqual(watch.Pulsometer, clock.Pulsometer);
        }
        //Arrange
        //Act
        //Assert
        [TestMethod]
        public void AnalogNoParametrConctrTest()//analog часы без параметров
        {
            //Arrange
            AnalogWatch clock = new AnalogWatch();
            //Act
            AnalogWatch watch = new AnalogWatch("NoBrand", 0, 1, "NoStyle");
            //Assert
            Assert.AreEqual(watch.Brand, clock.Brand);
            Assert.AreEqual(watch.YearIssue, clock.YearIssue);
            Assert.AreEqual(watch.Style, clock.Style);
        }

        [TestMethod]
        public void DigitalParametrConctrTest()//digital часы без параметров
        {
            //Arrange
            DigitalWatch clock = new DigitalWatch();
            //Act
            DigitalWatch watch = new DigitalWatch("NoBrand", 0, 1, "NoType");
            //Assert
            Assert.AreEqual(watch.Brand, clock.Brand);
            Assert.AreEqual(watch.YearIssue, clock.YearIssue);
            Assert.AreEqual(watch.TypeDisplay, clock.TypeDisplay);
        }

        [TestMethod]
        public void CopyTest()//copy
        {
            //Arrange
            Watch clock = new Watch();
            //Act
            Watch watch = (Watch)clock.ShallowCopy();
            //Assert
            Assert.AreEqual(watch.Brand, clock.Brand);
            Assert.AreEqual(watch.YearIssue, clock.YearIssue);
        }
        [TestMethod]
        public void CloneTest()//clone
        {
            //Arrange
            Watch clock = new Watch();
            //Act
            Watch watch = (Watch)clock.Clone();
            //Assert
            Assert.AreEqual(watch.Brand, clock.Brand);
            Assert.AreEqual(watch.YearIssue, clock.YearIssue);
        }

    }
}
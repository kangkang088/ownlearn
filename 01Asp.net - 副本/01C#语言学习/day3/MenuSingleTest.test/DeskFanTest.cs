using _05MenuSingleTest;
using System;
using Xunit;
using Moq;

namespace MenuSingleTest.test {
    public class DeskFanTest {
        [Fact]
        public void PowerLowerThan_OK() {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(num => num.GetPower()).Returns(() => 0);
            var fan = new DeskFan(mock.Object);
            var expected = "Won't work!";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PowerUpperThanTwoHundred_Warning() {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(num => num.GetPower()).Returns(() => 220);
            var fan = new DeskFan(mock.Object);
            var expected = "Warning";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }
    }    
}

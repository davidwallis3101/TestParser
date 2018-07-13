using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestParser;

namespace UnitTestProject1
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void TestMethod1()
        {
/*
            node_id; child_sensor_id; command; ack; type; payload\n

                node_id specifies the group of inputs / outputs on the Machinon board:

            1 = Digital status inputs(1 or 0, ON or OFF for each input)
            2 = Non -volatile counter inputs
            3 = Current Transformer inputs
            4 = Analogue Inputs
            5 = Digital Outputs
            6 = Front panel LCD, buttons and LED indicators
            child_sensor_id is the channel number, eg 1 for DIN1
*/
            //arrange
            string inputString = "1;1;1;0;2;0"; // channel 1 status has changed to "off"
            string expected = "test";

            //act
            var response = Parser.Parse("Something");

            //assert
            Assert.Equals(response, expected);
        }
    }
}

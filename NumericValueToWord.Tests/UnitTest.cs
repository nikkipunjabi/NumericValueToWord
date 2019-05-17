using System;
using System.Net;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumericValueToWord.Tests
{
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Test - 22.22
        /// Expected Output: twenty-two dollars and twenty-two cents
        /// </summary>
        [TestMethod]
        public void TestExampleOne()
        {
            //Expected Output
            ExpectedOutput output = new ExpectedOutput();
            output.Name = "nikki";
            output.Word = "twenty-two dollars and twenty-two cents";
            var expectedJson = new JavaScriptSerializer().Serialize(output);
            
            //Call Service and Get Json Response
            ServiceReference.NumericValueToWordSoapClient client = new ServiceReference.NumericValueToWordSoapClient();
            string response = client.ConvertNumericValueToWord("22", "nikki", "22");

            //Compare ExpectedJson and WebService JsonResponse
            Assert.AreEqual(expectedJson, response);
        }

        /// <summary>
        /// Test - 123.45
        /// Expected Output: one hundred and twenty-three dollars and forty-five cents
        /// </summary>
        [TestMethod]
        public void TestExampleTwo()
        {
            ExpectedOutput output = new ExpectedOutput();
            output.Name = "Nikki";
            output.Word = "one hundred and twenty-three dollars and forty-five cents";
            var expectedJson = new JavaScriptSerializer().Serialize(output);

            ServiceReference.NumericValueToWordSoapClient client = new ServiceReference.NumericValueToWordSoapClient();
            string response = client.ConvertNumericValueToWord("123", "Nikki", "45");

            Assert.AreEqual(expectedJson, response);
        }

        /// <summary>
        /// Test - 100
        /// Expected Output: one hundred dollars
        /// </summary>
        [TestMethod]
        public void TestExampleThree()
        {
            ExpectedOutput output = new ExpectedOutput();
            output.Name = "Nikki";
            output.Word = "one hundred dollars";
            var expectedJson = new JavaScriptSerializer().Serialize(output);

            ServiceReference.NumericValueToWordSoapClient client = new ServiceReference.NumericValueToWordSoapClient();
            string response = client.ConvertNumericValueToWord("100", "Nikki", "");

            Assert.AreEqual(expectedJson, response);
        }

        /// <summary>
        /// Test - 1 Dollar
        /// Expected Output: one dollar
        /// </summary>
        [TestMethod]
        public void TestExampleFour()
        {
            ExpectedOutput output = new ExpectedOutput();
            output.Name = "Nikki";
            output.Word = "one dollar";
            var expectedJson = new JavaScriptSerializer().Serialize(output);

            ServiceReference.NumericValueToWordSoapClient client = new ServiceReference.NumericValueToWordSoapClient();
            string response = client.ConvertNumericValueToWord("1", "Nikki", "");

            Assert.AreEqual(expectedJson, response);
        }

        /// <summary>
        /// Test - 1 dollar and 1 cent
        /// Expected Output: one dollar
        /// </summary>
        [TestMethod]
        public void TestExampleFive()
        {
            ExpectedOutput output = new ExpectedOutput();
            output.Name = "Nikki";
            output.Word = "one dollar and one cent";
            var expectedJson = new JavaScriptSerializer().Serialize(output);

            ServiceReference.NumericValueToWordSoapClient client = new ServiceReference.NumericValueToWordSoapClient();
            string response = client.ConvertNumericValueToWord("1", "Nikki", "01");

            Assert.AreEqual(expectedJson, response);
        }

        /// <summary>
        /// Test - 1 dollar and 10 cents
        /// Expected Output: one dollar
        /// </summary>
        [TestMethod]
        public void TestExampleSix()
        {
            ExpectedOutput output = new ExpectedOutput();
            output.Name = "Nikki";
            output.Word = "one dollar and ten cents";
            var expectedJson = new JavaScriptSerializer().Serialize(output);

            ServiceReference.NumericValueToWordSoapClient client = new ServiceReference.NumericValueToWordSoapClient();
            string response = client.ConvertNumericValueToWord("1", "Nikki", "10");

            Assert.AreEqual(expectedJson, response);
        }

        /// <summary>
        /// Test - 2 dollars and 20 cents
        /// Expected Output: two dollars and twenty cents
        /// </summary>
        [TestMethod]
        public void TestExampleSeven()
        {
            ExpectedOutput output = new ExpectedOutput();
            output.Name = "Nikki";
            output.Word = "two dollars and twenty cents";
            var expectedJson = new JavaScriptSerializer().Serialize(output);

            ServiceReference.NumericValueToWordSoapClient client = new ServiceReference.NumericValueToWordSoapClient();
            string response = client.ConvertNumericValueToWord("2", "Nikki", "2");

            Assert.AreEqual(expectedJson, response);
        }

        /// <summary>
        /// Test - 555.55
        /// Expected Output: five hundred and fifty-five dollars and fifty-five cents
        /// </summary>
        [TestMethod]
        public void TestExampleEight()
        {
            ExpectedOutput output = new ExpectedOutput();
            output.Name = "Nikki";
            output.Word = "five hundred and fifty-five dollars and fifty-five cents";
            var expectedJson = new JavaScriptSerializer().Serialize(output);

            ServiceReference.NumericValueToWordSoapClient client = new ServiceReference.NumericValueToWordSoapClient();
            string response = client.ConvertNumericValueToWord("555", "Nikki", "55");

            Assert.AreEqual(expectedJson, response);
        }

        /// <summary>
        /// Test Error Message
        /// Expected Output: Error: Please enter the number properly and do not enter more than 2 billion dollars
        /// </summary>
        [TestMethod]
        public void TestError()
        {
            string expectedOutput = "Error: Please enter the number properly and do not enter more than 2 billion dollars";

            ServiceReference.NumericValueToWordSoapClient client = new ServiceReference.NumericValueToWordSoapClient();
            string response = client.ConvertNumericValueToWord("2147483648", "Nikki", "");

            Assert.AreEqual(expectedOutput, response);
        }
    }

    public class ExpectedOutput
    {
        public string Name { get; set; }
        public string Word { get; set; }
    }
}

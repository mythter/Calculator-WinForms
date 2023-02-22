/*
Файл: Calculator.Tests.cs
Лабораторная робота № 1
Автор: Положий А. С.
Тема: Розробка та дослідження лінійних програм
Дата створення: 09.02.2023
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_2andMinus10_Minus8Returned()
        {
            string a = "2";
            string b = "-10";
            string expetded = "-8";

            string actual = Operations.Add(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Add_12345and12345_24690Returned()
        {
            string a = "12345";
            string b = "12345";
            string expetded = "24690";

            string actual = Operations.Add(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Add_Minus125andMinus879_Minus24690Returned()
        {
            string a = "-125";
            string b = "-879";
            string expetded = "-1004";

            string actual = Operations.Add(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Sub_2andMinus10_12Returned()
        {
            string a = "2";
            string b = "-10";
            string expetded = "12";

            string actual = Operations.Sub(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Sub_12345and12345_0Returned()
        {
            string a = "12345";
            string b = "12345";
            string expetded = "0";

            string actual = Operations.Sub(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Sub_Minus125andMinus879_754Returned()
        {
            string a = "-125";
            string b = "-879";
            string expetded = "754";

            string actual = Operations.Sub(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Mul_2andMinus10_Minus20Returned()
        {
            string a = "2";
            string b = "-10";
            string expetded = "-20";

            string actual = Operations.Mul(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Mul_12345and12345_152399025Returned()
        {
            string a = "12345";
            string b = "12345";
            string expetded = "152399025";

            string actual = Operations.Mul(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Mul_125andMinus879_Minus109875Returned()
        {
            string a = "125";
            string b = "-879";
            string expetded = "-109875";

            string actual = Operations.Mul(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Mul_0andMinus879_0Returned()
        {
            string a = "0";
            string b = "-879";
            string expetded = "0";

            string actual = Operations.Mul(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Div_Minus10and2_Minus5Returned()
        {
            string a = "-10";
            string b = "2";
            string expetded = "-5";

            string actual = Operations.Div(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Div_12345and12345_1Returned()
        {
            string a = "12345";
            string b = "12345";
            string expetded = "1";

            string actual = Operations.Div(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Div_Minus879andMinus125_7dot032Returned()
        {
            string a = "-879";
            string b = "-125";
            string expetded = "7.032";

            string actual = Operations.Div(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Div_0and87_0Returned()
        {
            string a = "0";
            string b = "87";
            string expetded = "0";

            string actual = Operations.Div(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Div_87and0_ErrReturned()
        {
            string a = "87";
            string b = "0";
            string expetded = "Err";

            string actual = Operations.Div(a, b);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Sin_0_0Returned()
        {
            string a = "0";
            string expetded = "0";

            string actual = Operations.Sin(a);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Sin_1_0dot841471Returned()
        {
            string a = "1";
            string expetded = "0.841471";

            string actual = Operations.Sin(a);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Cos_0_1Returned()
        {
            string a = "0";
            string expetded = "1";

            string actual = Operations.Cos(a);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Cos_1_0dot5403023Returned()
        {
            string a = "1";
            string expetded = "0.5403023";

            string actual = Operations.Cos(a);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Sqrt_81_9Returned()
        {
            string a = "81";
            string expetded = "9";

            string actual = Operations.Sqrt(a);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Cbrt_27_3Returned()
        {
            string a = "27";
            string expetded = "3";

            string actual = Operations.CubeRoot(a);

            Assert.AreEqual(double.Parse(expetded, NumberStyles.Any, CultureInfo.InvariantCulture), double.Parse(actual, NumberStyles.Any, CultureInfo.InvariantCulture), 0.00001);
        }

        [TestMethod]
        public void Square_9_81Returned()
        {
            string a = "9";
            string expetded = "81";

            string actual = Operations.Square(a);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Cube_3_27Returned()
        {
            string a = "3";
            string expetded = "27";

            string actual = Operations.Cube(a);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Fraction_5_0dot2Returned()
        {
            string a = "5";
            string expetded = "0.2";

            string actual = Operations.Fraction(a);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Inverse_123_Minus123Returned()
        {
            string a = "123";
            string expetded = "-123";

            string actual = Operations.Inverse(a);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Inverse_Minus321_321Returned()
        {
            string a = "-321";
            string expetded = "321";

            string actual = Operations.Inverse(a);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Log10_1000_3Returned()
        {
            string a = "1000";
            string expetded = "3";

            string actual = Operations.Log10(a);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Log10_0_ErrReturned()
        {
            string a = "0";
            string expetded = "Err";

            string actual = Operations.Log10(a);

            Assert.AreEqual(expetded, actual);
        }

        [TestMethod]
        public void Log10_Minus100_ErrReturned()
        {
            string a = "-100";
            string expetded = "Err";

            string actual = Operations.Log10(a);

            Assert.AreEqual(expetded, actual);
        }
    }
}

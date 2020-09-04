using System;
using Xunit;

namespace ConsoleCalculator.Tests
{
    public class CalculatorFixture
    {
        Calculator calculator;
        public CalculatorFixture()
        {
            calculator = new Calculator();
        }

        [Fact]
        public void Test_sendkey_with_NotImplementedException()
        {
            Assert.Throws<NotImplementedException>(() => calculator.SendKeyPress('\0'));
        }

        [Fact]
        public void test_sendkey_return_empty()
        {
            Assert.Equal("1", calculator.SendKeyPress('1'));
        }

        [Fact]
        public void test_addopration_with_two_numbaers()
        {
            Assert.Equal("1", calculator.SendKeyPress('1'));
            Assert.Equal("12", calculator.SendKeyPress('2'));
            Assert.Equal("12", calculator.SendKeyPress('+'));
            Assert.Equal("3", calculator.SendKeyPress('3'));
            Assert.Equal("15", calculator.SendKeyPress('+'));
        }

        [Fact]
        public void test_addopration_with_twodigit_second_numbers()
        {
            Assert.Equal("1", calculator.SendKeyPress('1'));
            Assert.Equal("12", calculator.SendKeyPress('2'));
            Assert.Equal("12", calculator.SendKeyPress('+'));
            Assert.Equal("3", calculator.SendKeyPress('3'));
            Assert.Equal("31", calculator.SendKeyPress('1'));
            Assert.Equal("43", calculator.SendKeyPress('+'));
        }

        [Fact]
        public void test_addopration_with_twodigit_first_numbers()
        {
            Assert.Equal("1", calculator.SendKeyPress('1'));
            Assert.Equal("12", calculator.SendKeyPress('2'));
            Assert.Equal("122", calculator.SendKeyPress('2'));
            Assert.Equal("122", calculator.SendKeyPress('+'));
            Assert.Equal("3", calculator.SendKeyPress('3'));
            Assert.Equal("31", calculator.SendKeyPress('1'));
            Assert.Equal("153", calculator.SendKeyPress('+'));
        }

        [Fact]
        public void test_add_with_twodigit_onedigit_numbers()
        {
            Assert.Equal("1", calculator.SendKeyPress('1'));
            Assert.Equal("10", calculator.SendKeyPress('0'));
            Assert.Equal("10", calculator.SendKeyPress('+'));
            Assert.Equal("2", calculator.SendKeyPress('2'));
            Assert.Equal("12", calculator.SendKeyPress('='));
        }

        [Fact]
        public void test_dicision_by_zero_number()
        {
            Assert.Equal("1", calculator.SendKeyPress('1'));
            Assert.Equal("10", calculator.SendKeyPress('0'));
            Assert.Equal("10", calculator.SendKeyPress('/'));
            Assert.Equal("0", calculator.SendKeyPress('0'));
            Assert.Equal("-E-", calculator.SendKeyPress('='));
        }

        [Fact]
        public void test_multi_oparators_with_number()
        {
            Assert.Equal("1", calculator.SendKeyPress('1'));
            Assert.Equal("1", calculator.SendKeyPress('+'));
            Assert.Equal("2", calculator.SendKeyPress('2'));
            Assert.Equal("3", calculator.SendKeyPress('+'));
            Assert.Equal("3", calculator.SendKeyPress('3'));
            Assert.Equal("6", calculator.SendKeyPress('+'));
            Assert.Equal("12", calculator.SendKeyPress('='));

        }

        [Fact]
        public void test_oprator_and_reset()
        {
            Assert.Equal("1", calculator.SendKeyPress('1'));
            Assert.Equal("1", calculator.SendKeyPress('+'));
            Assert.Equal("2", calculator.SendKeyPress('2'));
            Assert.Equal("3", calculator.SendKeyPress('+'));
            Assert.Equal("0", calculator.SendKeyPress('c'));
        }

        [Fact]
        public void test_minus_oprator_and_reset()
        {
            Assert.Equal("2", calculator.SendKeyPress('2'));
            Assert.Equal("2", calculator.SendKeyPress('-'));
            Assert.Equal("1", calculator.SendKeyPress('1'));
            Assert.Equal("1", calculator.SendKeyPress('='));
            Assert.Equal("0", calculator.SendKeyPress('c'));
        }

        [Fact]
        public void test_multipication_oprator_and_reset()
        {
            Assert.Equal("1", calculator.SendKeyPress('1'));
            Assert.Equal("12", calculator.SendKeyPress('2'));
            Assert.Equal("12", calculator.SendKeyPress('*'));
            Assert.Equal("2", calculator.SendKeyPress('2'));
            Assert.Equal("24", calculator.SendKeyPress('='));
            Assert.Equal("0", calculator.SendKeyPress('c'));
        }

        [Fact]
        public void test_oprator_and_sign_toggled()
        {
            Assert.Equal("1", calculator.SendKeyPress('1'));
            Assert.Equal("12", calculator.SendKeyPress('2'));
            Assert.Equal("12", calculator.SendKeyPress('+'));
            Assert.Equal("2", calculator.SendKeyPress('2'));
            Assert.Equal("-2", calculator.SendKeyPress('s'));
            Assert.Equal("2", calculator.SendKeyPress('s'));
            Assert.Equal("-2", calculator.SendKeyPress('s'));
            Assert.Equal("10", calculator.SendKeyPress('='));
        }

    }
}

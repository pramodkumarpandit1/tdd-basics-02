using System;
using System.Linq;

namespace ConsoleCalculator
{
    public class Calculate
    {
        private char opratorChar;
        private string displayNumber;
        private bool isClear;
        private double num1;
        private readonly char[] validChar;
        private readonly char[] validOperator;
        public Calculate()
        {
            validChar = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.' };
            validOperator = new char[] { '+', '-', '*', '/', '.', 'c', 's', '=' };
        }

        public string ComputeAndValidate(char key)
        {
            if (validChar.Contains(key))
            {
                return ValidateDigit(key);
            }
            else if (validOperator.Contains(key))
            {
                ValidateCompute(key);
            }
            return displayNumber;
        }

        private void ValidateCompute(char ch)
        {
            if (opratorChar != '\0' && ch != 's' && ch != 'c')
            {
                OprationCalculate(opratorChar);
            }
            else
            {
                num1 = Convert.ToDouble(displayNumber);
            }
            opratorChar = ch;
            isClear = true;
            switch (ch)
            {
                case 's':
                    displayNumber = Convert.ToString(Convert.ToDouble(displayNumber) * -1);
                    opratorChar = Convert.ToDouble(displayNumber) > 0 ? '+' : '-';
                    break;
                case 'c':
                    opratorChar = '\0';
                    displayNumber = "0";
                    isClear = false;
                    break;
            }

        }

        private string ValidateDigit(char ch)
        {
            if (isClear)
            {
                displayNumber = string.Empty;
                isClear = false;
            }
            displayNumber = Convert.ToDouble($"{displayNumber}{ch}").ToString();
            return displayNumber;
        }
        private void OprationCalculate(char Operation)
        {
            double num2;
            double result;
            num2 = Convert.ToDouble(displayNumber);

            switch (Operation)
            {
                case '+':
                    result = (num1 + num2);
                    displayNumber = Convert.ToString(result);
                    num1 = result;
                    break;
                case '-':
                    result = (num1 - num2);
                    displayNumber = Convert.ToString(result);
                    num1 = result;
                    break;
                case '*':
                    result = (num1 * num2);
                    displayNumber = Convert.ToString(result);
                    num1 = result;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        displayNumber = "-E-";

                    }
                    else
                    {
                        result = (num1 / num2);
                        displayNumber = Convert.ToString(result);
                        num1 = result;
                    }
                    break;

            }
        }
    }
}

using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        private readonly Calculate calculate;
        public Calculator()
        {
            calculate = new Calculate();
        }
        public string SendKeyPress(char key)
        {
            try
            {
                return calculate.ComputeAndValidate(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

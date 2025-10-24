namespace Calculators
{
    public class SimpleCalculator
    {
        private decimal value;

        public SimpleCalculator Reset()
        {
            value = 0;
            return this;
        }

        public SimpleCalculator Enter(decimal initial)
        {
            value = initial;
            return this;
        }

        public SimpleCalculator Plus(decimal operand)
        {
            value += operand;
            return this;
        }

        public SimpleCalculator Minus(decimal operand)
        {
            value -= operand;
            return this;
        }

        public SimpleCalculator MultiplyBy(decimal operand)
        {
            value *= operand;
            return this;
        }

        public SimpleCalculator DivideBy(decimal operand)
        {
            if (operand == 0)
                throw new DivideByZeroException();
            value /= operand;
            return this;
        }

        public decimal Equals()
        {
            return value;
        }
    }
}
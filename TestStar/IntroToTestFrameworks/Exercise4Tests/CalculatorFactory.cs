using Calculators;

namespace Exercise4
{
    public class CalculatorFactory
    {
        public SimpleCalculator CreateWithInitialStateOf(decimal initialState)
        {
            return new SimpleCalculator().Reset().Enter(initialState);
        }
    }
}
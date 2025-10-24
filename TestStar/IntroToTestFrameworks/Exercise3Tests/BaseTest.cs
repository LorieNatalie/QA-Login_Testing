namespace Exercise3Tests
{

    using NUnit.Framework;
    using Calculators;

    public class BaseTest
    {
        protected SimpleCalculator calculator;

        [SetUp]
        public void BaseSetup()
        {
            // Initialize calculator and set starting value to 4
            calculator = new SimpleCalculator().Reset().Enter(4);
            TestContext.Progress.WriteLine("BaseSetup invoked");
        }

        [TearDown]
        public void BaseTeardown()
        {
            // Reset or dispose of calculator if needed
            calculator = null;
            TestContext.Progress.WriteLine("BaseTeardown invoked");
        }
    }
}
namespace HomeWork4.Strategy
{
    public class StrategyContext
    {
        private IStrategyHandle _strategy;

        public StrategyContext(IStrategyHandle strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategyHandle strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            _strategy.Proceed();
        }
    }
}
using System;
namespace Patterns.Decorator
{
	public class DSugar :Decorator
	{
		public DSugar(BaseBeverage beverage) : base (beverage) { }

        public override double Cost => _beverage.Cost + 0.5;

        public override string Description => string.Format($"{_beverage.Description}, Sugar");
    }
}


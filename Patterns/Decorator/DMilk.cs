using System;
namespace Patterns.Decorator
{
	public class DMilk : Decorator
	{
		public DMilk(BaseBeverage beverage) : base(beverage) { }

        public override double Cost => _beverage.Cost + 2;

        public override string Description => string.Format($"{_beverage.Description}, Milk");
    }
}


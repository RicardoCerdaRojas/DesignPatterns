using System;
namespace Patterns.Decorator
{
	public class DCream : Decorator
	{
		public DCream(BaseBeverage beverage) : base(beverage) { }

		public override double Cost => _beverage.Cost + 4;

		public override string Description => string.Format($"{_beverage.Description}, Milk");
	}
}


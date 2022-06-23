using System;
namespace Patterns.Decorator
{
	public abstract class Decorator : BaseBeverage
	{
		protected BaseBeverage _beverage;

		public Decorator(BaseBeverage beverage)
        {
			_beverage = beverage;
        }
	}
}


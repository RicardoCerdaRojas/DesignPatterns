using System;
namespace Patterns.Decorator
{
	public class BDecafCoffee : BaseBeverage
	{
		public override double Cost => 15;

		public override string Description => "Decaf Coffe";

	}
}


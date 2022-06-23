using System;
namespace Patterns.Decorator
{
	public class BExpressCoffee : BaseBeverage
	{
		public override double Cost => 12;

		public override string Description => "Express Coffee";

	}
}


using System;
namespace Patterns.Decorator
{
	public class BRegularTea : BaseBeverage
	{
		public override double Cost => 8;

		public override string Description => "Regular Tea";

	}
}


using System;
namespace Patterns.Decorator
{
	public class DSweetener : Decorator
	{
		public DSweetener(BaseBeverage beverage) : base(beverage) { }

        public override double Cost => _beverage.Cost + 1;

        public override string Description => string.Format($"{_beverage.Description}, Sweetener");
    }
}


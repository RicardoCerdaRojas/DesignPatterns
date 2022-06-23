using System;
namespace Patterns.Decorator
{
    public class BCoffe : BaseBeverage
    {
        public override double Cost => 10;

        public override string Description => "Regular Coffee";
    }
}


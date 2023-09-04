using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Builder
{
    public class WoodenHouse : BaseBuilder
    {
        public WoodenHouse(string nameBuilder) : base(nameBuilder)
        {
            nameHouse = "Glass house";
        }

        protected override void BuildFound()
        {
            Console.WriteLine("The foundation of the house is made of wood");
        }

        protected override void BuildRoof()
        {
            Console.WriteLine("The roof of the house is made of wood");
        }

        protected override void BuildWals()
        {
            Console.WriteLine("The walls of the house are made of wood");
        }
    }
}

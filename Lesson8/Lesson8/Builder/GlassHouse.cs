using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Builder
{
    public class GlassHouse : BaseBuilder
    {
        public GlassHouse(string nameBuilder) : base(nameBuilder)
        {
            nameHouse = "Glass house";
        }

        protected override void BuildFound()
        {
            Console.WriteLine("The foundation of the house is made of glass");
        }

        protected override void BuildRoof()
        {
            Console.WriteLine("The roof of the house is made of glass");
        }

        protected override void BuildWals()
        {
            Console.WriteLine("The walls of the house are made of glass");
        }
    }
}

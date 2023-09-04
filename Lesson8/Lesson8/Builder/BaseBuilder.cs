using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Builder
{
    public abstract class BaseBuilder
    {
        public string nameBuilder;
        public string nameHouse;

        public BaseBuilder(string nameBuilder)
        {
            this.nameBuilder = nameBuilder;
            nameHouse = string.Empty;
        }


        public void HouseBuild()
        {
            BuildRoof();
            BuildWals();
            BuildFound();
        }

        protected abstract void BuildRoof();

        protected abstract void BuildWals();

        protected abstract void BuildFound();

    }
}

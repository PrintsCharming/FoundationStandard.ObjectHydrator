using System.Collections.Generic;
using FoundationStandard.ObjectHydrator.Interfaces;

namespace FoundationStandard.ObjectHydrator.Generators
{
    public class GenderGenerator : IGenerator<string>
    {



        public string Generate()
        {
            return ((IGenerator<string>)new FromListGetSingleGenerator<string>(new List<string> { "Male", "Female" })).Generate();
        }
    }
}

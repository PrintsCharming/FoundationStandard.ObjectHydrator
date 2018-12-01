using System.Collections.Generic;
using FoundationStandard.ObjectHydrator.Interfaces;


namespace FoundationStandard.ObjectHydrator.Generators
{
    public class CreditCardTypeGenerator:IGenerator<string>
    {
 
        public string Generate()
        {
            return
                new FromListGetSingleGenerator<string>(new List<string>
                                                  {
                                                      "MasterCard",
                                                      "Visa",
                                                      "Discover",
                                                      "American Express"
                                                  })
                    .Generate();
        }
    }
}

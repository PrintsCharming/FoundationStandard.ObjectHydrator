using FoundationStandard.ObjectHydrator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationStandard.ObjectHydrator.Generators
{
    public class ISBNGenerator : IGenerator<string>
    {
        private readonly Random _random = RandomSingleton.Instance.Random;

        public string Generate()
        {
            var stringbuilder = new StringBuilder();
            stringbuilder.Append("978-1-");
            stringbuilder.Append(_random.Next(00000, 99999).ToString());
            stringbuilder.Append("-");
            stringbuilder.Append(_random.Next(000, 999).ToString());
            stringbuilder.Append("-");
            stringbuilder.Append(_random.Next(0, 9).ToString());
            return stringbuilder.ToString();
        }
    }
}

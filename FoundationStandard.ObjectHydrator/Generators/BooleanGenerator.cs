using System;
using FoundationStandard.ObjectHydrator.Interfaces;

namespace FoundationStandard.ObjectHydrator.Generators
{
    public class BooleanGenerator : IGenerator<bool>
    {
        private readonly Random random;

        public BooleanGenerator()
        {
            random = RandomSingleton.Instance.Random;
        }

        #region IGenerator Members

        public bool Generate()
        {
            return Convert.ToBoolean(random.Next(0, 2));
        }

        #endregion
    }
}
using System;
using FoundationStandard.ObjectHydrator.Interfaces;

namespace FoundationStandard.ObjectHydrator.Generators
{
    public class GuidGenerator : IGenerator<Guid>
    {
        #region IGenerator Members

        public Guid Generate()
        {
            return Guid.NewGuid();
        }

        #endregion
    }
}

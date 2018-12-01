using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationStandard.ObjectHydrator.Interfaces
{
    public interface IGenerator
    {
        object Generate();
    }

    public interface IGenerator<T>
    {
        T Generate();
    }
}

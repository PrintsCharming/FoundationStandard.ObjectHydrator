using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FoundationStandard.ObjectHydrator.Interfaces
{
    public interface IMap
    {
        Type Type { get; }
        bool Match(PropertyInfo info);
        IMapping Mapping(PropertyInfo info);
    }
}

using FoundationStandard.ObjectHydrator.Generators;
using FoundationStandard.ObjectHydrator.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FoundationStandard.ObjectHydrator
{
    public class Map<T> : IMap
    {
        private Func<PropertyInfo, bool> _func;
        private IGenerator<T> _generator;

        public Map()
        {
            _func = info => info.CanWrite;
        }

        Type IMap.Type
        {
            get
            {
                return typeof(T);
            }
        }

        bool IMap.Match(PropertyInfo info)
        {
            return _func(info);
        }

        IMapping IMap.Mapping(PropertyInfo info)
        {
            return new Mapping<T>(info, _generator);
        }

        public Map<T> Matching(Func<PropertyInfo, bool> func)
        {
            _func = func;
            return this;
        }

        public Map<T> Using(IGenerator<T> generator)
        {
            _generator = generator;
            return this;
        }

        public Map<T> Using(T defaultValue)
        {
            _generator = new DefaultGenerator<T>(defaultValue);
            return this;
        }

    }
}

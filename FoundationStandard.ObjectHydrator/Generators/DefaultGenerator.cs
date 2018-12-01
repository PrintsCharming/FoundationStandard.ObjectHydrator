﻿using FoundationStandard.ObjectHydrator.Interfaces;

namespace FoundationStandard.ObjectHydrator.Generators
{
    public class DefaultGenerator<T> : IGenerator<T>
    {
        public T DefaultValue { get; private set; }

        public DefaultGenerator(T defaultValue)
        {
            DefaultValue = defaultValue;
        }

        public T Generate()
        {
            return DefaultValue;
        }

    }
}

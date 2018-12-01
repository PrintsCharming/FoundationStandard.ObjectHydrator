using FoundationStandard.ObjectHydrator.Interfaces;

namespace FoundationStandard.ObjectHydrator.Generators
{
    public class NullGenerator:IGenerator<object>
    {
        public object Generate()
        {
            return null;
        }
    }
}

using FoundationStandard.ObjectHydrator.Interfaces;

namespace FoundationStandard.ObjectHydrator.Generators
{
    public class TypeGenerator<T>:IGenerator<T>
    {
        public T Generate()
        {
            return new Hydrator<T>().GetSingle();
        }
    }
}

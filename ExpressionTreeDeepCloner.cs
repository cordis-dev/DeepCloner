namespace Adroiti.SapphirePilot.Core.Features.DeepCloning
{
    public sealed class ExpressionTreeDeepCloner : IDeepCloner
    {
        public T Clone<T>(T objectToClone)
        {
            return DeepClonerGenerator.CloneObject(objectToClone);
        }
    }
}
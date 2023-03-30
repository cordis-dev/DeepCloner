namespace Adroiti.SapphirePilot.Core.Features.DeepCloning
{
    public interface IDeepCloner
    {
        T Clone<T>(T objectToClone);
    }
}
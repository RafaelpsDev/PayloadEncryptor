namespace PayloadEncryptor.Domain.Interfaces.Factories
{
    public interface IMockJsonFactory
    {
        string Generate(string type, string operation);
    }
}

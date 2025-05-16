using System.Security.Cryptography;

namespace PayloadEncryptor.Domain.Interfaces.Application;

public interface IEncryptService
{
    ICryptoTransform CreateAesEncryptor(byte[] key);
    string? EncryptPayload(string json, ICryptoTransform encryptor);
}

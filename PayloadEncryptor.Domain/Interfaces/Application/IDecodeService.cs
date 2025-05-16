using System.Security.Cryptography;

namespace PayloadEncryptor.Domain.Interfaces.Application;

public interface IDecodeService
{
    void DecodePrivateKeyPem(string localPrivateKeyBase64, RSA rsa);
}

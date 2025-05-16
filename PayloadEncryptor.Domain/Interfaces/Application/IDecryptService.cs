using System.Security.Cryptography;

namespace PayloadEncryptor.Domain.Interfaces.Application;
public interface IDecryptService
{
    byte[] DecryptAesKey(string dockCryptoKeyBase64, RSA rsa);

}

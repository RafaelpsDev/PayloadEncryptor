using PayloadEncryptor.Domain.Interfaces.Application;
using System.Security.Cryptography;

namespace PayloadEncryptor.Application.Services;

public sealed class DecryptService : IDecryptService
{
    public byte[] DecryptAesKey(string dockCryptoKeyBase64, RSA rsa)
    {
        var encryptedKeyBytes
            = Convert.FromBase64String(dockCryptoKeyBase64);

        return rsa
            .Decrypt(
            encryptedKeyBytes,
            RSAEncryptionPadding.Pkcs1);
    }
}

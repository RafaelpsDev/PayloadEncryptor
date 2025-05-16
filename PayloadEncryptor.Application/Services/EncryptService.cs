using PayloadEncryptor.Domain.Interfaces.Application;
using System.Security.Cryptography;
using System.Text;

namespace PayloadEncryptor.Application.Services;

public sealed class EncryptService : IEncryptService
{
    public ICryptoTransform CreateAesEncryptor(byte[] key)
    {
        using var aes = Aes.Create();
        aes.Key = key;
        aes.IV = new byte[16];
        aes.Padding = PaddingMode.PKCS7;
        aes.Mode = CipherMode.CBC;

        return aes.CreateEncryptor();
    }

    public string? EncryptPayload(string json, ICryptoTransform encryptor)
    {
        var plainBytes = Encoding.UTF8.GetBytes(json);
        var encryptedPayload = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
        return Convert.ToBase64String(encryptedPayload);
    }
}



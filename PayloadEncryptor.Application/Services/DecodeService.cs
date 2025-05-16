using PayloadEncryptor.Domain.Interfaces.Application;
using System.Security.Cryptography;
using System.Text;

namespace PayloadEncryptor.Application.Services;
public sealed class DecodeService : IDecodeService
{
    public void DecodePrivateKeyPem(string localPrivateKeyBase64, RSA rsa)
    {
        var pem = Encoding
            .UTF8
            .GetString(
                Convert
                .FromBase64String(localPrivateKeyBase64));
        
        rsa.ImportFromPem(pem);
    }
}

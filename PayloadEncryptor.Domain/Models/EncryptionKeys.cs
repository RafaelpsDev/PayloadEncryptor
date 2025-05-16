using PayloadEncryptor.Domain.Utils;

namespace PayloadEncryptor.Domain.Models;

public sealed class EncryptionKeys
{
    public string LocalPrivateKeyBase64 { get; }
    public string CryptoKeyBase64 { get; }

    public EncryptionKeys(string localPrivateKeyBase64, string cryptoKeyBase64)
    {
        LocalPrivateKeyBase64 = CleanKey(localPrivateKeyBase64);
        CryptoKeyBase64 = CleanKey(cryptoKeyBase64);

        if (string.IsNullOrEmpty(LocalPrivateKeyBase64))
        {
            Console.WriteLine(ConsoleMessages.LocalPrivateKeyNull);
            Environment.Exit(1);
        }

        if (string.IsNullOrEmpty(cryptoKeyBase64))
        {
            Console.WriteLine(ConsoleMessages.CryptoKeyNull);
            Environment.Exit(1);
        }
    }
    private static string CleanKey(string? key)
    {
        if (key == null)
            return string.Empty;
        return string.Concat(key.Where(c => !char.IsWhiteSpace(c)));
    }
}

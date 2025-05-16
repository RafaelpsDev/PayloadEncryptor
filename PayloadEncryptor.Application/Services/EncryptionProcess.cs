using PayloadEncryptor.Domain.Interfaces.Application;
using PayloadEncryptor.Domain.Interfaces.Infrastructure.Services;
using PayloadEncryptor.Domain.Models;
using PayloadEncryptor.Domain.Utils;
using System.Security.Cryptography;

namespace PayloadEncryptor.Application.Services;

public sealed class EncryptionProcess(
    IInputReader inputReader,
    IDecodeService decodeService,
    IDecryptService decryptService,
    IEncryptService encryptService)
    : IEncryptionProcess
{
    public void Execute()
    {
        ConsolePresentationHelper.PrintTitle();

        ConsolePresentationHelper.CenterReadLine(ConsoleMessages.LocalPrivateKey);
        var localPrivateKeyBase64 = Console.ReadLine();

        ConsolePresentationHelper.CenterReadLine(ConsoleMessages.CryptoKey);
        var cryptoKeyBase64 = Console.ReadLine();

        var keys = new EncryptionKeys(
            localPrivateKeyBase64 ?? "",
            cryptoKeyBase64 ?? "");

        using var rsa = RSA.Create();

        decodeService.DecodePrivateKeyPem(keys.LocalPrivateKeyBase64, rsa);
        
        var aesKey = decryptService.DecryptAesKey(keys.CryptoKeyBase64, rsa);

        using var encryptor = encryptService.CreateAesEncryptor(aesKey);

        var userJsonEncryptor = new UserJsonEncryptor(
            inputReader,
            encryptService);

        userJsonEncryptor.ProcessJsonLoop(encryptor);
    }
}

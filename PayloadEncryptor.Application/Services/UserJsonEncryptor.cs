using PayloadEncryptor.Domain.Interfaces.Application;
using PayloadEncryptor.Domain.Interfaces.Infrastructure.Services;
using PayloadEncryptor.Domain.Utils;
using System.Security.Cryptography;

namespace PayloadEncryptor.Application.Services;

public class UserJsonEncryptor
{
    private readonly IInputReader _inputReader;
    private readonly IEncryptService _encryptService;

    public UserJsonEncryptor(IInputReader inputReader, IEncryptService encryptService)
    {
        _inputReader = inputReader;
        _encryptService = encryptService;
    }
    public void ProcessJsonLoop(ICryptoTransform encryptor)
    {
        while (true)
        {
            ConsolePresentationHelper
                .CenterReadLine(ConsoleMessages.EnterJson);
            string json = _inputReader.ReadJsonFromUser();

            var encryptedPayloadBase64 = _encryptService.EncryptPayload(json, encryptor);

            Console.WriteLine();
            ConsolePresentationHelper
                .CenterReadLine(ConsoleMessages.EncryptedPayload);
            Console.WriteLine(encryptedPayloadBase64);

            if (!SelectOption())
                break;
        }
    }
    private bool SelectOption()
    {
        Console.WriteLine();
        ConsolePresentationHelper.CenterWriteLine(ConsoleMessages.ChooseOption);

        ConsolePresentationHelper.CenterWriteLine(ConsoleMessages.AddNewJson);

        ConsolePresentationHelper.CenterReadLine(ConsoleMessages.Finish);

        var opcao = Console.ReadLine();
        return opcao == "1";
    }
}
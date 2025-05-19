using PayloadEncryptor.Domain.Interfaces.Application;
using PayloadEncryptor.Domain.Interfaces.Factories;
using PayloadEncryptor.Domain.Interfaces.Infrastructure.Services;
using PayloadEncryptor.Domain.Utils;
using System.Security.Cryptography;

namespace PayloadEncryptor.Application.Services;

public class UserJsonEncryptor(
    IInputReader _inputReader, 
    IEncryptService _encryptService,
    IMockJsonFactory _mockJsonFactory)
{
    private string _json = string.Empty;

    public void ProcessJsonLoop(ICryptoTransform encryptor)
    {
        while (true)
        {   
            var jsonOptionSelected = UserPromptHelper.SelectJsonOption();

            if (jsonOptionSelected == "1")
            {                

                var typeSelected = UserPromptHelper.SelectEventType();

                var operationSelected = UserPromptHelper.SelectOperation();

                _json = _mockJsonFactory.Generate(typeSelected, operationSelected);
            }
            else
            {
                ConsolePresentationHelper
               .CenterReadLine(ConsoleMessages.EnterJson);
                _json = _inputReader.ReadJsonFromUser();
            }

            var encryptedPayloadBase64 = _encryptService.EncryptPayload(_json, encryptor);

            Console.WriteLine();
            ConsolePresentationHelper
                .CenterReadLine(ConsoleMessages.EncryptedPayload);
            Console.WriteLine(encryptedPayloadBase64);

            if (!UserPromptHelper.SelectOption())
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
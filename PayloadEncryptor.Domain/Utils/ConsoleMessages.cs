namespace PayloadEncryptor.Domain.Utils;

public static class ConsoleMessages
{
    public const string LocalPrivateKey = "Insira abaixo a sua chave privada local (formato Base64):";
    public const string CryptoKey = "Insira abaixo a chave de sessão criptografada (formato Base64):";
    public const string EnterJson = "Cole abaixo o JSON de entrada. Pressione Enter em uma linha vazia para finalizar:";
    public const string EncryptedPayload = "Payload criptografado (base64):";
    public const string ChooseOption = "Escolha uma opção:";
    public const string AddNewJson = "1 - Adicionar um novo JSON";
    public const string Finish = "2 - Encerrar";
    public const string LocalPrivateKeyNull = "A chave privada local não pode ser nula ou vazia.";
    public const string CryptoKeyNull = "A chave de sessão não pode ser nula ou vazia.";
    public const string UtilityTitle = "Utilitário de Criptografia";
    public const string DescriptionLine1 = "Este programa irá criptografar um JSON usando uma chave AES,";
    public const string DescriptionLine2 = "a partir de uma chave privada local e uma chave de sessão criptografada.";
    public const string Instructions = "Siga as instruções abaixo para fornecer as informações necessárias.";
    public const string Title = @"
                         _____            _                 _ ______                             _             
                        |  __ \          | |               | |  ____|                           | |            
                        | |__) |_ _ _   _| | ___   __ _  __| | |__   _ __   ___ _ __ _   _ _ __ | |_ ___  _ __ 
                        |  ___/ _` | | | | |/ _ \ / _` |/ _` |  __| | '_ \ / __| '__| | | | '_ \| __/ _ \| '__|
                        | |  | (_| | |_| | | (_) | (_| | (_| | |____| | | | (__| |  | |_| | |_) | || (_) | |   
                        |_|   \__,_|\__, |_|\___/ \__,_|\__,_|______|_| |_|\___|_|   \__, | .__/ \__\___/|_|   
                                     __/ |                                            __/ | |                  
                                    |___/                                            |___/|_|                           ";
}

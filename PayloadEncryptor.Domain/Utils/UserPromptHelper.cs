namespace PayloadEncryptor.Domain.Utils
{
    public static class UserPromptHelper
    {
        public static bool SelectOption()
        {
            Console.WriteLine();
            ConsolePresentationHelper.CenterWriteLine(ConsoleMessages.ChooseOption);
            ConsolePresentationHelper.CenterWriteLine(ConsoleMessages.AddNewJson);
            ConsolePresentationHelper.CenterReadLine(ConsoleMessages.Finish);

            var opcao = Console.ReadLine();
            return opcao == "1";
        }

        public static string SelectJsonOption()
        {
            ConsolePresentationHelper.CenterWriteLine(ConsoleMessages.ChooseOption);
            ConsolePresentationHelper.CenterWriteLine(ConsoleMessages.JsonOptionAuto);
            ConsolePresentationHelper.CenterReadLine(ConsoleMessages.JsonOptionManual);

            return Console.ReadLine();
        }

        public static string SelectEventType()
        {
            ConsolePresentationHelper.CenterWriteLine(ConsoleMessages.EventTypePrompt);
            ConsolePresentationHelper.CenterWriteLine(ConsoleMessages.EventTypeAccount);
            ConsolePresentationHelper.CenterReadLine(ConsoleMessages.EventTypeCard);

            return Console.ReadLine();
        }

        public static string SelectOperation()
        {
            ConsolePresentationHelper.CenterWriteLine(ConsoleMessages.OperationPrompt);
            ConsolePresentationHelper.CenterWriteLine(ConsoleMessages.OperationInsert);
            ConsolePresentationHelper.CenterReadLine(ConsoleMessages.OperationUpdate);

            return Console.ReadLine();
        }
    }
}

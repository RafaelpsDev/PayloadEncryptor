namespace PayloadEncryptor.Domain.Utils;
public static class ConsolePresentationHelper
{
    public static void PrintTitle()
    {
        CenterWriteLine(ConsoleMessages.Title);
        Console.WriteLine();
        Console.WriteLine();
        CenterWriteLine(ConsoleMessages.UtilityTitle);
        Console.WriteLine();
        CenterWriteLine(ConsoleMessages.DescriptionLine1);
        CenterWriteLine(ConsoleMessages.DescriptionLine2);
        Console.WriteLine();
        CenterWriteLine(ConsoleMessages.Instructions);
        Console.WriteLine();
        Console.WriteLine();
    }

    public static void CenterWriteLine(string texto)
    {
        int larguraConsole = Console.WindowWidth;
        int espacos = Math.Max(0, (larguraConsole - texto.Length) / 2);
        Console.WriteLine(texto.PadLeft(espacos + texto.Length));
    }

    public static void CenterReadLine(string prompt)
    {
        int larguraConsole = Console.WindowWidth;
        int espacos = Math.Max(0, (larguraConsole - prompt.Length) / 2);
        Console.WriteLine(new string(' ', espacos) + prompt);
        Console.SetCursorPosition(espacos, Console.CursorTop);
    }
}

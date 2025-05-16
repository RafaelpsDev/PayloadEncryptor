using PayloadEncryptor.Domain.Interfaces.Infrastructure.Services;

namespace PayloadEncryptor.Infrastructure.Services;
public class InputReader : IInputReader
{
    public string ReadJsonFromUser()
    {
        var jsonLines = new List<string>();
        string? line;
        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
        {
            jsonLines.Add(line);
        }
        return string.Join(Environment.NewLine, jsonLines);
    }
}

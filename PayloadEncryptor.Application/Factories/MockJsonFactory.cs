using PayloadEncryptor.Domain.Interfaces.Factories;
using PayloadEncryptor.Domain.Models;
using System.Text.Json;

namespace PayloadEncryptor.Application.Factories;
public sealed class MockJsonFactory : IMockJsonFactory
{
    public string Generate(string type, string operation)
    {
        if (type.Equals("card", StringComparison.OrdinalIgnoreCase))
        {
            var card = new Card();
            card = card.MockCard(operation);

            return JsonSerializer.Serialize(card, new JsonSerializerOptions { WriteIndented = true });
        }

        else if (type.Equals("account", StringComparison.OrdinalIgnoreCase))
        {
            var account = new Account();

            return JsonSerializer.Serialize(
                account.MockAccount(operation),
                options: new JsonSerializerOptions { WriteIndented = true });
        }
        else
        {
            throw new ArgumentException("Tipo inválido. Use 'card' ou 'account'.");
        }
    }
}

using PayloadEncryptor.Domain.Extensions;
using System.Text.Json.Serialization;

namespace PayloadEncryptor.Domain.Models;

public struct EventProperties
{
    [JsonPropertyName("cmd_seq")]
    public int? CommandSequence { get; private set; }

    [JsonPropertyName("dt_capture")]
    public string CaptureDate { get; private set; }

    [JsonPropertyName("dt_publish")]
    public string PublishDate { get; private set; }

    [JsonPropertyName("dt_transaction")]
    public string TransactionDate { get; private set; }

    [JsonPropertyName("issuer_id")]
    public int? IssuerId { get; private set; }

    [JsonPropertyName("issuer_name")]
    public string IssuerName { get; private set; }

    [JsonPropertyName("operation")]
    public string Operation { get; private set; }

    public EventProperties MockEventProperties(string operation)
    {
        return new EventProperties
        {
            CommandSequence = Random.Shared.Next(0, 100),
            CaptureDate = CaptureDate.GenerateDateWithYearOffset(-4),
            PublishDate = PublishDate.GenerateDateWithYearOffset(-4),
            TransactionDate = TransactionDate.GenerateDateWithYearOffset(-4),
            IssuerId = Random.Shared.Next(0, 100),
            IssuerName = "Issuer",
            Operation = operation
        };
    }
}

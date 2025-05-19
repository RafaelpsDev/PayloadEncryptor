using PayloadEncryptor.Domain.Extensions;
using System.Text.Json.Serialization;

namespace PayloadEncryptor.Domain.Models;

public record Card
{
    [JsonPropertyName("card_id")]
    public long? CardId { get; private set; }

    [JsonPropertyName("account_id")]
    public long? AccountId { get; private set; }

    [JsonPropertyName("person_id")]
    public long? PersonId { get; private set; }

    [JsonPropertyName("pan")]
    public string Pan { get; private set; }

    [JsonPropertyName("bin")]
    public long? Bin { get; private set; }

    [JsonPropertyName("name_on_card")]
    public string NameOnCard { get; private set; }

    [JsonPropertyName("status_id")]
    public int? StatusId { get; private set; }

    [JsonPropertyName("status_description")]
    public string StatusDescription { get; private set; }

    [JsonPropertyName("status_allow_approve")]
    public bool StatusAllowApprove { get; private set; }

    [JsonPropertyName("expiration_date")]
    public string ExpirationDate { get; private set; }

    [JsonPropertyName("issue_date")]
    public string IssueDate { get; private set; }

    [JsonPropertyName("status_upd_date")]
    public string StatusUpdDate { get; private set; }

    [JsonPropertyName("stage_id")]
    public int? StageId { get; private set; }

    [JsonPropertyName("stage_description")]
    public string StageDescription { get; private set; }

    [JsonPropertyName("embossing_date")]
    public string EmbossingDate { get; private set; }

    [JsonPropertyName("embossing_file")]
    public string EmbossingFile { get; private set; }

    [JsonPropertyName("owner")]
    public string Owner { get; private set; }

    [JsonPropertyName("is_temporary_card")]
    public bool IsTemporaryCard { get; private set; }

    [JsonPropertyName("card_sequence_number")]
    public long? CardSequenceNumber { get; private set; }

    [JsonPropertyName("card_hash")]
    public string CardHash { get; private set; }

    [JsonPropertyName("brand")]
    public string Brand { get; private set; }

    [JsonPropertyName("incorrect_password_attempts")]
    public int? IncorrectPasswordAttempts { get; private set; }

    [JsonPropertyName("properties")]
    public EventProperties Properties { get; private set; }

    public Card MockCard(string operation)
    {
        return new Card
        {
            CardId = Random.Shared.Next(0, 100),
            AccountId = Random.Shared.Next(0, 100),
            PersonId = Random.Shared.Next(0, 100),
            Pan = GenerateRandomPan(),
            Bin = Random.Shared.Next(0, 1000000),
            NameOnCard = "John Doe",
            StatusId = Random.Shared.Next(0, 100),
            StatusDescription = "Active",
            StatusAllowApprove = true,
            ExpirationDate = ExpirationDate.GenerateDateWithYearOffset(4),
            IssueDate = IssueDate.GenerateDateTimeNow(),
            StatusUpdDate = StatusUpdDate.GenerateDateTimeNow(),
            StageId = Random.Shared.Next(0, 100),
            StageDescription = "Stage Description",
            EmbossingDate = EmbossingDate.GenerateDateTimeNow(),
            EmbossingFile = "Embossing File",
            Owner = "Owner",
            IsTemporaryCard = false,
            CardSequenceNumber = Random.Shared.Next(0, 100),
            CardHash = GenerateRandomNumericString(),
            Brand = "Brand",
            IncorrectPasswordAttempts = 0,
            Properties = new EventProperties().MockEventProperties(operation)
        };
    }

    private string GenerateRandomPan()
    {
        return $"{Random.Shared.Next(1000, 10000)}******{Random.Shared.Next(1000, 10000)}";
    }

    private string GenerateRandomNumericString(int length = 19)
    {
        var chars = new char[length];
        for (int i = 0; i < length; i++)
            chars[i] = (char)('0' + Random.Shared.Next(0, 10));
        return new string(chars);
    }
}

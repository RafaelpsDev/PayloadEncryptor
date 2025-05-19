using PayloadEncryptor.Domain.Extensions;
using System.Text.Json.Serialization;

namespace PayloadEncryptor.Domain.Models;

public struct Account
{
    [JsonPropertyName("account_id")]
    public long? AccountId { get; private set; }

    [JsonPropertyName("person_id")]
    public long? PersonId { get; private set; }

    [JsonPropertyName("status_id")]
    public int? StatusId { get; private set; }

    [JsonPropertyName("status_description")]
    public string StatusDescription { get; private set; }

    [JsonPropertyName("create_date")]
    public string CreateDate { get; private set; }

    [JsonPropertyName("due_day")]
    public int? DueDay { get; private set; }

    [JsonPropertyName("delivery_address")]
    public string DeliveryAddress { get; private set; }

    [JsonPropertyName("next_due_date")]
    public string NextDueDate { get; private set; }

    [JsonPropertyName("next_real_due_date")]
    public string NextRealDueDate { get; private set; }

    [JsonPropertyName("charge_date")]
    public string ChargeDate { get; private set; }

    [JsonPropertyName("properties")]
    public EventProperties Properties { get; private set; }

    [JsonPropertyName("product")]
    public Product Product { get; private set; }

    public Account MockAccount(string operation)
    {
        return new Account
        {
            AccountId = Random.Shared.Next(0, 100),
            PersonId = Random.Shared.Next(0, 100),
            StatusId = Random.Shared.Next(0, 100),
            StatusDescription = "Active",
            CreateDate = CreateDate.GenerateDateTimeNow(),
            DueDay = Random.Shared.Next(1, 28),
            DeliveryAddress = "123 Main St",
            NextDueDate = NextDueDate.GenerateDateWithDaysOffset(30),
            NextRealDueDate = NextDueDate.GenerateDateWithDaysOffset(30),
            ChargeDate = CreateDate.GenerateDateTimeNow(),
            Properties = new EventProperties().MockEventProperties(operation),
            Product = new Product().MockProduct()
        };
    }
}

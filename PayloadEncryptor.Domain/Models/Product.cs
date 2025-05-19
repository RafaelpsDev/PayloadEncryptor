using System.Text.Json.Serialization;

namespace PayloadEncryptor.Domain.Models;

public struct Product
{
    [JsonPropertyName("product_id")]
    public int? Product_id { get; private set; }

    [JsonPropertyName("produto_description")]
    public string ProductDescription { get; private set; }

    [JsonPropertyName("product_type")]
    public string ProductType { get; private set; }

    [JsonPropertyName("issuer_bank_number")]
    public int? IssuerBankNumber { get; private set; }

    [JsonPropertyName("issuer_branch_number")]
    public string IssuerBranchNumber { get; private set; }

    [JsonPropertyName("issuer_account_number")]
    public string IssuerAccountNumber { get; private set; }

    public Product MockProduct()
    {
        return new Product
        {
            Product_id = Random.Shared.Next(0, 100),
            ProductDescription = "Product Description",
            ProductType = "Product Type",
            IssuerBankNumber = Random.Shared.Next(0, 1000000),
            IssuerBranchNumber = "1234",
            IssuerAccountNumber = "5678"
        };
    }
}

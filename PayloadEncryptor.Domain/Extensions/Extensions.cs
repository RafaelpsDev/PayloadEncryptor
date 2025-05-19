namespace PayloadEncryptor.Domain.Extensions;

public static class Extensions
{
    public static string GenerateDateWithYearOffset(this string date, int year)
    {
        return DateTime.UtcNow.AddYears(year).ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
    }

    public static string GenerateDateWithDaysOffset(this string date, int days)
    {
        return DateTime.UtcNow.AddDays(days).ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
    }

    public static string GenerateDateTimeNow(this string date)
    {
        return DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
    }
}
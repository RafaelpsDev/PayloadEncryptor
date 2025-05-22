namespace PayloadEncryptor.Domain.Extensions;

public static class Extensions
{
    public static string GenerateDateWithYearOffset(this string date, int year)
    {
        var offset = TimeSpan.FromHours(-3);
        var dateGenerated = new DateTimeOffset(DateTime.Now.AddYears(year).Date, offset);
        return dateGenerated.ToString("yyyy-MM-ddTHH:mm:sszzz");
    }

    public static string GenerateDateWithDaysOffset(this string date, int days)
    {
        var offset = TimeSpan.FromHours(-3);
        var dateGenerated = new DateTimeOffset(DateTime.Now.AddDays(days).Date, offset);
        return dateGenerated.ToString("yyyy-MM-ddTHH:mm:sszzz");
    }

    public static string GenerateDateTimeNow(this string date)
    {
        var offset = TimeSpan.FromHours(-3);
        var dateGenerated = new DateTimeOffset(DateTime.Now.Date, offset);
        return dateGenerated.ToString("yyyy-MM-ddTHH:mm:sszzz");
    }
}
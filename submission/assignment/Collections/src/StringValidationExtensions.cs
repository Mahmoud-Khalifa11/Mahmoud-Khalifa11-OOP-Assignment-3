using System.Text.RegularExpressions;

namespace Collections;

public static class StringValidationExtensions
{
    private static readonly Regex PhonePattern = new(@"^(?:\+20|0)1[0125][0-9]{8}\z");
    private static readonly Regex NationalIdPattern = new(@"^[23][0-9]{13}\z");

    public static bool IsValidEgyptianPhone(this string? value) =>
        !string.IsNullOrWhiteSpace(value) && PhonePattern.IsMatch(value);

    public static bool IsValidEgyptianNationalId(this string? value) =>
        !string.IsNullOrWhiteSpace(value) && NationalIdPattern.IsMatch(value);
}
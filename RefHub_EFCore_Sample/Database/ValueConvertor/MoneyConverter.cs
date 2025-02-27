using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RefHub_EFCore_Sample.Database.Model;

public class MoneyConverter : ValueConverter<Money, string>
{
    public MoneyConverter()
        : base(
            v => v.ToString(), // تبدیل Money به string برای ذخیره در پایگاه داده
            v => ConvertFromString(v) // تبدیل string به Money هنگام بازیابی از پایگاه داده
        )
    {
    }

    private static Money ConvertFromString(string value)
    {
        var parts = value.Split(' ');
        if (parts.Length == 2 && decimal.TryParse(parts[0], out var amount))
        {
            return new Money(amount, parts[1]);
        }
        throw new ArgumentException("Invalid Money format.");
    }
}
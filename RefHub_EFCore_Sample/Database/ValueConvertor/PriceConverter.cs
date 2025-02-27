namespace RefHub_EFCore_Sample.Database.ValueConvertor
{
    using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

    public class PriceConverter : ValueConverter<decimal, decimal>
    {
        public PriceConverter()
            : base(
                v => v * 10, // تبدیل تومان به ریال (برای ذخیره در پایگاه داده)
                v => v / 10  // تبدیل ریال به تومان (برای بازیابی از پایگاه داده)
            )
        {
        }
    }
}

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.ValueConvertor
{
    public class OrderStatusConverter : ValueConverter<OrderStatus, string>
    {
        public OrderStatusConverter()
            : base(
                v => v.ToString().ToUpper(), // تبدیل Enum به string (حروف بزرگ)
                v => (OrderStatus)Enum.Parse(typeof(OrderStatus), v, true) // تبدیل string به Enum
            )
        {
        }
    }
}

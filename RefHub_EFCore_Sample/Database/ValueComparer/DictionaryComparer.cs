namespace RefHub_EFCore_Sample.Database.Com
{
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using System.Collections.Generic;
    using System.Linq;

    public class DictionaryComparer : ValueComparer<Dictionary<string, string>>
    {
        public DictionaryComparer()
            : base(
                (d1, d2) => d1.SequenceEqual(d2), // مقایسه دو دیکشنری
                d => d.Aggregate(0, (a, v) => HashCode.Combine(a, v.Key.GetHashCode(), v.Value.GetHashCode())), // محاسبه هش کد
                d => d.ToDictionary(kvp => kvp.Key, kvp => kvp.Value) // ایجاد یک کپی از دیکشنری
            )
        {
        }
    }
}

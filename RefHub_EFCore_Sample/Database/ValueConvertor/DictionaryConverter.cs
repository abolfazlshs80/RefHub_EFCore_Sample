namespace RefHub_EFCore_Sample.Database.ValueConvertor
{
    using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
    using System.Text.Json;

    public class DictionaryConverter : ValueConverter<Dictionary<string, string>, string>
    {
        public DictionaryConverter()
            : base(
                v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default), // تبدیل دیکشنری به JSON
                v => JsonSerializer.Deserialize<Dictionary<string, string>>(v, JsonSerializerOptions.Default) // تبدیل JSON به دیکشنری
            )
        {
        }
    }
}

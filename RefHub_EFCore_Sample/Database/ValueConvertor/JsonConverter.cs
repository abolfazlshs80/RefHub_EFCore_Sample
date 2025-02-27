namespace RefHub_EFCore_Sample.Database.ValueConvertor
{
    using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
    using System.Text.Json;

    public class JsonConverter<T> : ValueConverter<T, string>
    {
        public JsonConverter()
            : base(
                v => JsonSerializer.Serialize(v,JsonSerializerOptions.Default), // تبدیل به JSON
                v => JsonSerializer.Deserialize<T>(v, JsonSerializerOptions.Default) // تبدیل از JSON
            )
        {
        }
    }
}

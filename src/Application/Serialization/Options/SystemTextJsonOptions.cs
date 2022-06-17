using System.Text.Json;
using WarehouseManger.Application.Interfaces.Serialization.Options;

namespace WarehouseManger.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}

using WarehouseManger.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace WarehouseManger.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}
using System.Linq;
using WarehouseManger.Shared.Constants.Localization;
using WarehouseManger.Shared.Settings;

namespace WarehouseManger.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}
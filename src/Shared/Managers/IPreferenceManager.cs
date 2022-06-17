using WarehouseManger.Shared.Settings;
using System.Threading.Tasks;
using WarehouseManger.Shared.Wrapper;

namespace WarehouseManger.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}
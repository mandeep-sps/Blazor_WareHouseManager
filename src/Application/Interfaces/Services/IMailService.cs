using WarehouseManger.Application.Requests.Mail;
using System.Threading.Tasks;

namespace WarehouseManger.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}
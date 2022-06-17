using WarehouseManger.Application.Interfaces.Services;
using System;

namespace WarehouseManger.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
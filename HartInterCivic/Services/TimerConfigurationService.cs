using HartInterCivic.Data;
using HartInterCivic.DTOs;
using HartInterCivic.Interfaces;
using HartInterCivic.Models;

namespace HartInterCivic.Services
{
    public class TimerConfigurationService : ITimerConfigurationService
    {
        private readonly HartInterCivicDbContext _hartInterCivicDbContext;
        public TimerConfigurationService(HartInterCivicDbContext hartInterCivicDbContext)
        {
            _hartInterCivicDbContext = hartInterCivicDbContext;
        }
        public TimerConfigurationDTO GetLatestTimerConfiguration()
        {
            var timerConfiguration = _hartInterCivicDbContext.TimerConfigurations.FirstOrDefault()!;
            return new TimerConfigurationDTO(timerConfiguration);
        }
    }
}

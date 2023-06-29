using HartInterCivic.DTOs;
using HartInterCivic.Models;

namespace HartInterCivic.Interfaces
{
    public interface ITimerConfigurationService
    {
        public TimerConfigurationDTO GetLatestTimerConfiguration();
    }
}

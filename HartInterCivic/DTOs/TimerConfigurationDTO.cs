using HartInterCivic.Models;

namespace HartInterCivic.DTOs
{
    public class TimerConfigurationDTO
    {
        public TimerConfigurationDTO(TimerConfiguration timerConfiguration) 
        {
            Interval= timerConfiguration.Interval;
            AutoStart= timerConfiguration.AutoStart;
        }
        public int Interval { get; set; }
        public bool AutoStart { get; set; }
    }
}

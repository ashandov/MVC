using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllerOverrides.Services
{
    public interface ITimeService
    {
         string Time { get;}
    }
    public class TimeService : ITimeService
    {
        public TimeService()
        {
            Time = DateTime.Now.ToString("hh::mm:ss");
        }
        public string Time { get; }
    }
}

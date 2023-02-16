using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guardian.Jobs
{
    public class RegistroDeJobs : Registry
    {
        public RegistroDeJobs()
        {
            Schedule<Job>()
     .NonReentrant()
     .ToRunOnceAt(DateTime.Now.AddSeconds(5))
     .AndEvery(3600).Seconds();
        }
    }
}

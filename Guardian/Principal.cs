using FluentScheduler;
using Guardian.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guardian
{
    public class Principal
    {
        public static void Startar()
        {
            JobManager.Initialize(new RegistroDeJobs());
        }
    }
}

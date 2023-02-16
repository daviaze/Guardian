using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Guardian.Service
{
    internal class ConfiguraServico
    {

        public static void Configure()
        {
            HostFactory.Run(configure =>
            {
            configure.Service<Servico>(service =>
            {
                service.ConstructUsing(s => new Servico());
                service.WhenStarted(s => s.Start());
                service.WhenStopped(s => s.Stop());
            });
                //Configure a Conta que o serviço do Windows usa para rodar
                string[] config = File.ReadAllLines(System.AppDomain.CurrentDomain.BaseDirectory.ToString()+ @"\configService.txt");
                configure.RunAsLocalSystem();
                configure.SetServiceName(config[1]);
                configure.SetDisplayName(config[1]);
                configure.SetDescription("Serviço de monitoramento de aplicações, este serviço não pode ser parado.");
            });
        }
    }
}

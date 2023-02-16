using FluentScheduler;
using System.Diagnostics;

namespace Guardian.Jobs
{
    public class Job : IJob
    {
        public void Execute()
        {
            Console.WriteLine("São {0:HH:mm:ss} horas", DateTime.Now);
            try
            {
            string[] config = File.ReadAllLines(System.AppDomain.CurrentDomain.BaseDirectory.ToString()+ @"\configService.txt");

            var nameProcesses = config[0].Split(@"\").Last().Replace(".exe", "");
            var fileProcesses = config[0].Split(@"\").Last();
            var directoryProcesses = config[0].Split(@"\").Last();

            var directory = config[0].Replace(directoryProcesses, "");

                Process[] processes = Process.GetProcessesByName(nameProcesses);

                if (processes.Length == 0)
                {
                    var startInfo = new ProcessStartInfo(fileProcesses);
                    startInfo.UseShellExecute = true;
                    startInfo.CreateNoWindow = true;
                    //startInfo.Verb = "runas";
                    //startInfo.WindowStyle = ProcessWindowStyle.Normal;
                    startInfo.WorkingDirectory = directory;
                    Process proc = Process.Start(startInfo);
                    proc.WaitForExit();
                    proc.Close();
                }
            }
            catch(Exception e)
            {
                File.WriteAllText("log.txt", e.Message);
            }
        }
    }
}

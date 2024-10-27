using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class CheckDirectory
    {
        //public event EventHandler<FileFoundEventArgs> FileFound;
        public event EventHandler<FileArgs> FileFound;

        public CheckDirectory()
        {
            FileFound += HandleFileFound;
        }

        public void FindFiles(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException($"Несуществующий каталог: {path}");
            }

            foreach (var file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
            {
                //OnFileFound(new FileFoundEventArgs(file));
                var args = new FileArgs(file);
                OnFileFound(args);
                if (args.CheckStop)
                {
                    Console.WriteLine("Проверка каталога остановлена!");
                    break;
                }
            }
        }

        public void OnFileFound(FileArgs e)
        {
            FileFound?.Invoke(this, e);
        }

        private void HandleFileFound(object sender, FileArgs e)
        {
            Console.WriteLine($"Найден файл: {e.FileName}");
            Console.WriteLine("Для остановки проверки каталога введите stop и нажмите ENTER");            
            if(Console.ReadLine() == "stop")
               e.CheckStop = true;
        }
    }
}

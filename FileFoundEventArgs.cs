using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class FileFoundEventArgs : EventArgs
    {
        public string FilePath;

        public FileFoundEventArgs(string filePath)
        {
            this.FilePath = filePath;
        }
    }
}

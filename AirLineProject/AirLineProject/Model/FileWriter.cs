using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AirLineProject.Model
{
    public class FileWriter
    {
        public FileWriter()
        {
        }

        public void Print(string Message, string filename)
        {
            FileStream filestream;
            filestream = new FileStream(filename, FileMode.Append, FileAccess.Write);
            StreamWriter fileWrite;
            fileWrite = new StreamWriter(filestream);
            fileWrite.Write(Message);
            fileWrite.Close();
            filestream.Close();       
        }
    }
}

    


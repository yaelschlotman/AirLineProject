using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AirLineProject.Model
{
    class FileWriter
    {
        public FileWriter()
        {
        }

        public void Print(string Message, string filename)
        {
            string file_name = filename;
            StreamWriter fileWrite;
            fileWrite = new StreamWriter(file_name);
            fileWrite.Write(Message);
            fileWrite.Close();           
        }
    }
}

    


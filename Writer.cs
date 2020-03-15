using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903MW9
{
    class Writer
    {
        StreamWriter sw;

        //constructor
        public Writer(string path)
        {
            sw = File.CreateText(path);
        }

        public void write(string text)
        {
            sw.WriteLine(text);
        }

        public void flush()
        {
            sw.Flush();

        }

        public void close()
        {
            sw.Close();
        }

    }
}

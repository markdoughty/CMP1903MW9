using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MW9
{
    public delegate void delegateWriter(string message);

    class Program
    {
            
        static void Main(string[] args)
        {
            //File is created here in the same dir as the exe
            //Changethe path for somewhere else
            Writer writer = new Writer("log.txt");
            

        }
    }
}

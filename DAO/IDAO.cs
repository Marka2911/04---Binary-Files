using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Binary_Files.DAO
{
    public interface IDAO
    {
        void WriteData(string name, string nif);
        string ReadNIF();
        string ReadName();

        bool IsFeasible(string name, string nif);
        void Dispose();

        bool Empty {  get; }
        int LenghtOfName { get; }
        int MaxLenghtOfName { get; }

        string NIF { get; set; }
        string nom { get; set; }
    }
}

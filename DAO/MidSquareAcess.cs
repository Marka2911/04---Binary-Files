using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace _04___Binary_Files.DAO
{
    public class MidSquareAcess : IDAOFactory, IDAO
    {
        const int POS_NOM = 10000;
        private FileStream fs = null;
        private BinaryReader bR = null;
        private BinaryWriter bW = null;
        private string name;
        private string nif;
        private string seed;
        
        List<int> posicionsValides = new List<int>();

        public MidSquareAcess(string seed, bool overWrite)
        {
            this.seed = seed;
            string nomFitxer = $"{seed}.bin";
            if (overWrite == false)
            {
                fs = new FileStream(nomFitxer, FileMode.Open);
                bR = new BinaryReader(fs);
            }
            else
            {
                fs = new FileStream(nomFitxer, FileMode.Create);
                bR = new BinaryReader(fs);
                bW = new BinaryWriter(fs);
            }

            posicionsValides = SequenciaDePosicion(seed);
        }


        public bool Empty
        {
            get
            {
                bool empty = false;
                if (fs.Position == 0 || fs.Length < POS_NOM)
                    empty = true;
                return empty;
            }
        }

        public int LenghtOfName 
        { get
            {
                int lenght = 0;
                if (!Empty) 
                {
                    fs.Seek(POS_NOM, SeekOrigin.Begin);
                    lenght = bR.ReadByte();
                }
                return lenght;
            } 
        }
        public void Dispose()
        {
            if (bR != null)
                bR.Close();
            if(bW != null)
                bW.Close();
            if (fs != null)
                fs.Close();
        }
        public int MaxLenghtOfName => posicionsValides.Count - nif.Length;

        public string NIF { get => nif; set => nif = value; }
        public string nom { get => nom; set => nom = value; }

        private int NextPosition(string n)
        {
            int nombre = Convert.ToInt32(n);
            int squared = nombre * nombre;

            string squaredStr = squared.ToString("D8");
            string middleDigits = squaredStr.Substring(2, 4);
            return Convert.ToInt32(middleDigits);

        }

        private List<int> SequenciaDePosicion(String seed)
        {
            int llavor = Convert.ToInt32(seed);

            while (posicionsValides.Count < POS_NOM) 
            {
                int val = NextPosition(llavor.ToString("D4"));
                posicionsValides.Add(val);
                llavor = val;
            }
            posicionsValides = posicionsValides.Distinct().ToList();
            return posicionsValides;

        }
        public string ReadName()
        {

            int nameLength = ReadLengthOfName();
            char[] nameChars = new char[nameLength];
            for (int i = 0; i < nameLength; i++)
            {
                fs.Seek(posicionsValides[i], SeekOrigin.Begin);
                nameChars[i] = bR.ReadChar();
            }
            string enjavao = new string(nameChars); // Convert char[] to string
            return enjavao;
        }

        public string ReadNIF()
        {
            string enjavao = "";
            if (LenghtOfName != 0)
            {
                char[] nifChars = new char[9];
                for (int i = 0; i < 9; i++)
                {
                    fs.Seek(posicionsValides[LenghtOfName + i], SeekOrigin.Begin);
                    nifChars[i] = bR.ReadChar();
                }
                enjavao = new string(nifChars); // Convert char[] to string
                
            }
            return enjavao;
        }

        private int ReadLengthOfName()
        {
            int lengt = 0;
            try
            {

                fs.Seek(POS_NOM, SeekOrigin.Begin);
                lengt = bR.ReadInt32();
            }
            catch (Exception)
            {

                MessageBox.Show("No pots fer res si el arxiu es null", "Error");
            }
            return lengt;
        }
        public void WriteData(string name, string nif)
        {
            if (IsFeasible(name, nif))
            {
                fs.Seek(POS_NOM, SeekOrigin.Begin);
                bW.Write(name.Length);

                for (int i = 0; i < name.Length; i++)
                {
                    fs.Seek(posicionsValides[i], SeekOrigin.Begin);
                    bW.Write(name[i]);
                }

                for (int j = 0; j < nif.Length; j++)
                {
                    fs.Seek(posicionsValides[name.Length + j], SeekOrigin.Begin);
                    bW.Write(nif[j]);
                }
            }
        }
        public bool IsFeasible(string name, string nif)
        {
            return posicionsValides.Count >= (name.Length + nif.Length);
        }
    }
}

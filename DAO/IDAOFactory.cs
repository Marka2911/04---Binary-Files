using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Binary_Files.DAO
{
    public class IDAOFactory
    {
        public IDAO DAOFactory(string seed, bool overWrite)
        {
            IDAO dao = new MidSquareAcess(seed, overWrite);

            return dao;
        }
    }
}

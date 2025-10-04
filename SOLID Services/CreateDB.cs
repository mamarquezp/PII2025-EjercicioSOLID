using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.SOLID_Services
{
    internal class CreateDB
    {
        public void Create(string Directory)
        {
            System.IO.Directory.CreateDirectory(Directory);
        }
    }
}

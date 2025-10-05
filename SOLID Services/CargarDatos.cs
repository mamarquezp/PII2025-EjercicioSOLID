using PII2025_EjercicioSOLID.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.SOLID_Services
{
    internal class CargarDatos
    {
        public void Seed()
        {
            Courses cs = new Courses();
            cs.AddCourses("C1","C# Básico",800m);
            cs.AddCourses("C2", "C# Avanzado", 1200m);
        }
    }
}

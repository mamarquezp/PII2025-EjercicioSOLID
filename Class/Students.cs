using PII2025_EjercicioSOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Class
{
    internal class Students : Student
    {
        public void RegisterStudent(string name, string email, string phone)
        {
            var s = new Student { Id = Guid.NewGuid().ToString("N"), Name = name, Email = email, Phone = phone };
            LstStudents.Add(s);
            Console.WriteLine($"Registrado: {s.Name} ({s.Id})");
        }
    }
}

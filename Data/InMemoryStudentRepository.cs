using PII2025_EjercicioSOLID.Class;
using PII2025_EjercicioSOLID.Interfaces;
using PII2025_EjercicioSOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Data
{
    public class InMemoryStudentRepository : IStudentRepository
    {
        private readonly List<Student> LstStudents = new List<Student>();
        private int siguienteCorrelativo = 1;
        public Student GetById(string studentId)
        {
            return LstStudents.FirstOrDefault(s => s.Id == studentId);
        }
        public void Save(Student student)
        {
            student.Id = siguienteCorrelativo.ToString();
            siguienteCorrelativo++;
            LstStudents.Add(student);
            Console.WriteLine($"Estudiante registrado: {student.Name} ({student.Id})");
        }
    }
}

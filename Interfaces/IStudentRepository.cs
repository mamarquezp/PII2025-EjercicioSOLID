using PII2025_EjercicioSOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Interfaces
{
    public interface IStudentRepository
    {
        Student GetByID(string studentId);
        void Save(Student student);
    }
}


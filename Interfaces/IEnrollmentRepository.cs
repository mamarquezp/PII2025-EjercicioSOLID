using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Interfaces
{
    public interface IEnrollmentRepository
    {
        void Save(string id, string studentId, string courseId, decimal finalPrice);
        IEnumerable<string> GetAll();
    }
}

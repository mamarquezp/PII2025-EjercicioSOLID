using PII2025_EjercicioSOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Interfaces
{
    public interface ICourseRepository
    {
        Course GetById(string courseId);
        IEnumerable<Course> GetAll();
    }
}

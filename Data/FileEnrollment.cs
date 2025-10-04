using PII2025_EjercicioSOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Data
{
    internal class FileEnrollment
    {
        public static List<Student> Students = new List<Student>();
        public static List<Course> Courses = new List<Course>();
        public static List<(string id, string studentId, string courseId, decimal price, bool paid)> Enrollments = new();

    }
}

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
    public class InMemoryCouseRepository : ICourseRepository
    {
        private readonly List<Course> LstCourses = new List<Course>();
        public IEnumerable<Course> GetAll() => LstCourses;
        public Course GetById(string courseId) => LstCourses.FirstOrDefault(c => c.Id == courseId);

        public void Seed()
        {
            LstCourses.Add(new Course { Id = "P1", Name = "Progra I", BasePrice = 800m });
            LstCourses.Add(new Course { Id = "P2", Name = "Progra II", BasePrice = 1200m });
        }
    }
}

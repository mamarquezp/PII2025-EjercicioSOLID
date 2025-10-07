using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PII2025_EjercicioSOLID.Interfaces;

namespace PII2025_EjercicioSOLID.Data
{
    public class FileEnrollmentRepository : IEnrollmentRepository
    {
        private readonly string _filePath;
        public FileEnrollmentRepository(string directory)
        {
            Directory.CreateDirectory(directory);
            _filePath = Path.Combine(directory, "enrollments.csv");
        }

        public IEnumerable<string> GetAll()
        {
            return File.Exists(_filePath) ? File.ReadAllLines(_filePath) : new string[0];
        }

        public void Save(string id, string studentId, string courseId, decimal finalPrice)
        {
            var line = $"{id};{studentId};{courseId};{finalPrice:F2}";
            File.AppendAllLines(_filePath, new[] { line });
        }
    }
     }
}

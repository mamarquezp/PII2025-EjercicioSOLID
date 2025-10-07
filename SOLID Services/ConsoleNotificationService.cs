using PII2025_EjercicioSOLID.Interfaces;
using PII2025_EjercicioSOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.SOLID_Services
{
    public class ConsoleNotificationService : INotificationService
    {
        public void SendEnrollmentConfirmation(Student student, Course course, decimal finalPrice)
        {
            Console.WriteLine($"Email para:{student.Email}; Asunto:Inscripción Confirmada; Cuerpo:Curso {course.Name} por {finalPrice:C}");
            Console.WriteLine($"SMS para:{student.Phone}; Mensaje:Pago OK por {finalPrice:C}");
        }
    }
}

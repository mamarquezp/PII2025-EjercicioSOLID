using PII2025_EjercicioSOLID.Models;
using PII2025_EjercicioSOLID.SOLID_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Class
{
    //internal class Enrollments 
    //{
    //    public void EnrollAndPay(string? studentId, string? courseId, string? promo, string? paymentType)
    //    {
    //        try
    //        {
    //            if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(courseId))
    //            {
    //                Console.WriteLine("Datos inválidos.");
    //                return;
    //            }
    //            var s = LstStudents.FirstOrDefault(x => x.Id == studentId);
    //            var c = Courses.FirstOrDefault(x => x.Id == courseId);
    //            if (s == null || c == null) { Console.WriteLine("No encontrado."); return; }

    //            decimal finalPrice = c.BasePrice;
    //            if (promo == "standard") finalPrice = c.BasePrice;
    //            else if (promo == "blackfriday") finalPrice = c.BasePrice * 0.7m;
    //            else if (promo == "vip") finalPrice = c.BasePrice * 0.85m;
    //            else if (promo == "alumni") finalPrice = c.BasePrice * 0.95m;
    //            else if (!string.IsNullOrWhiteSpace(promo))
    //            {
    //                Console.WriteLine("Promo desconocida, se ignora.");
    //            }


    //            PaymentBase payment;
    //            if (paymentType == "card") payment = new CardPayment();
    //            else if (paymentType == "cash") payment = new CashPayment();
    //            else if (paymentType == "transfer") payment = new TransferPayment();
    //            else if (paymentType == "crypto") payment = new CryptoPayment();
    //            else payment = new CashPayment();

    //            var ok = payment.Pay(finalPrice);
    //            if (!ok) { Console.WriteLine("Pago rechazado"); return; }


    //            var id = Guid.NewGuid().ToString("N");
    //            Enrollments.Add((id, s.Id, c.Id, finalPrice, true));
    //            SaveEnrollment.Save(id, s.Id, c.Id, finalPrice);

    //            SendEmail.SendNotification(s.Email, "Inscripción confirmada", $"Curso: {c.Name} — Monto: {finalPrice:C}");
    //            SendSms.SendNotification(s.Phone, $"Pago OK por {finalPrice:C}");

    //            try { SendPush.SendNotification("console-device","Notificación push innecesaria"); } catch { }

    //            Console.WriteLine("Operación completada.");
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Ocurrió un error pero se continuó: " + ex.Message);
    //        }
    //    }

    //    public void ListEnrollments()
    //    {
    //        foreach (var e in LstEnrollments)
    //            Console.WriteLine($"{e.id} - S:{e.studentId} C:{e.courseId} Precio:{e.price:C} Pagado:{e.paid}");
    //    }
    //}
}

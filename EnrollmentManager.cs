using PII2025_EjercicioSOLID.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID
{
	public class EnrollmentManager

	{
            private readonly IStudentRepository studentRepo;
            private readonly ICourseRepository courseRepo;
            private readonly IPaymentProcessor paymentProcessor;
            private readonly INotificationService notifier;

            public EnrollmentManager(IStudentRepository sr, ICourseRepository cr, IPaymentProcessor pp, INotificationService n)
            {
                studentRepo = sr;
                courseRepo = cr;
                paymentProcessor = pp;
                notifier = n;
            }

            public void EnrollStudent(...)
            {
                var student = studentRepo.GetById(...);
                paymentProcessor.ProcessPayment(...);
                notifier.SendConfirmation(...);
            }
        }

        //public static List<Student> Students = new List<Student>();
        //public static List<Course> Courses = new List<Course>();
        //public static List<(string id, string studentId, string courseId, decimal price, bool paid)> Enrollments = new();

        //private ConsoleNotifier _notifier = new ConsoleNotifier();
        //private FileRepository _repo = new FileRepository();

        //public void Seed()
        //{
        //	Courses = new List<Course> {
        //		new Course{Id="C1",Name="C# Básico", BasePrice=800m},
        //		new Course{Id="C2",Name="C# Avanzado", BasePrice=1200m},
        //	};
        //}

        //public void ListCourses()
        //{
        //	foreach (var c in LstCourses)
        //		Console.WriteLine($"{c.Id} - {c.Name} - {c.BasePrice:C}");
        //}

        //public void RegisterStudent(string name, string email, string phone)
        //{
        //	var s = new Student { Id = Guid.NewGuid().ToString("N"), Name = name, Email = email, Phone = phone };
        //	Students.Add(s);
        //	Console.WriteLine($"Registrado: {s.Name} ({s.Id})");
        //}

        //public void EnrollAndPay(string? studentId, string? courseId, string? promo, string? paymentType)
        //{
        //	try
        //	{
        //		if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(courseId))
        //		{
        //			Console.WriteLine("Datos inválidos.");
        //			return;
        //		}
        //		var s = Students.FirstOrDefault(x => x.Id == studentId);
        //		var c = Courses.FirstOrDefault(x => x.Id == courseId);
        //		if (s == null || c == null) { Console.WriteLine("No encontrado."); return; }

        //		decimal finalPrice = c.BasePrice;
        //		if (promo == "standard") finalPrice = c.BasePrice;
        //		else if (promo == "blackfriday") finalPrice = c.BasePrice * 0.7m;
        //		else if (promo == "vip") finalPrice = c.BasePrice * 0.85m;
        //		else if (promo == "alumni") finalPrice = c.BasePrice * 0.95m;
        //		else if (!string.IsNullOrWhiteSpace(promo))
        //		{
        //			Console.WriteLine("Promo desconocida, se ignora.");
        //		}


        //		PaymentBase payment;
        //		if (paymentType == "card") payment = new CardPayment();
        //		else if (paymentType == "cash") payment = new CashPayment();
        //		else if (paymentType == "transfer") payment = new TransferPayment();
        //		else if (paymentType == "crypto") payment = new CryptoPayment();
        //		else payment = new CashPayment();

        //		var ok = payment.Pay(finalPrice);
        //		if (!ok) { Console.WriteLine("Pago rechazado"); return; }


        //		var id = Guid.NewGuid().ToString("N");
        //		Enrollments.Add((id, s.Id, c.Id, finalPrice, true));
        //		_repo.SaveEnrollment(id, s.Id, c.Id, finalPrice);

        //		_notifier.SendEmail(s.Email, "Inscripción confirmada", $"Curso: {c.Name} — Monto: {finalPrice:C}");
        //		_notifier.SendSms(s.Phone, $"Pago OK por {finalPrice:C}");

        //		try { _notifier.SendPush("console-device", "Notificación push innecesaria"); } catch { }

        //		Console.WriteLine("Operación completada.");
        //	}
        //	catch (Exception ex)
        //	{
        //		Console.WriteLine("Ocurrió un error pero se continuó: " + ex.Message);
        //	}
        //}

        //public void ListEnrollments()
        //{
        //	foreach (var e in Enrollments)
        //		Console.WriteLine($"{e.id} - S:{e.studentId} C:{e.courseId} Precio:{e.price:C} Pagado:{e.paid}");
        //}
}

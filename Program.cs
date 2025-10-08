using PII2025_EjercicioSOLID;
using PII2025_EjercicioSOLID.Data;
using PII2025_EjercicioSOLID.Factories;
using PII2025_EjercicioSOLID.Interfaces;
using PII2025_EjercicioSOLID.Models;
using PII2025_EjercicioSOLID.SOLID_Services;

IStudentRepository studentRepository = new InMemoryStudentRepository();
ICourseRepository courseRepository = new InMemoryCouseRepository();
IEnrollmentRepository enrollmentRepository = new FileEnrollmentRepository("db");
INotificationService notificationService = new ConsoleNotificationService();

var pricingFactory = new PricingStrategyFactory();
var paymentFactory = new PaymentProcessorFactory();

var app = new EnrollmentManager(
    studentRepository,
    courseRepository,
    enrollmentRepository,
    pricingFactory,
    notificationService,
    paymentFactory
);

//DataSeeder.Seed(courseRepository);

//CargarDatos cd = new CargarDatos();
//cd.Seed();

((InMemoryCouseRepository)courseRepository).Seed();


while (true)
        {
            Console.WriteLine("\n=== Campus Console (CORREGIDO) ==="); //SOLID implementado
            Console.WriteLine("1) Listar cursos");
            Console.WriteLine("2) Registrar estudiante");
            Console.WriteLine("3) Inscribir y pagar");
            Console.WriteLine("4) Listar inscripciones");
            Console.WriteLine("0) Salir");
            Console.Write("> ");
            var op = Console.ReadLine();
            if (op == "0") break;
            switch (op)
            {
        //        case "1":
        //            cs.ListCourses();
        //            break;
        //        case "2":
        //            Console.Write("Nombre: ");
        //            var name = Console.ReadLine() ?? "";
        //            Console.Write("Email: ");
        //            var email = Console.ReadLine() ?? "";
        //            Console.Write("Tel.: ");
        //            var phone = Console.ReadLine() ?? "";
        //            st.RegisterStudent(name, email, phone);
        //            break;
        //        case "3":
        //            Console.Write("Id Estudiante: ");
        //            var sid = Console.ReadLine();
        //            Console.Write("Id Curso: ");
        //            var cid = Console.ReadLine();
        //            Console.Write("Promo (standard/blackfriday/vip): ");
        //            var promo = Console.ReadLine();
        //            Console.Write("Pago (card/cash/transfer/crypto): ");
        //            var pay = Console.ReadLine();
        //            enrollmentManager.EnrollAndPay(sid, cid, promo, pay);
        //            break;
        //        case "4":
        //            en.ListEnrollments();
        //            break;
        //        default:
        //            Console.WriteLine("Opción inválida");
        //            break;
        //    }
        //}
        //Console.WriteLine("Fin.");

                    case "1":
                        foreach (var c in courseRepository.GetAll())
                            Console.WriteLine($"{c.Id} - {c.Name} - {c.BasePrice:C}");
                        break;
                    case "2":
                        Console.Write("Nombre: ");
                        var name = Console.ReadLine() ?? "";
                        Console.Write("Email: ");
                        var email = Console.ReadLine() ?? "";
                        Console.Write("Tel.: ");
                        var phone = Console.ReadLine() ?? "";
                        studentRepository.Save(new Student { Name = name, Email = email, Phone = phone });
                        break;
                    case "3":
                        Console.Write("Id Estudiante: ");
                        var sid = Console.ReadLine() ?? "";
                        Console.Write("Id Curso: ");
                        var cid = Console.ReadLine() ?? "";
                        Console.Write("Promo (standard/blackfriday/vip/alumni): ");
                        var promo = Console.ReadLine() ?? "";
                        Console.Write("Pago (card/cash/transfer/crypto): ");
                        var pay = Console.ReadLine() ?? "";
                        app.EnrollAndPay(sid, cid, promo, pay);
                        break;
                    case "4":
                        Console.WriteLine("Historial de Inscripciones");
                        var enrollments = enrollmentRepository.GetAll();
                        if (!enrollments.Any())
                        {
                            Console.WriteLine("No hay inscripciones registradas.");
                            break;
                        }
                        foreach (var e in enrollmentRepository.GetAll())
                            Console.WriteLine(e);
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
    }
}
Console.WriteLine("Fin.");
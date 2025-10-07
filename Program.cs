

using PII2025_EjercicioSOLID;
using PII2025_EjercicioSOLID.Class;
using PII2025_EjercicioSOLID.Data;
using PII2025_EjercicioSOLID.Factories;
using PII2025_EjercicioSOLID.Interfaces;
using PII2025_EjercicioSOLID.SOLID_Services;

IStudentRepository studentRepository = new InMemoryStudentRepository();
ICourseRepository courseRepository = new InMemoryCourseRepository();
IEnrollmentRepository enrollmentRepository = new FileEnrollmentRepository("db/enrollments.csv");

INotificationService notificationService = new ConsoleNotificationService();

var pricingFactory = new PricingStrategyFactory();
var paymentFactory = new PaymentProcessorFactory();

var enrollmentManager = new EnrollmentManager(
    studentRepository,
    courseRepository,
    enrollmentRepository,
    notificationService, 
    pricingFactory,
    paymentFactory
);

//DataSeeder.Seed(courseRepository);

CargarDatos cd = new CargarDatos();
cd.Seed();



        while (true)
        {
            Console.WriteLine("\n=== Campus Console (ANTI-PATRONES) ===");
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
                case "1":
                    cs.ListCourses();
                    break;
                case "2":
                    Console.Write("Nombre: ");
                    var name = Console.ReadLine() ?? "";
                    Console.Write("Email: ");
                    var email = Console.ReadLine() ?? "";
                    Console.Write("Tel.: ");
                    var phone = Console.ReadLine() ?? "";
                    st.RegisterStudent(name, email, phone);
                    break;
                case "3":
                    Console.Write("Id Estudiante: ");
                    var sid = Console.ReadLine();
                    Console.Write("Id Curso: ");
                    var cid = Console.ReadLine();
                    Console.Write("Promo (standard/blackfriday/vip): ");
                    var promo = Console.ReadLine();
                    Console.Write("Pago (card/cash/transfer/crypto): ");
                    var pay = Console.ReadLine();
                    enrollmentManager.EnrollAndPay(sid, cid, promo, pay);
                    break;
                case "4":
                    en.ListEnrollments();
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
        Console.WriteLine("Fin.");
    }
}
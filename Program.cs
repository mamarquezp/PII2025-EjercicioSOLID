

using PII2025_EjercicioSOLID;

var app = new EnrollmentManager();
app.Seed();

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
			app.ListCourses();
			break;
		case "2":
			Console.Write("Nombre: ");
			var name = Console.ReadLine() ?? "";
			Console.Write("Email: ");
			var email = Console.ReadLine() ?? "";
			Console.Write("Tel.: ");
			var phone = Console.ReadLine() ?? "";
			app.RegisterStudent(name, email, phone);
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
			app.EnrollAndPay(sid, cid, promo, pay);
			break;
		case "4":
			app.ListEnrollments();
			break;
		default:
			Console.WriteLine("Opción inválida");
			break;
	}
}
Console.WriteLine("Fin.");
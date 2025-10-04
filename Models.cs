using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID
{
    //public class Student
    //{
    //    public string Id;
    //    public string Name;
    //    public string Email;
    //    public string Phone;
    //}

	//public class Course
	//{
	//	public string Id;
	//	public string Name;
	//	public decimal BasePrice;
	//}

	//public abstract class PaymentBase
	//{
	//	public virtual bool Pay(decimal amount) { return true; }
	//	public virtual void Refund(decimal amount)
	//	{
	//		throw new NotImplementedException("Refund no está soportado, a veces sí, a veces no.");
	//	}
	//}

	//public class CardPayment : PaymentBase
	//{
	//	public override bool Pay(decimal amount)
	//	{
	//		Console.WriteLine($"[CARD] Cobrado {amount:C}");
	//		return true;
	//	}
	//}
	//public class CashPayment : PaymentBase
	//{
	//	public override bool Pay(decimal amount)
	//	{
	//		Console.WriteLine($"[CASH] Registrado {amount:C}");
	//		return true;
	//	}
	//	public override void Refund(decimal amount)
	//	{
	//		Console.WriteLine($"[CASH] Refund {amount:C}");
	//	}
	//}
	//public class TransferPayment : PaymentBase
	//{
	//	public override bool Pay(decimal amount)
	//	{
	//		Console.WriteLine($"[TRANSFER] Enviada orden al banco por {amount:C}");
	//		return true;
	//	}
	//}
	//public class CryptoPayment : PaymentBase
	//{
	//	public override bool Pay(decimal amount)
	//	{
	//		if (amount != Math.Truncate(amount))
	//			throw new InvalidOperationException("Crypto solo admite montos enteros (oculto).");
	//		Console.WriteLine($"[CRYPTO] Hash ok por {amount:C}");
	//		return true;
	//	}
	//}

	//public interface INotifierFat
	//{
	//	void SendEmail(string to, string subject, string body);
	//	void SendSms(string phone, string message);
	//	void SendPush(string deviceId, string message);
	//}

	//public class ConsoleNotifier : INotifierFat
	//{
	//	public void SendEmail(string to, string subject, string body)
	//		=> Console.WriteLine($"[EMAIL] To:{to} Subj:{subject} Body:{body}");
	//	public void SendSms(string phone, string message)
	//		=> Console.WriteLine($"[SMS] To:{phone} Msg:{message}");
	//	public void SendPush(string deviceId, string message)
	//		=> throw new NotSupportedException("Push no está disponible en consola, pero la interfaz lo exige.");
	//}

	//public class FileRepository
	//{
	//	public void SaveEnrollment(string id, string studentId, string courseId, decimal finalPrice)
	//	{
	//		System.IO.Directory.CreateDirectory("db");
	//		var line = $"{id};{studentId};{courseId};{finalPrice}";
	//		System.IO.File.AppendAllLines("db/enrollments.csv", new[] { line });
	//	}
	//}
}

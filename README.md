# Refactorización del Proyecto Campus Console

Este documento detalla el proceso de refactorización de la aplicación, enfocándose en la identificación y eliminación de los code smells y la aplicación de los principios de diseño SOLID.

## 1) Smells de Código Identificados y Solucionados

Se identificó varias áreas de mejora en el código original, entre ellas:

* **Estado global / compartido indebido:** Las listas de entidades (`Student`, `Course`, `Enrollment`) eran `static`, provocando acoplamiento global.
    * **Solución:** Se encapsuló las colecciones dentro de clases `Repository` con estado privado, eliminando el acceso global.

* **Violación de SRP (Principio de Responsabilidad Única):** Una sola clase gestionaba la lógica de negocio, el acceso a datos, los cálculos y las notificaciones.
    * **Solución:** Se separó cada responsabilidad en su propia clase: `EnrollmentManager` para la orquestación, repositorios para los datos, fábricas y estrategias para cálculos de precios, procesamiento de pagos y un servicio para la notificación.

* **Violación de OCP (Principio Abierto/Cerrado):** El código original requería modificar los `if/else` para añadir nuevos métodos de pago o promociones.
    * **Solución:** Se implementó el **patrón Strategy** a través de las interfaces `IPriceDiscount` y `IPaymentProcessor`, y el **patrón Factory** para seleccionarlas dinámicamente. Por lo que ahora el sistema si es extensible sin necesidad de modificar el código existente.

* **Violación de DIP (Principio de Inversión de Dependencias):** La lógica de negocio dependía directamente de implementaciones concretas (`ConsoleNotifier`, `FileRepository`).
    * **Solución:** Se invirtió la dependencia. `EnrollmentManager` ahora depende de abstracciones (`IStudentRepository`, `INotificationService`) que se inyectan en su constructor.

* **Violación de ISP (Principio de Segregación de Interfaces):** La interfaz `INotifierFat` obligaba a las clases a implementar métodos que no usaban (como `SendPush` en una app de consola).
    * **Solución:** Se reemplazó por `INotificationService`, una interfaz específica para la confirmación de inscripciones.

* **Acoplamiento a Infraestructura:** La lógica de negocio estaba acoplada a la consola (`Console.WriteLine`) y al sistema de archivos (`File.AppendAllLines`).
    * **Solución:** Estas operaciones se abstrajeron detrás de las interfaces `INotificationService` y `IEnrollmentRepository`, desacoplando el núcleo del sistema de la infraestructura externa.

## 2) Estructura del Código Refactorizado

La nueva estructura del proyecto cumple con los criterios de diseño moderno y los principios SOLID:

* **Separación de Responsabilidades (SRP/DIP):** Las responsabilidades están claramente delimitadas. La inyección de dependencias en el constructor de `EnrollmentManager` asegura un bajo acoplamiento.

* **Inyección de Dependencias:** El punto de entrada de la aplicación (`Program.cs`) ahora actúa como el centralizador que orquesta, se construyen y se conectan todas las dependencias del sistema.

* **Extensibilidad (OCP):** El sistema es fácilmente extensible. Para añadir una nueva promoción, solo se necesita crear una nueva clase que implemente `IPriceDiscount` y registrarla en `PricingStrategyFactory`. El mismo principio aplica para los métodos de pago.

* **Interfaces Específicas (ISP):** Las interfaces son pequeñas y están enfocadas en un solo propósito, evitando que las clases dependan de métodos que no necesitan.

* **Modelos de Dominio:** Las entidades como `Student` y `Course` están definidas como clases simples, con sus responsabilidades de persistencia y gestión manejadas por los repositorios.

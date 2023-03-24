using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farma
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Enfermedad dolorCabeza = new Enfermedad
            {
                Nombre = "Dolor de cabeza",
                CatalogoMedicamentos = new List<Medicamento>
                {
                    new Medicamento { Nombre = "Aspirina", Tipo = "Pastillas", CantidadUnidades = 30, Miligramos = 500, Gramos = 0, FechaVencimiento = new DateTime(2025, 1, 1) },
                    new Medicamento { Nombre = "Ibuprofeno", Tipo = "Pastillas", CantidadUnidades = 20, Miligramos = 400, Gramos = 0, FechaVencimiento = new DateTime(2024, 6, 1) },
                    new Medicamento { Nombre = "acetaminofen", Tipo = "Pastillas", CantidadUnidades = 20, Miligramos = 400, Gramos = 0, FechaVencimiento = new DateTime(2024, 12, 4) },
                    new Medicamento { Nombre = "Paracetamol", Tipo = "Pastillas", CantidadUnidades = 40, Miligramos = 500, Gramos = 0, FechaVencimiento = new DateTime(2023, 12, 1) }
                }
            };

            Enfermedad fiebre = new Enfermedad
            {
                Nombre = "Fiebre",
                CatalogoMedicamentos = new List<Medicamento>
                {
                    new Medicamento { Nombre = "Ibuprofeno", Tipo = "Pastillas", CantidadUnidades = 20, Miligramos = 400, Gramos = 0, FechaVencimiento = new DateTime(2024, 6, 1) },
                    new Medicamento { Nombre = "Paracetamol", Tipo = "Pastillas", CantidadUnidades = 40, Miligramos = 500, Gramos = 0, FechaVencimiento = new DateTime(2023, 12, 1) },
                    new Medicamento { Nombre = "virogrim", Tipo = "Pastillas", CantidadUnidades = 40, Miligramos = 500, Gramos = 0, FechaVencimiento = new DateTime(2023, 10, 16) },
                    new Medicamento { Nombre = "Acetaminofén", Tipo = "Jarabe", CantidadUnidades = 1, Miligramos = 500, Gramos = 0, FechaVencimiento = new DateTime(2024, 1, 1) }
                }
            };

            Enfermedad tos = new Enfermedad
            {
                Nombre = "Tos",
                CatalogoMedicamentos = new List<Medicamento>
                {
                    new Medicamento { Nombre = "Jarabe para la tos", Tipo = "Jarabe", CantidadUnidades = 1, Miligramos = 0, Gramos = 100, FechaVencimiento = new DateTime(2023, 9, 1) },
                    new Medicamento { Nombre = "Pastillas para la tos", Tipo = "Pastillas", CantidadUnidades = 30, Miligramos = 0, Gramos = 0, FechaVencimiento = new DateTime(2024, 3, 1) },
                    new Medicamento { Nombre = "acetaminofen", Tipo = "Pastillas", CantidadUnidades = 30, Miligramos = 0, Gramos = 0, FechaVencimiento = new DateTime(2024, 6, 18) },
                    new Medicamento { Nombre = "Crema para aliviar", Tipo = "Pomada", CantidadUnidades = 1, Miligramos = 0, Gramos = 100, FechaVencimiento = new DateTime(2023, 11, 1) }
                }
            };
            Enfermedad dolorMuscular = new Enfermedad
            {
                Nombre = "Dolor muscular",
                CatalogoMedicamentos = new List<Medicamento>
            {
                new Medicamento { Nombre = "Pastillas para el dolor", Tipo = "Pastillas", CantidadUnidades = 30, Miligramos = 0, Gramos = 0, FechaVencimiento = new DateTime(2024, 3, 1) },
                new Medicamento { Nombre = "Ibuprofeno", Tipo = "Pastillas", CantidadUnidades = 20, Miligramos = 400, Gramos = 0, FechaVencimiento = new DateTime(2024, 6, 1) },
                new Medicamento { Nombre = "inyeccion para el dolor", Tipo = "inyeccion", CantidadUnidades = 20, Miligramos = 400, Gramos = 0, FechaVencimiento = new DateTime(2024, 7, 17) },
                new Medicamento { Nombre = "Crema para el dolor muscular", Tipo = "Pomada", CantidadUnidades = 1, Miligramos = 0, Gramos = 100, FechaVencimiento = new DateTime(2023, 11, 1) }
            }
            };

            
            List<Enfermedad> enfermedades = new List<Enfermedad> { dolorCabeza, fiebre, tos, dolorMuscular };

            
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a la farmacéutica");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Mostrar catálogo de medicamentos");
                Console.WriteLine("2. Crear una nueva venta");
                Console.WriteLine("3. Salir");
                Console.Write("Opción seleccionada: ");

                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                           
                            Console.Clear();
                            Console.WriteLine("Catálogo de medicamentos:");
                            Console.WriteLine("------------------------");
                            foreach (Enfermedad enfermedad in enfermedades)
                            {
                                Console.WriteLine(enfermedad.Nombre);
                                Console.WriteLine("------------------");
                                foreach (Medicamento medicamento in enfermedad.CatalogoMedicamentos)
                                {
                                    Console.WriteLine($"- {medicamento.Nombre} ({medicamento.Tipo}) - Cantidad: {medicamento.CantidadUnidades} - Miligramos: {medicamento.Miligramos} - Gramos: {medicamento.Gramos} - Vencimiento: {medicamento.FechaVencimiento}");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case 2:
                            
                            Console.Clear();
                            Console.WriteLine("Nueva venta");
                            Console.WriteLine("-----------");
                            Console.Write("Nombre del cliente: ");
                            string nombreCliente = Console.ReadLine();
                            Venta nuevaVenta = new Venta { Cliente = nombreCliente, Medicamentos = new List<Medicamento>() };
                            bool ventaTerminada = false;
                            while (!ventaTerminada)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(" SE PUEDEN SELECIONAR MAS DE UN MEDICAMENTO ");
                                Console.WriteLine(" CUANDO TERMINE DE SELECIONAR LOS MEDICAMENTOS SELECIONE  ");
                                Console.ResetColor();
                                Console.WriteLine("Seleccione un medicamento para agregar a la venta:");
                                Console.WriteLine("-------------------------------------------------");
                                int contador = 1;
                                foreach (Enfermedad enfermedad in enfermedades)
                                {
                                    Console.WriteLine($"{enfermedad.Nombre}:");
                                    foreach (Medicamento medicamento in enfermedad.CatalogoMedicamentos)
                                    {
                                        Console.WriteLine($"{contador}. {medicamento.Nombre} ({medicamento.Tipo}) - Cantidad: {medicamento.CantidadUnidades} - Miligramos: {medicamento.Miligramos} - Gramos: {medicamento.Gramos} - Vencimiento: {medicamento.FechaVencimiento}");
                                        contador++;
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine($"{contador}. Terminar venta");
                                Console.Write("Opción seleccionada: ");
                                if (int.TryParse(Console.ReadLine(), out int opcionMedicamento))
                                {
                                    if (opcionMedicamento >= 1 && opcionMedicamento <= contador - 1)
                                    {
                                        
                                        Medicamento medicamentoSeleccionado = null;
                                        contador = 1;
                                        foreach (Enfermedad enfermedad in enfermedades)
                                        {
                                            foreach (Medicamento medicamento in enfermedad.CatalogoMedicamentos)
                                            {
                                                if (contador == opcionMedicamento)
                                                {
                                                    medicamentoSeleccionado = medicamento;
                                                    break;
                                                }
                                                contador++;
                                            }
                                            if (medicamentoSeleccionado != null)
                                            {
                                                break;
                                            }
                                        }
                                        if (medicamentoSeleccionado != null)
                                        {
                                            if (medicamentoSeleccionado.CantidadUnidades > 0)
                                            {
                                                nuevaVenta.Medicamentos.Add(medicamentoSeleccionado);
                                                Console.WriteLine($"{medicamentoSeleccionado.Nombre} ha sido agregado a la venta.");
                                                Console.WriteLine("Presione cualquier tecla para continuar...");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                Console.WriteLine("El medicamento seleccionado no está disponible.");
                                                Console.WriteLine("Presione cualquier tecla para continuar...");
                                                Console.ReadKey();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ocurrió un error al seleccionar el medicamento.");
                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (opcionMedicamento == contador)
                                    {
                                        ventaTerminada = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opción inválida. Presione cualquier tecla para continuar...");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Opción inválida. Presione cualquier tecla para continuar...");
                                    Console.ReadKey();
                                }
                            }
                            
                            Console.Clear();
                            Console.WriteLine("Resumen de la venta:");
                            Console.WriteLine("--------------------");
                            Console.WriteLine($"Cliente: {nuevaVenta.Cliente}");
                            Console.WriteLine("Medicamentos:");
                            foreach (Medicamento medicamento in nuevaVenta.Medicamentos)
                            {
                                Console.WriteLine($"- {medicamento.Nombre} ({medicamento.Tipo}) - Cantidad: {medicamento.CantidadUnidades} - Miligramos: {medicamento.Miligramos} - Gramos: {medicamento.Gramos} - Vencimiento: {medicamento.FechaVencimiento}");
                            }
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case 3:
                           
                            salir = true;
                            break;

                        default:
                            Console.WriteLine("Opción inválida. Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida. Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}

public class Enfermedad
{
    public string Nombre { get; set; }
    public List<Medicamento> CatalogoMedicamentos { get; set; }
}


public class Medicamento
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public int CantidadUnidades{ get; set; }
    public double Miligramos { get; set; }
    public double Gramos { get; set; }
    public DateTime FechaVencimiento { get; set; }
}


public class Venta
{
    public string Cliente { get; set; }
    public List<Medicamento> Medicamentos { get; set; }

public Venta()
{
    Medicamentos = new List<Medicamento>();
}

}



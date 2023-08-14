using System;

namespace PrecioProducto
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Precios por artículo de Compra");

Console.Write("Ingrese el precio del artículo: ");
double precio = double.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad que lleva el cliente: ");
int cantidad = int.Parse(Console.ReadLine());

double totalPagar = precio * cantidad;

Console.WriteLine("Total a pagar:$ "+ totalPagar);
     }
  }
}
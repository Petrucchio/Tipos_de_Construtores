﻿
namespace Tipos_de_Construtores.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();

        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null)
            {
                Console.WriteLine($"Adição: {x + y}");
                EventoCalculadora();
            }
            else
            {
                Console.WriteLine("Nenhum inscrito");
            }
        }

        public static void Subtrair(int x, int y)
        {
            if (EventoCalculadora != null)
            {
                Console.WriteLine($"Subtração: {x - y}");
                EventoCalculadora();
            }
            else
            {
                Console.WriteLine("Nenhum inscrito");
            }
        }
    }
}

using System;

namespace Projeto_Final_Bhaskara
{

    public class Algoritimo 
    {
        public static void Main(string [] args)
        {
			double Q;
			double W;
			double E;
			double Del;
			double X1;
			double X2;
			
			Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=======================");
			Console.WriteLine("========Bhaskara=======");
            Console.WriteLine("=======================");
			Console.ResetColor();
			Console.WriteLine();
			
            Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("Digite o valor de Q: ");
            Console.ResetColor();
			Q = Convert.ToDouble(Console.ReadLine());
			
            Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("Digite o valor de W: ");
            Console.ResetColor();
			W = Convert.ToDouble(Console.ReadLine());
			
            Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("Digite o valor de E: ");
            Console.ResetColor();
			E = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine();
			
			if (Q == 0)
			{
                Console.Beep();
                Console.Beep();
				Console.WriteLine("Não é uma equação de segundo grau.");
			}
			else
			{
				Del = Math.Pow(W, 2) - (4*Q*E);
				
				if (Del < 0)
				{
                    Console.Beep();
                    Console.Beep();
					Console.WriteLine($"Como delta é igual a {Del}, a equação não possui raízes reais.");
				}
				else
				{
                
					X1 = (-(W) + Math.Sqrt(Del)) / (2*Q);
					X2 = (-(W) - Math.Sqrt(Del)) / (2*Q);
					
					Console.WriteLine($"Delta = {Del} \nX1 = {X1:N2} \nX2 = {X2:N2}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Obrigado por utilizar nosso programa!! :D");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.Beep(264, 125);
                    Thread.Sleep(250);
                    Console.Beep(264, 125);
                    Thread.Sleep(125);
                    Console.Beep(297, 500);
                    Thread.Sleep(125);
                    Console.Beep(264, 500);
                    Thread.Sleep(125);
                    Console.Beep(352, 500);
                    Thread.Sleep(125);
                    Console.Beep(330, 1000);
                    Thread.Sleep(250);
                    Console.Beep(264, 125);
                    Thread.Sleep(250);
                    Console.Beep(264, 125);
                    Thread.Sleep(125);
                    Console.Beep(297, 500);
                    Thread.Sleep(125);
                    Console.Beep(264, 500);
                    Thread.Sleep(125);
                    Console.Beep(396, 500);
                    Thread.Sleep(125);
                    Console.Beep(352, 1000);
                    Thread.Sleep(250);
                    Console.Beep(264, 125);
                    Thread.Sleep(250);
                    Console.Beep(264, 125);
                    Thread.Sleep(125);
                    Console.Beep(2642, 500);
                    Thread.Sleep(125);
                    Console.Beep(440, 500);
                    Thread.Sleep(125);
                    Console.Beep(352, 250);
                    Thread.Sleep(125);
                    Console.Beep(352, 125);
                    Thread.Sleep(125);
                    Console.Beep(330, 500);
                    Thread.Sleep(125);
                    Console.Beep(297, 1000);
                    Thread.Sleep(250);
                    Console.Beep(466, 125);
                    Thread.Sleep(250);
                    Console.Beep(466, 125);
                    Thread.Sleep(125);
                    Console.Beep(440, 500);
                    Thread.Sleep(125);
                    Console.Beep(352, 500);
                    Thread.Sleep(125);
                    Console.Beep(396, 500);
                    Thread.Sleep(125);
                    Console.Beep(352, 1000);
                    
				}
			}
        }
    }
}
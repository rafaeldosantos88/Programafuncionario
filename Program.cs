using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
                              
            Console.Write("Enter the number off Employees: ");                             //Entre com número de trabalhadoress
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();                                  //Agora vou fazer a leitura dos meus funcionarios guardando em uma lista                

            for(int i = 1; i <= n; i++)                                                 //Fizemos um for para percorrer essa lista começando com 1
            {
                Console.Write($"Employee #{i}data:");                                  //Dados de cada ,fizemos o uso da interpolação $ #{i}
                Console.Write("Outsourced(y/n)?:" );                              //É tercerizado sim ou não
                char ch =char.Parse(Console.ReadLine());                             //Variavel ch é a resposta se é tercerizado ou não
                Console.Write("Name:");                                             //Nome Funcionario
                string name = Console.ReadLine();
                Console.Write("Hours :");                                            //Quantida de horas desse funcionario
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour : ");                            //Valor por horas
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                 
                if(ch == 'y')                                                    // Se ch é igual "y" signigica que é tercerizado
                {
                    Console.Write("Additional Charge: ");                    //digite a despesa adicional
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }


                Console.WriteLine();
                Console.WriteLine("Payments : ");
                foreach(Employee emp in list)     //Vou percorrer minha lista.Para casa funcionario(Employee emp)na minha lista (list) vou imprimir na tela o nome dele e o pagamento
                {
                    Console.WriteLine(emp.Name +"  - $" + emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
                }






            }

        }
    }
}

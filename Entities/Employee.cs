using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Employee //Classe Funcionario                       
    {
        public string Name { get; set; }
        public int Hours { get; set; } //Horas trabalhada pelo funcionario
        public double ValuePerHour{ get; set; } //Valor de cada hora trabalhada

        public Employee()                     //Construtor padrão
        {

        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        public virtual double  Payment()               //Operação pagamento.O pagamento funcionario é diferente do pagamento funcionariotercerizado,foi colocado virtual
        {
            return Hours * ValuePerHour;      // A operação pagamento  vai ser "Horas" * vezes "valor por hora"

        }
    }
}

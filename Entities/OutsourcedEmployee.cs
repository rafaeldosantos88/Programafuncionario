using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class OutsourcedEmployee : Employee                             //Classe funcionario Tercerizado.Essa classe herda da classe Funcionario(Employee),ou seja a classe funcionario tercerizado é um funcionario também                                               
    {
        public double AdditionalCharge { get; set; }               //Despesa adicional
        
        public OutsourcedEmployee()                              //Construtor Padão
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour,double additionalCharge)
            :base(name,hours,valuePerHour)                      //Reaproveitando os três argumentos com base
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;      //Aqui estou aproveitando a logica metodo pagamento um base.Aonde vou adcionar 110%(1.1) dessa despesa adicional
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaTeoria
{
    class Dog:Animal
    {

        //constructor de la clase Dog
        public Dog()
        { }

        //Uso constructor heredado
        public Dog(int age, Boolean fur)
            :base(age, fur)
        { }


        public string bark()
        {
            return "bark..";
        }

        //metodo heredado y sobreescrito
        public override string run()
        {
            return base.run() + " "+ "El perro esta corriendo";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaTeoria
{
    //clase padre o base
    class Animal
    {
        //propiedades
        public int animalAge { get; set; }
        public Boolean animalFur { get; set; }


        //constructores
        public Animal(int age, Boolean fur)
        {
            animalAge = age;
            animalFur = fur;
        }
        
        public Animal()
        { }

        //metodos
        public string getInfo()
        {
            var fur = "";
            if (animalFur == true)
            {
                fur = "Tiene pelo";
            }
            else {
                fur = "No tiene pelo";
            }
            return "El animal tiene " + animalAge +
                " años, y " + fur;                
        }
        public string walk()
        {
            return "El animal esta caminando solo";
        }

        //overload del metodo walk
        public string walk(string name, string owner)
        {
            return "El " + name +
                " esta caminando con " + owner;
        }        


        //este metodo se debe sobreescribir
        public virtual string run()
        {
            return "El animal esta corriendo";
        }
    }
}

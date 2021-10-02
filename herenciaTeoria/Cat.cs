using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaTeoria
{
    //clase hija o derivad
    //definimos la relacion de herencia entre Cat y Animal
    class Cat:Animal
    {
        //propiedades
        public int lives { get; set; }

        public Cat() { }
        public Cat(int age, Boolean fur, int livesCat)
            :base(age, fur) //herencia de constructor
        {
            lives = livesCat;
        }


        //metodos
        public string meow()
        {
            return "meoooowww";
        }

        //metodo sobreescrito
        public override string run()
        {
            //base.run();
            return "El gato esta corriendo.....";
        }
    }
}

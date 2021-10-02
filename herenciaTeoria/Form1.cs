using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herenciaTeoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //crear la instancia de la clase Cat
            Cat cat = new Cat();

            cat.animalAge = 2;
            cat.animalFur = false;
            cat.lives = 7;

           MessageBox.Show(cat.getInfo());
           MessageBox.Show(cat.walk());
           MessageBox.Show(cat.meow());
           MessageBox.Show(cat.walk("Firulay" ,"Gabriela"));
           MessageBox.Show(cat.run());

            //crear instancia  de la clase Dog
            Dog dog = new Dog();
            dog.animalAge = 3; //propiedad heredada
            dog.animalFur = true;//propieda heredada

            MessageBox.Show(dog.getInfo()); //metodo heredado
            MessageBox.Show(dog.walk());//metodo heredado
            MessageBox.Show(dog.bark()); //metodo propio
            MessageBox.Show(dog.walk("pindo","Alvaro")); //metodo heredado
            MessageBox.Show(dog.run()); //metodo heredado y sobreescrito    
        }
    }
}

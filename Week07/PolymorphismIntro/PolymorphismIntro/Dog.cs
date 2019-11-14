using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    public class Dog : Animal, IMammal
    {
        public string Breed;

        public string HairColor
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void Speak()
        {
            MessageBox.Show("Bark");
        }

        public Dog() { }

        public Dog(string breed, int height, string name)
        {
            this.Breed = breed;
            this.Height = height;
            this.Name = name;
        }
    }
}
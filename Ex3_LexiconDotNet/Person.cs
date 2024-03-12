using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_LexiconDotNet
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        public double Height { get; set; }
        public double Weight { get; set; }
        TextInputError textInputError;

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ålder måste vara större än 0.");
                }
                age = value;
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 10)
                {
                     throw new ArgumentException("Förnamn är obligatoriskt och måste vara mellan 2 och 10 tecken långt.");
                   
                }
                fName = value;
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Efternamn är obligatoriskt och måste vara mellan 3 och 15 tecken långt.");
                }
                lName = value;
            }
        }

  
    }
}

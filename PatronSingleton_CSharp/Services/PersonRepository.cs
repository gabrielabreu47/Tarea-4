using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    
   public sealed class PersonRepository
   {
        public List<Person> Person { get; set; } = new List<Person>();
            public static PersonRepository Instancia { get; } = new PersonRepository();

            private PersonRepository()
            {
                
            }
   }

}


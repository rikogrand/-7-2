using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ7_Ч2 {
        public class Admin: Observer {
            private string name;
            public string Name { get { return name; } }
            public Admin(string name) {
                this.name = name;
            }

            public void Update(Object obj) {
            Console.WriteLine("Уведомление отправлено администратору: \t " + name);
            Console.WriteLine(obj.ToString());
            

            }
        }
    }



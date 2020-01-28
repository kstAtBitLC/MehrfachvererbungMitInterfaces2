using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehrfachvererbungMitInterfaces2 {
    abstract class Person {
        public string Name { get; set; }
    }

    abstract class Bürger: Person {
        public void SteuernZahlen() {
            Console.WriteLine ("Ich zahlen gern ;-)");
        }
    }

    interface Outlaw {
        void MalDieMeinungSagen();        
    }

    class Betrüger:Bürger, Outlaw {
        public void Betrügen () {
            Console.WriteLine ("Sie wurden soeben betrogen!");
        }

        public void MalDieMeinungSagen () {
            Console.WriteLine ("Sach auch mal - sagt der Betrüger!");
        }
    }

    class Kaninchen : Outlaw {
        public string Kosename { get; set; }

        void Outlaw.MalDieMeinungSagen () {
            Console.WriteLine ("laß Dir das von einem Kaninchen sagen!") ;
        }
    }

}

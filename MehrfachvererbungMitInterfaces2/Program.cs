using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehrfachvererbungMitInterfaces2 {
    class Program {
        static void Main (string [] args) {
            // geht nicht wegen abstract
            //Person p = new Person () { Name = "Kurt" };

            // geht nicht wegen abstract
            //Bürger schild = new Bürger ();

            // geht nicht wegen: Outlaw ist keine Klasse, sondern ein Interface
            // mit Interfaces lassen sich keine Objekte erzeugen!!!!
            //Outlaw polizist = new Outlaw ();

            // was immer geht
            //Betrüger x = new Betrüger ();

            // interessant ;-) Ein Array auf Basis von Outlaw
            Outlaw[] al = new Outlaw[2];
            al [ 0 ] = new Kaninchen ();
            al [ 1 ] = new Betrüger ();

            foreach ( var item in al ) {
                item.MalDieMeinungSagen ();                
            }

            Outlaw ol1 = new Betrüger () { Name = "misch" };
            

            Betrüger b = (Betrüger) ol1;
            Console.WriteLine(b.Name);

            Outlaw ol2 = new Kaninchen () { Kosename = "Hasi" };
            Kaninchen k = (Kaninchen) ol2;
            Console.WriteLine (k.Kosename);

            Console.ReadLine ();
        }
    }
}

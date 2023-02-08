using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije
{
    internal class Program
    {
        class Klasa
        {
            int godina;
            string prezime;
            public Klasa(int godina, string prezime)
            {
                this.godina = godina;
                this.prezime = prezime;
            }
            public override string ToString()
            {
                string ispis = "Godina: " + this.godina + "" +
                    " Prezime: " + this.prezime;
                return ispis;
            }
            public int Godina { get => godina; set => godina = value; }  
        }
        static void Main(string[] args)
        {
            //definiranje ArrayList kolekcije
            ArrayList al = new ArrayList();

            //dummy varijable i objekt
            int broj = 1;
            string ime = "Ime";
            bool provjera = false;
            Klasa objekt = new Klasa(2023, "Prezime");

            //dodavanje elementa u ArrayList
            al.Add(objekt);
            al.Add(provjera);
            al.Add(broj);
            al.Add(ime);

            //Ispis elemenata
            Console.WriteLine("----Ispis svih elemenata----");
            for(int i = 0; i< al.Count; i++)
            {
                Console.WriteLine(al[i]);

            }

            al.Remove(provjera);
            al.RemoveAt(2);
            al.Remove("Ime");

            //Ispis elemenata nakon al.remove
            Console.WriteLine("----Ispis nekih elemenata----");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);

            }

            al.Insert(2, broj);

            //Ispis elemenata nakon insert
            Console.WriteLine("----Ispis " +
                "elemenata nakon insert----");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);

            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Teema1
{
    class Class1
    {
        double nota;
        string nume, prenume;
        string status;

        public Class1()
        {
            nota = 0;
            nume = string.Empty;
            prenume = string.Empty;
            status = string.Empty;
        }

        public Class1(string nume_,string prenume_,double nota_)
        {
            nota = nota_;
            nume = nume_;
            prenume = prenume_;
        }

        public string afisare()
        {
            if(nota>=5)
            return string.Format("Elevul {0} {1} are nota {2} si este admis",nume,prenume,nota);
            else
            return string.Format("Elevul {0} {1} are nota {2} si este respins", nume, prenume, nota);
        }

        public string afisareresp()
        {
            if (nota < 5)
                return string.Format("{0} {1} : nota {2}", nume, prenume, nota);
            else
                return string.Empty;
        }

        public string getnumepr()
        {
            return string.Format("{0} {1}",nume,prenume);
        }
        public string reexaminare()
        {
            return string.Empty;
        }

        public void setnota(double nota_)
        {
            nota = nota_;
        }

        public void setstatus(double nota)
        {
            if (nota >= 5)
                status = "admis";
            else
                status = "respins";
        }

        public string getstatus()
        {
            return status;
        }


    }
}

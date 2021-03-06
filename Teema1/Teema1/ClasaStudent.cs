﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Teema1
{
    class Student
    {
        const int MINIM = 5;
        const string GOOD = "admis";
        const string BAD = "respins";

        public string nume { get; set; }
        public string prenume { get; set; }
        public double nota { get; set; }
        public string status{ get; set; }
        

        public Student()
        {
            nota = 0;
            nume = string.Empty;
            prenume = string.Empty;
            status = string.Empty;
        }

        public Student(string nume_,string prenume_,double nota_)
        {
            nota = nota_;
            nume = nume_;
            prenume = prenume_;
        }

        public string afisarePromovabilitate()
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

        public string afisareadmis()
        {
            if (nota >= 5)
                return string.Format("{0} {1} : nota {2}", nume, prenume, nota);
            else
                return string.Empty;
        }

        public Student(string text)
        {
            int k = 0;
            string[] cuvinte = text.Split(", ");
            foreach (string cuv in cuvinte)
            {
                if (k == 0)
                    nume = cuv;
                if (k == 1)
                    prenume = cuv;
                if (k == 2)
                    nota = Convert.ToDouble(cuv);
                k++;
            }
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
            if (nota >= MINIM)
                status = GOOD;
            else
                status = BAD;
        }

        public string getstatus()
        {
            return status;
        }

    }
}

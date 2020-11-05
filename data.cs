using System;

namespace PR2PR2_Code_Quality
{
    class data
    {

        public string nombre;
        public string materia;
        public int parcial1;
        public int parcial2
        public int cFinal;
        public int suma;
        public int promedio;

        public override string ToString()
        {
            return nombre + " - " + materia + " - " + promedio;
        }
        
        public string Name()
        {
            return nombre;
        }

         public string Materia()
        {
            return materia;
        }

         public int Parcial1()
        {
            return parcial1;
        }

         public int Parcial2()
        {
            return parcial2;
        }
        

         public int CFinal()
        {
            return cFinal;
        }

         public int Suma()
        {
            return suma;
        }

         public int Promedio()
        {
            return promedio;
        }
       

    }
}
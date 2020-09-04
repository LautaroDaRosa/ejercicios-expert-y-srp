using System;

namespace SRP
//No cumple con el principio SRP porque posee más de una responsabilidad, debe crear el objeto libro y también almacenarlo
//mediante AlmacenarLibro, las variables no se encuentran encapsuladas, si cumple con el principio expert porque posee
//la información que necesita para cumplir con sus responsabilidades
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}

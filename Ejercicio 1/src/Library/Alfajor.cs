using System;

namespace Expert_SRP
//Cumple con el principio Expert ya que posee la información necesaria para cumplir la responsabilidad que tiene que es 
//crear el objeto(alfajor), pero, no cumple con el principio SRP ya que deberían estar encapsuladas las variables 
//precioDulce y precioMasa
{
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}
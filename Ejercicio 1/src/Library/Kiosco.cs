using System;

namespace Expert_SRP
//No cumple con el principio SRP porque posee más de una responsabilidad, dentro del objeto kiosco, debe comprobar si 
//si puede comprar(PuedeComprar) y hacer conversión de moneda(ConvertirAPesos), además al poseer un valor que varía como
//es el del dólar en relación al peso la clase tendría que cambiar más de una vez ya que el valor del dólar cambia 
//constantemente, tampoco cumple con el principio expert porque requiere información de la clase alfajor que la misma
//clase debería utilizar para hacer el cálculo, ya que es esa clase la que posee la información
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}
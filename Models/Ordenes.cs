using System.Reflection;
namespace appDemo.Models
{
    public class Ordenes
    {
        public string? Instrumento {get; set;}
        public decimal? Precio {get; set;}
        public string? TipoPrecio {get; set;}
        public int? Cantidad {get; set;}
        public decimal? Costo {get;}
        public decimal? Tax {get;}
        public decimal? Total {get;}
        public Ordenes(string instrumento, decimal precio, string tipoPrecio, int cantidad){
        Instrumento = instrumento;
        Precio = precio;
        TipoPrecio = tipoPrecio;
        Cantidad = cantidad;
        Costo = (decimal)(Precio * cantidad);
        Tax = Costo *0.18m;
        Total = Costo + Tax;
        }
    }
}
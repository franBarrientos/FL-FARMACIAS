using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Dominio
{
    public class BD
    {
        public static Dictionary<string, List<string>> provinciasYLocalidades { get; set; } = new Dictionary<string, List<string>>()
        {
            { "Buenos Aires", new List<string> { "La Plata", "Mar del Plata", "Bahía Blanca", "Tandil" } },
            { "Ciudad Autónoma de Buenos Aires", new List<string> { "Palermo", "Recoleta", "Belgrano", "Villa Urquiza" } },
            { "Catamarca", new List<string> { "San Fernando del Valle de Catamarca", "Tinogasta", "Andalgalá" } },
            { "Chaco", new List<string> { "Resistencia", "Sáenz Peña", "Villa Ángela" } },
            { "Chubut", new List<string> { "Rawson", "Comodoro Rivadavia", "Trelew", "Esquel" } },
            { "Córdoba", new List<string> { "Córdoba", "Villa Carlos Paz", "Río Cuarto", "Villa María" } },
            { "Corrientes", new List<string> { "Corrientes", "Goya", "Paso de los Libres", "Mercedes" } },
            { "Entre Ríos", new List<string> { "Paraná", "Concordia", "Gualeguaychú", "Colón" } },
            { "Formosa", new List<string> { "Formosa", "Clorinda", "Pirané" } },
            { "Jujuy", new List<string> { "San Salvador de Jujuy", "Perico", "Palpalá" } },
            { "La Pampa", new List<string> { "Santa Rosa", "General Pico", "Toay" } },
            { "La Rioja", new List<string> { "La Rioja", "Chilecito", "Aimogasta" } },
            { "Mendoza", new List<string> { "Mendoza", "San Rafael", "Godoy Cruz", "Luján de Cuyo" } },
            { "Misiones", new List<string> { "Posadas", "Oberá", "Puerto Iguazú", "Eldorado" } },
            { "Neuquén", new List<string> { "Neuquén", "San Martín de los Andes", "Zapala", "Cutral Có" } },
            { "Río Negro", new List<string> { "Viedma", "San Carlos de Bariloche", "General Roca", "Cipolletti" } },
            { "Salta", new List<string> { "Salta", "Tartagal", "Orán", "Cafayate" } },
            { "San Juan", new List<string> { "San Juan", "Rivadavia", "Jáchal" } },
            { "San Luis", new List<string> { "San Luis", "Villa Mercedes", "Merlo" } },
            { "Santa Cruz", new List<string> { "Río Gallegos", "Caleta Olivia", "El Calafate" } },
            { "Santa Fe", new List<string> { "Santa Fe", "Rosario", "Rafaela", "Venado Tuerto" } },
            { "Santiago del Estero", new List<string> { "Santiago del Estero", "La Banda", "Termas de Río Hondo" } },
            { "Tierra del Fuego, Antártida e Islas del Atlántico Sur", new List<string> { "Ushuaia", "Río Grande", "Tolhuin" } },
            { "Tucumán", new List<string> { "San Miguel de Tucumán", "Tafí Viejo", "Yerba Buena", "Concepción" } }
        };

        public static List<DescuentoDominio> descuentos { get; set; } = new List<DescuentoDominio>()
        {
                new DescuentoDominio(1, "Descuento OSDE", 15.0, true),
                new DescuentoDominio(2, "Descuento Swiss Medical", 12.5, true),
                new DescuentoDominio(3, "Descuento Galeno", 10.0, true),
                new DescuentoDominio(4, "Descuento Medicus", 20.0, true),
                new DescuentoDominio(5, "Descuento SPS", 18.0, true)
         };

    }
}

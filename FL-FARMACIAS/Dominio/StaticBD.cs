using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Dominio
{
    public class StaticBD
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
                new DescuentoDominio(1, "OSDE", 15.0, true),
                new DescuentoDominio(2, "Swiss Medical", 12.5, true),
                new DescuentoDominio(3, "Galeno", 10.0, true),
                new DescuentoDominio(4, "Medicus", 20.0, true),
                new DescuentoDominio(5, "SPS", 18.0, true)
         };

      public static List<ClienteDominio> clientes = new List<ClienteDominio>()
    {
        new ClienteDominio("Juan", "Pérez", "12345678", "1122334455", true, descuentos[0]), // Descuento OSDE
        new ClienteDominio("María", "González", "87654321", "1198765432", true, descuentos[1]), // Descuento Swiss Medical
        new ClienteDominio("Carlos", "López", "11223344", "1166554433", true, descuentos[2]), // Descuento Galeno
        new ClienteDominio("Ana", "Martínez", "44332211", "1177889900", false, descuentos[3]), // Descuento Medicus
        new ClienteDominio("Pedro", "Rodríguez", "99887766", "1144556677", true, descuentos[4]), // Descuento SPS
        new ClienteDominio("Laura", "García", "22334455", "1155223344", true, descuentos[0]), // Descuento OSDE
        new ClienteDominio("Lucas", "Fernández", "66778899", "1199887766", false, descuentos[1]), // Descuento Swiss Medical
        new ClienteDominio("Sofía", "Hernández", "55667788", "1133445566", true, descuentos[2]), // Descuento Galeno
        new ClienteDominio("Andrés", "Ramírez", "33445566", "1122446688", true, descuentos[3]), // Descuento Medicus
        new ClienteDominio("Cecilia", "Ruiz", "44556677", "1166778899", true, descuentos[4]), // Descuento SPS
        new ClienteDominio("Miguel", "Jiménez", "11224433", "1188991122", true, descuentos[0]), // Descuento OSDE
        new ClienteDominio("Gabriela", "Díaz", "66778811", "1144223366", true, descuentos[1]), // Descuento Swiss Medical
        new ClienteDominio("Tomás", "Castro", "77889966", "1166334455", false, descuentos[2]), // Descuento Galeno
        new ClienteDominio("Lucía", "Mendoza", "22335566", "1155667788", true, descuentos[3]), // Descuento Medicus
        new ClienteDominio("Martín", "Rivas", "99887755", "1199776655", true, descuentos[4]), // Descuento SPS
        new ClienteDominio("Jorge", "Morales", "55667799", "1133112244", true, descuentos[0]), // Descuento OSDE
        new ClienteDominio("Clara", "Paz", "33445577", "1122334455", false, descuentos[1]), // Descuento Swiss Medical
        new ClienteDominio("Raúl", "Silva", "11229988", "1199887766", true, descuentos[2]), // Descuento Galeno
        new ClienteDominio("Elena", "Vargas", "66778844", "1166334455", true, descuentos[3]), // Descuento Medicus
        new ClienteDominio("Ricardo", "Santos", "22334499", "1155112244", true, descuentos[4]),  // Descuento SPS
    };

        public static List<ProductoDominio> productos = new List<ProductoDominio>
{
    new ProductoDominio(1, "P001", "Perfume Floral", 45.99, 100, new CategoriaDominio(1, "Perfumería", true), true),
    new ProductoDominio(2, "P002", "Desodorante Roll-On", 15.49, 150, new CategoriaDominio(1, "Perfumería", true), true),
    new ProductoDominio(3, "P003", "Jabón Líquido Hidratante", 9.99, 200, new CategoriaDominio(1, "Perfumería", true), true),
    new ProductoDominio(4, "P004", "Crema Facial Anti-Edad", 25.00, 80, new CategoriaDominio(1, "Perfumería", true), true),
    new ProductoDominio(5, "P005", "Champú Suave", 12.99, 120, new CategoriaDominio(1, "Perfumería", true), true),
    new ProductoDominio(6, "P006", "Acondicionador Nutritivo", 14.49, 110, new CategoriaDominio(1, "Perfumería", true), true),
    new ProductoDominio(7, "P007", "Gel Antibacterial", 5.99, 300, new CategoriaDominio(1, "Perfumería", true), true),

    new ProductoDominio(8, "P008", "Paracetamol 500mg", 3.50, 250, new CategoriaDominio(2, "Droguería", true), true),
    new ProductoDominio(9, "P009", "Ibuprofeno 400mg", 4.00, 220, new CategoriaDominio(2, "Droguería", true), true),
    new ProductoDominio(10, "P010", "Antihistamínico", 6.99, 180, new CategoriaDominio(2, "Droguería", true), true),
    new ProductoDominio(11, "P011", "Jarabe para la Tos", 8.49, 160, new CategoriaDominio(2, "Droguería", true), true),
    new ProductoDominio(12, "P012", "Vitaminas C", 9.00, 140, new CategoriaDominio(2, "Droguería", true), true),
    new ProductoDominio(13, "P013", "Tira Reactiva para Glucosa", 12.00, 100, new CategoriaDominio(2, "Droguería", true), true),
    new ProductoDominio(14, "P014", "Termómetro Digital", 15.00, 90, new CategoriaDominio(2, "Droguería", true), true),

    new ProductoDominio(15, "P015", "Pasta de Dientes Blanqueadora", 4.50, 180, new CategoriaDominio(3, "Higiene", true), true),
    new ProductoDominio(16, "P016", "Cepillo de Dientes", 2.50, 200, new CategoriaDominio(3, "Higiene", true), true),
    new ProductoDominio(17, "P017", "Toallitas Húmedas", 3.00, 250, new CategoriaDominio(3, "Higiene", true), true),
    new ProductoDominio(18, "P018", "Gel de Ducha Fresco", 7.99, 160, new CategoriaDominio(3, "Higiene", true), true),
    new ProductoDominio(19, "P019", "Crema Hidratante Corporal", 9.49, 140, new CategoriaDominio(3, "Higiene", true), true),
    new ProductoDominio(20, "P020", "Desodorante Spray", 11.99, 120, new CategoriaDominio(3, "Higiene", true), true)
};


    }
}

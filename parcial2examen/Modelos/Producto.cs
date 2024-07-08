using System.ComponentModel.DataAnnotations;


namespace parcial2examen.Modelos
{
    public class Producto
    {
     
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Image { get; set; }

        public string Categoria { get; set; }

        public int Cantidad { get; set; }

        public string Descripcion { get; set; }
        public double Precio { get; set; }


    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaMVC2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int CategoriaId { get; set; }
        public int ProveedorId { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}

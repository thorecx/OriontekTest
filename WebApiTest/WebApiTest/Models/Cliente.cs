using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Models
{
    public class Cliente
    {
		[Key]
		public int IdCliente { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		public string Nombre { get; set; }

		[Column(TypeName = "nvarchar(50)")]
		public string Apellido { get; set; }

		[Column(TypeName = "nvarchar(15)")]
		public string Cedula { get; set; }

		[Column(TypeName = "nvarchar(15)")]
		public string Telefono { get; set; }

		public ICollection<Direccion> Direccion { get; set; }
	}
}

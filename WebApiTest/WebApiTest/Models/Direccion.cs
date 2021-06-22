using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Models
{
    public class Direccion
    {
		[Key]
		public int IdDireccion { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		public string DescDireccion { get; set; }

		public Cliente Cliente { get; set; }
	}
}

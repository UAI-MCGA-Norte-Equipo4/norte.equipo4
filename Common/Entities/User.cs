using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Common.Entities
{
	public class User : IdentityBase
	{
		[Required]
		[DisplayName("Nombre")]
		public string FirstName { get; set; }

		[Required]
		[DisplayName("Apellido")]
		public string LastName { get; set; }

		[Required]
		[DisplayName("Email")]
		public string Email { get; set; }

		public string City { get; set; }

		[Required]
		[DisplayName("Pais")]
		public string Country { get; set; }

		public DateTime SignupDate { get; set; }

		public int OrderCount { get; set; }
	}
}

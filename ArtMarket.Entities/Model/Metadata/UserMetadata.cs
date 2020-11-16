using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArtMarket.Entities.Model
{
    /// <summary>
    /// UserMetadata Metadata class
    /// </summary>
    [MetadataType(typeof(User.UserMetadata))]
    public partial class User
    {
        public class UserMetadata
        {
            [DisplayName("Id")]
            [Required(ErrorMessage = "Requerido")]
            public int Id
            {
                get;
                set;
            }

            [DisplayName("Nombre")]
            [Required(ErrorMessage = "Requerido")]
            public string
                FirstName
            {
                get;
                set;
            }

            [DisplayName("Apellido")]
            [Required(ErrorMessage = "Requerido")]
            public string
                LastName
            {
                get;
                set;
            }

            [DisplayName("Email")]
            [Required(ErrorMessage = "Requerido")]
            public string
                Email
            {
                get;
                set;
            }

            [DisplayName("Password")]
            [Required(ErrorMessage = "Requerido")]
            public string
            Password

            {
                get;
                set;
            }

            [DisplayName("Ciudad")]
            [Required(ErrorMessage = "Requerido")]
            public string
                City
            {
                get;
                set;
            }

            [DisplayName("País")]
            [Required(ErrorMessage = "Requerido")]
            public string
                Country
            {
                get;
                set;
            }

            [DisplayName("Fecha de registro")]
            [Required(ErrorMessage = "Requerido")]
            public DateTime
                SignUpDate
            {
                get;
                set;
            }

            [DisplayName("Cantidad de pedidos")]
            [Required(ErrorMessage = "Requerido")]
            public int
                OrderCount
            {
                get;
                set;
            }
        }
    }
}

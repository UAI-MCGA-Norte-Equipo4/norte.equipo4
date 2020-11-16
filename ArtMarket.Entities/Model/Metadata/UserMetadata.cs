using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArtMarket.Entities.Model
{
    /// <summary>
    /// UserMetadata Metadata class
    /// </summary>
    [MetadataType(typeof(OrderNumber.OrderNumberMetadata))]
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
            public int
                Email
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
            public double
                Country
            {
                get;
                set;
            }

            [DisplayName("Fecha de registro")]
            [Required(ErrorMessage = "Requerido")]
            public int
                SignUpDate
            {
                get;
                set;
            }

            [DisplayName("Cantidad de pedidos")]
            [Required(ErrorMessage = "Requerido")]
            public double
                OrderCount
            {
                get;
                set;
            }
        }
    }
}

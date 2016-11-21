using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.FormsLogic.Objects
{
    public class OrderObject
    {
        [System.ComponentModel.DisplayName("Numer zamówienia")]
        public int ID { get; set; }

        [System.ComponentModel.DisplayName("E-mail")]
        public string Email { get; set; }

        [System.ComponentModel.DisplayName("Ilość produktów")]
        public int ProductCount { get; set; }

        [System.ComponentModel.DisplayName("Koszt (zł)")]
        public decimal Price { get; set; }

        [System.ComponentModel.DisplayName("Data zamówienia")]
        public string OrderDate { get; set; }

        [System.ComponentModel.DisplayName("Uwagi")]
        public string AttentionToOrder { get; set; }
    }
}

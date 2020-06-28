using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Models.ViewModels
{
    public class ShowOrderViewModel
    {
        public int OrderId { get; set; }
        public int OrderDetailId { get; set; }
        public string title { get; set; }
        public int Count { get; set; }
        public int PriceInEuro { get; set; }
        public int PriceInDollar { get; set; }
        public int SumEuro { get; set; }
        public int SumDollar { get; set; }
    }
}

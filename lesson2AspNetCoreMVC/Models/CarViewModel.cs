using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson2AspNetCoreMVC.Models
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public int ManufactureYear { get; set; }
        public string AdditionalInformation { get; set; }
    }
}

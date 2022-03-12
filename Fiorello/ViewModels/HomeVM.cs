using Fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SlidersData SlidersData { get; set; }
        public About Abouts { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<AboutList> AboutList { get; set; }
        public List<FlowerExpert> FlowerExperts { get; set; }


    }
}

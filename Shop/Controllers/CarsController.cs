using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IallCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IallCars allCars, ICarsCategory allCategories)
        {
            _allCars = allCars;
            _allCategories = allCategories;
        }
        public ViewResult List()
        {
          var cars=  _allCars.Cars;
            return View(cars);
        }
    }
}

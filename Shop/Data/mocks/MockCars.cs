using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IallCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {

                    new Car
                    {
                        name="Tesla",
                        shortDesc ="Современный електромобиль",
                        img="",
                        price =35000,
                        isFavorite = true,
                        avialable=true,
                        Category = _carsCategory.AllCategories.First()
                    },

                    new Car
                    {
                        name="Lifan",
                        shortDesc ="Бюджетный електромобиль",
                        img="",
                        price =3000,
                        isFavorite = true,
                        avialable=true,
                        Category = _carsCategory.AllCategories.First()
                    },

                    new Car
                    {
                        name="BMV",
                        shortDesc ="Мощный",
                        img="",
                        price =7000,
                        isFavorite = true,
                        avialable=true,
                        Category = _carsCategory.AllCategories.Last()
                    },

                    new Car
                    {
                        name="WV",
                        shortDesc ="Народный",
                        img="",
                        price =6000,
                        isFavorite = true,
                        avialable=true,
                        Category = _carsCategory.AllCategories.Last()
                    },

                    new Car
                    {
                     name="Ford",
                     shortDesc ="Первый серийный автомобиль",
                     img="",
                     price =35000,
                     isFavorite = true,
                     avialable=true,
                     Category = _carsCategory.AllCategories.Last()
                    },


                    new Car
                    {
                     name="VAZ",
                     shortDesc ="Класика СССР",
                     img="",
                     price =3000,
                     isFavorite = true,
                     avialable=true,
                     Category = _carsCategory.AllCategories.Last()
                    }
                };
            }

        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getObgectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}

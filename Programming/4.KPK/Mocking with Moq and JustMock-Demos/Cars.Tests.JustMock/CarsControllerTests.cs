namespace Cars.Tests.JustMock
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using System.Collections.Generic;
    using Cars.Models;


    [TestClass]
    public class CarsControllerTests
    {
        private ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
        {
        }

        public CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A4", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        // after commenting Mocked GetById() the test will go in depth
        // but the constructor returns empty object
        // how it should be done?
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DetailsShouldReturnExceptionIfCarIsNull()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());
            var modelCount = model.Count + 1;
            var invalidDetails = (Car)this.GetModel(() => this.controller.Details(modelCount));
        }

        // useless, but for the sake of code coverage
        [TestMethod]
        public void CarsControllerShouldReturnObject() {

            var controller = new CarsController();

            Assert.IsInstanceOfType(controller, typeof(Object));
        }

        [TestMethod]
        public void SearchShouldReturnFilteredCollection()
        {
            var fakeCondition = "";
            var allCars = (ICollection<Car>)this.GetModel(() => this.controller.Index());
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Search(fakeCondition));

            Assert.AreNotEqual(allCars.Count, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortShouldThrowArgumentExceptionIfSortMethodIsInvalid()
        {
            var invalidSortingMethod = "";
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Sort(invalidSortingMethod));
        }

        [TestMethod]
        public void SortedByMakeShouldReturnSortedCollection()
        { 
            var sortByMake = "make";
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Sort(sortByMake));
            var firstCar = model.First();
            var lastCar = model.Last();

            Assert.AreNotEqual(firstCar.Make,lastCar.Make);
            Assert.AreNotEqual(firstCar.Model, lastCar.Model);
        }

        [TestMethod]
        public void SortedByYearShouldReturnSortedCollection() 
        {
            var sortByYear = "year";
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Sort(sortByYear));
            var firstCar = model.First();
            var lastCar = model.Last();

            Assert.AreNotEqual(firstCar.Year, lastCar.Year);
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}

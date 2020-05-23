using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using lesson2AspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson2AspNetCoreMVC.Controllers
{
    public class CarController : Controller
    {
        private string ConString = "Data Source=localhost;Initial Catalog=AlifAcademy;User ID=sa;Password=Root123.";
        
        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConString))
                {
                    var carList = db.Query<CarViewModel>("SELECT * FROM CAR").ToList();
                    return View(carList);
                }
            }
            catch
            {

            }
            return View(null);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string Company, string Model, int? ManufactureYear, string AdditionalInformation)
        {
            var model = new CarViewModel() 
            { 
                Company = Company, 
                Model = Model, 
                ManufactureYear = ManufactureYear.Value, 
                AdditionalInformation = AdditionalInformation 
            };
            using (IDbConnection db = new SqlConnection(ConString))
            {
                db.Execute("INSERT INTO CAR([Company], [Model], [ManufactureYear], [AdditionalInformation]) " +
                    $"VALUES('{model.Company}','{model.Model}',{model.ManufactureYear},'{model.AdditionalInformation}')");
            }
            return RedirectToAction("Index");
        }
      
    }
}
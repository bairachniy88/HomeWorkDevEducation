﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarStore.Domain.Abstract;
using CarStore.Domain.Entities;
using CarStore.WebUI.Models;

namespace CarStore.WebUI.Controllers
{
    public class CarController : Controller
    {
        private ICarRepository repository;
        public int pageSize = 4;
        public CarController(ICarRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(int page=1)
        {
            CarsListViewModel model = new CarsListViewModel
            {
                Cars = repository.Cars
                     .OrderBy(car => car.CarId)
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = repository.Cars.Count()
                }
            };
            return View(model);
        }
    }
}
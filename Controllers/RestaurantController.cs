using Microsoft.AspNetCore.Mvc;
using WebAPI.Database;
using MongoDB.Bson;
using WebAPI.Models;
using System;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]/all")]
    public class RestaurantController: ControllerBase
    {
        private DBServices _dbServices;

        public RestaurantController(DBServices dbServices)
        {
            _dbServices = dbServices;
        }

        [HttpGet(Name ="GetAllDocuments")]
        public async Task<List<RestaurantListings>> Get()
        {
            return await _dbServices.GetAsync();
        }
    }
    //Further api endpoints here
}

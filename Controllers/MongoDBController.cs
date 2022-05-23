using WebAPI.database;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class MongoDBController : ControllerBase
    {
        //Set Up logging 
        private readonly ILogger<MongoDBController> _logger;
        
        public MongoDBController(ILogger<MongoDBController> logger){
            _logger = logger;
        }
        //[HttpGet(Name = "GetAll")]
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EightToTen.Services;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;

        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
        {
            _restaurantPickerServices = restaurantPickerServices;
        }

        [HttpGet]
        [Route("RestaurantPicker/{category}")]

        public string GetRestaurant(string category)
        {
            return _restaurantPickerServices.GetRestaurant(category);
        }
    }
}
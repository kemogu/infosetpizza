using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using infoset.data.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace infoset.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantBranchController : ControllerBase
    {
        private readonly IRestaurantBranchesRepository _restaurantBranchesRepository;
        public RestaurantBranchController(IRestaurantBranchesRepository restaurantBranchesRepository)
        {
            _restaurantBranchesRepository = restaurantBranchesRepository;
        }
        [HttpGet("nearby")]
        public async Task<IActionResult> GetNearstRestaurantBranches(double latitude, double longitude, double maxDistance, int takeNumber)
        {
            var nearstRestaurantBranches = _restaurantBranchesRepository.GetNearstRestaurantBranches(latitude, longitude, maxDistance, takeNumber);
            return Ok(nearstRestaurantBranches);
        }
    }

}
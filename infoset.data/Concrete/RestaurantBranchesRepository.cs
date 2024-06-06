using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using infoset.data.Abstract;
using infoset.entity;

namespace infoset.data.Concrete
{
    public class RestaurantBranchesRepository : IRestaurantBranchesRepository
    {
        public IQueryable<RestaurantBranch> GetNearstRestaurantBranches(double latitude, double longitude, double maxDistance, int takeNumber)
        {
            throw new NotImplementedException();
        }
    }
}
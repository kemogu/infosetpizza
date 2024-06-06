using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using infoset.entity;

namespace infoset.data.Abstract
{
    public interface IRestaurantBranchesRepository
    {
        IQueryable<RestaurantBranch> GetNearstRestaurantBranches(double latitude, double longitude, double maxDistance, int takeNumber);
    }
}
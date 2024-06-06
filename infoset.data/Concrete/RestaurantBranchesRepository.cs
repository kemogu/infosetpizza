using infoset.data.Abstract;
using infoset.entity;
using infoset.helpers;
using Microsoft.EntityFrameworkCore;

namespace infoset.data.Concrete
{
    public class RestaurantBranchesRepository : IRestaurantBranchesRepository
    {
        public readonly AppDbContext _dbContext;
        public readonly DbSet<RestaurantBranch> _dbSet;
        public RestaurantBranchesRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<RestaurantBranch>();
        }
        public IQueryable<RestaurantBranch> GetNearstRestaurantBranches(double latitude, double longitude, double maxDistance, int takeNumber)
        {
            return _dbSet.Where(rb => DistanceHelper.CalculateDistance(latitude, longitude, rb.Latitude, rb.Longitude) <= maxDistance)
            .OrderBy(rb => DistanceHelper.CalculateDistance(latitude, longitude, rb.Latitude, rb.Longitude))
            .Take(takeNumber)
            .ToList();
        }
    }
}
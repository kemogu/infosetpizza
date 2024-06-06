using System.ComponentModel.DataAnnotations;

namespace infoset.entity;

public class RestaurantBranch
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

}

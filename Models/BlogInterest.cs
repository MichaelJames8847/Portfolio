namespace PortfolioProject.Models;

public class BlogInterest 
{
    public int Id { get; set; }
    public int BlogId { get; set; }
    public Blog Blog { get; set; }
    public int InterestId { get; set; }
    public Interest Interest { get; set; }
}
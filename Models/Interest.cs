namespace PortfolioProject.Models;

public class Interest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<BlogInterest> BlogInterests { get; set; }
    public List<Blog> Blogs { get; set; }
}
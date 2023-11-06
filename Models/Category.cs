namespace PortfolioProject.Models;

public class Category 
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public List<BlogCategory> BlogCategories { get; set; }
    public List<Blog> Blogs { get; set; }
}
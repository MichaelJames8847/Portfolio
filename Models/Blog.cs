namespace PortfolioProject.Models;

public class Blog {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PostDate { get; set; }
    public string Image { get; set; }
    public List<BlogCategory> BlogCategories { get; set; }
    public List<BlogInterest> BlogInterests { get; set; }
}
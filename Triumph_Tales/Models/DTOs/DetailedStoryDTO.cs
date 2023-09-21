namespace Triumph_Tales.Models.ViewModels;

public class DetailedStoryDTO
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Company { get; private set; }
    public string CompanyWebsite { get; private set; }
    public string Industry { get; private set; }
    public string ProductsUsed { get; private set; }
    public string ThumbnailUrl { get; private set; }

    public DetailedStoryDTO(string title, string description, string company, string companyWebsite, 
        string industry, string productsUsed, string thumbnailUrl)
    {
        Title = title;
        Description = description;
        Company = company;
        CompanyWebsite = companyWebsite;
        Industry = industry;
        ProductsUsed = productsUsed;
        ThumbnailUrl = thumbnailUrl;
    }
}

namespace Triumph_Tales.Models.ViewModels;

public class BriefStoryDTO
{
    public int Id { get; private set; }
    public string Title { get; private set; }    
    public string SummaryDescription { get; private set; }
    public string Company { get; private set; }
    public string Industry { get; private set; }
    public string ThumbnailUrl { get; private set; }

    public BriefStoryDTO(int id, string title, string summaryDescription, 
        string company, string industry, string thumbnailUrl)
    {
        Id = id;
        Title = title;
        SummaryDescription = summaryDescription;
        Company = company;
        Industry = industry;
        ThumbnailUrl = thumbnailUrl;
    }
}

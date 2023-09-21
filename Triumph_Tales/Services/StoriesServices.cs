using System.Reflection.Metadata.Ecma335;
using Triumph_Tales.Data;
using Triumph_Tales.Exceptions;
using Triumph_Tales.Models;
using Triumph_Tales.Models.ViewModels;
using Triumph_Tales.Repository.Interface;
using Triumph_Tales.Services.Interface;

namespace Triumph_Tales.Services;

public class StoriesServices : IStoriesServices
{
    private readonly IStoriesRepository Repository;
    public StoriesServices(IStoriesRepository repository)
    {
        Repository = repository;
    }

    public string CreateStory(CreateStoryDto createDTO)
    {
        var newStory = new SuccessStory() 
        { 
            Title = createDTO.Title,
            Description = createDTO.Description,
            SummaryDescription = createDTO.SummaryDescription,
            Company = createDTO.Company,
            CompanyWebsite = createDTO.CompanyWebsite,
            Industry = createDTO.Industry,
            ProductsUsed = createDTO.ProductsUsed,
            ThumbnailUrl = createDTO.ThumbnailUrl
        };

        return Repository.CreateStory(newStory);
    }

    public List<BriefStoryDTO> GetAllStories()
    {
        var stories = Repository.GetAllStories()
            .Select(story => new BriefStoryDTO(
            story.Id,
            story.Title,
            story.SummaryDescription,
            story.Company,
            story.Industry,
            story.ThumbnailUrl))
            .ToList();

        if (!stories.Any())
        {
            string errorMessage = "No success stories have been posted yet!";
            throw new EntityNotFoundException(errorMessage);
        }

        return stories;
    }

    public DetailedStoryDTO GetStoryById(int id)
    {
        var story = Repository.GetStoryById(id);

        if (story == null)
        {
            string errorMessage = "The specified success story does not exist!";
            throw new EntityNotFoundException(errorMessage);
        }
        return new DetailedStoryDTO(
            story.Title,
            story.Description,
            story.Company, 
            story.CompanyWebsite,
            story.Industry, 
            story.ProductsUsed,
            story.ThumbnailUrl); 
    }
}

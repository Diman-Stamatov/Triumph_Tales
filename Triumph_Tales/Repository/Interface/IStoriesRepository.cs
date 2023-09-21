using Triumph_Tales.Models;

namespace Triumph_Tales.Repository.Interface;

public interface IStoriesRepository
{    
    IQueryable<SuccessStory> GetAllStories();
    SuccessStory? GetStoryById(int id);
    string CreateStory(SuccessStory story);
}

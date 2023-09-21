using Triumph_Tales.Models;
using Triumph_Tales.Models.ViewModels;

namespace Triumph_Tales.Services.Interface;

public interface IStoriesServices
{
    string CreateStory(CreateStoryDto story);

    DetailedStoryDTO GetStoryById(int id);

    List<BriefStoryDTO> GetAllStories();
}

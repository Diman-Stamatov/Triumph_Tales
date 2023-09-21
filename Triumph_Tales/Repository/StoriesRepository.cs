using Triumph_Tales.Data;
using Triumph_Tales.Models;
using Triumph_Tales.Repository.Interface;

namespace Triumph_Tales.Repository;

public class StoriesRepository : IStoriesRepository
{
    private readonly TriumphTalesDB DbContext;
    public StoriesRepository(TriumphTalesDB dbContext)
    {
        this.DbContext = dbContext;
    }

    public string CreateStory(SuccessStory story)
    {
        DbContext.Add(story);
        DbContext.SaveChanges();
        return story.Title;
    }

    public IQueryable<SuccessStory> GetAllStories()
    {
        return DbContext.Stories;
    }

    public SuccessStory? GetStoryById(int id)
    {
        return DbContext.Stories
            .Where(story=>story.Id == id)
            .FirstOrDefault();
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Triumph_Tales.Exceptions;
using Triumph_Tales.Models.ViewModels;
using Triumph_Tales.Services.Interface;

namespace Triumph_Tales.Controller;

[Route("api/stories")]
[ApiController]
public class StoriesController : ControllerBase
{
    private readonly IStoriesServices StoriesServices;

    public StoriesController(IStoriesServices storiesServices)
    {
        this.StoriesServices = storiesServices;
    }

    [HttpPost]
    public IActionResult PostStory([FromBody] CreateStoryDto storyDto)
    {
        var newStoryTitle = StoriesServices.CreateStory(storyDto);
        string successMessage = $"A new story with the title \"{newStoryTitle}\" was created successfully.";
        return StatusCode(StatusCodes.Status200OK, successMessage);
    }

    [HttpGet]
    public IActionResult GetAllStories()
    {
        try
        {
            var result = StoriesServices.GetAllStories();
            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (EntityNotFoundException exception)
        {
            return StatusCode(StatusCodes.Status404NotFound, exception.Message);
        }
        
    }
    [HttpGet("{id}")]
    public IActionResult GetDetailedStory([FromRoute] int id)
    {
        try
        {
            var result = StoriesServices.GetStoryById(id);
            return StatusCode(StatusCodes.Status200OK, result);
        }
        catch (EntityNotFoundException exception)
        {
            return StatusCode(StatusCodes.Status404NotFound, exception.Message);
        }
        
    }
}

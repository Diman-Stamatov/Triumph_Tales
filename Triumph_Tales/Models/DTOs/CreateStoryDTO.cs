using System.ComponentModel.DataAnnotations;

namespace Triumph_Tales.Models.ViewModels;

public class CreateStoryDto
{
    private const string errorMessage = "{0} must be between {2} and {1} characters long.";

    [Required, StringLength(50, MinimumLength = 5, ErrorMessage = errorMessage)]
    public string Title { get; set; }

    [Required, StringLength(500, MinimumLength = 10, ErrorMessage = errorMessage)]
    public string Description { get; set; }

    [Required, StringLength(100, MinimumLength = 10, ErrorMessage = errorMessage)]
    public string SummaryDescription { get; set; }

    [Required, StringLength(50, MinimumLength = 2, ErrorMessage = errorMessage)]
    public string Company { get; set; }

    [Required, StringLength(40, MinimumLength = 5, ErrorMessage = errorMessage)]
    public string CompanyWebsite { get; set; }

    [Required, StringLength(20, MinimumLength = 2, ErrorMessage = errorMessage)]
    public string Industry { get; set; }

    [Required, StringLength(300, MinimumLength = 5, ErrorMessage = errorMessage)]
    public string ProductsUsed { get; set; }

    [Required, StringLength(100, MinimumLength = 5, ErrorMessage =  errorMessage)]
    public string ThumbnailUrl { get; set; }
}

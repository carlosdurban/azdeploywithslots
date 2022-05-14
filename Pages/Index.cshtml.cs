using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages;

public enum FeatureFlags
{
    Feature1,
    Feature2
}
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    
    private readonly IConfiguration _config;


    public IndexModel(ILogger<IndexModel> logger,IConfiguration config )
    {
        _logger = logger;
        _config = config;
    }

    public string Secret;
    public void OnGet()
    {
            this.Secret = _config["Movies:ServiceApiKey"];
    }
}

using Volo.Abp.MultiTenancy;

namespace McApp.Web.Pages;

public class IndexModel : McAppPageModel
{
    readonly ICurrentTenant _current;

    public IndexModel(ICurrentTenant current)
    {
        this._current = current;
    }

  
    public void OnGet()
    {

        ViewData["CurrentTenant"] = _current.Id;

       
    }
}

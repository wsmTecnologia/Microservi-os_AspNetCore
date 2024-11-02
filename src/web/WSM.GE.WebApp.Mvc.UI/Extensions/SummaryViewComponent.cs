using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WSM.GE.WebApp.Mvc.UI.Extensions
{
    public class SummaryViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
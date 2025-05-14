using DogsApp.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
namespace DogsApp.Mvc.Controllers;

[Route("Dogs")]
public class DogsController : Controller
{
    DogService dogService = new DogService();
    [Route("")]
    public IActionResult Index()
    {
        var model = dogService.GetAllDogs(); 
        return View();
    }

}

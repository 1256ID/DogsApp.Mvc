using DogsApp.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
namespace DogsApp.Mvc.Controllers;

public class DogsController : Controller
{
    DogService dogService = new DogService();
    public IActionResult Index()
    {
        var model = dogService.GetAllDogs(); 
        return View();
    }

}

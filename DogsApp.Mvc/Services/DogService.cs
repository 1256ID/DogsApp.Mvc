using DogsApp.Mvc.Models;
namespace DogsApp.Mvc.Services;

public class DogService
{
    private List<Dog> dogs = [];

    public void AddDog(Dog dog) => dogs.Add(dog);
    public Dog[] GetAllDogs() => dogs.ToArray();
    public Dog? GetDogById(int id) => dogs.SingleOrDefault(c => c.Id.Equals(id));


}

using DogsApp.Mvc.Models;
namespace DogsApp.Mvc.Services;

public class DogService
{
    private List<Dog> dogs = 
        [
        new Dog {Id = 1 , Name = "Bulldog" , Age = 3}
        ];

    public void AddDog(Dog dog) => dogs.Add(dog);
    public Dog[] GetAllDogs() => dogs.ToArray();
    public Dog? GetDogById(int id) => dogs.SingleOrDefault(c => c.Id.Equals(id));


}

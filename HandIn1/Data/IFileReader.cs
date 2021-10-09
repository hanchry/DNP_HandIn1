using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IFileReader
    {
        IList<Adult> GetAdults();
        IList<Adult> GetAdults(Family family);
        IList<User> GetUsers();
        void AddAdult(Adult adult);
        void RemoveAdult(Adult adult);
        Adult GetAdult(int Id);
        void RemoveJob(Adult adult);
        void AddJob(Adult adult);
        void AddUser(User user);
        User GetUser(string userName);
        IList<Family> GetFamilies();
        Family GetFamily(int id);
        void AddFamily(Family family);
        void RemoveFamily(Family family);
        void AddPet(Pet pet,int FamilyId);
        void RemovePet(Pet pet);
        void AddChild(Child child,int FamilyId);
        void RemoveChild(Child child);
        void AddInterest(Interest interest);
        IList<Interest> getInterests(Child child);
        IList<Child> GetChildrens(Family family);
        IList<Pet> GetPets(Family family);
        IList<Pet> GetPets(Child child);
         void UpdateAdult(Adult adult);



    }
}
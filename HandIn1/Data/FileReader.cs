using 
    System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Models;

namespace FileData
{
    public class FileReader:IFileReader
    {
        private FileContext FileContext;

        public FileReader()
        {
            FileContext = new FileContext();
        }
        
        public IList<Adult> GetAdults()
        {
            return FileContext.Adults;
        }

        public IList<Adult> GetAdults(Family family)
        {
            throw new System.NotImplementedException();
        }

        public User GetUser(string userName)
        {
            return FileContext.Users.FirstOrDefault(user => user.UserName.Equals(userName));
        }

        public void UpdateAdult(Adult adult)
        {
            Adult adultToUpdate = GetAdults().First(t => t.Id == adult.Id);
            adultToUpdate = adult;
            FileContext.SaveChanges();
        }


        public IList<Family> GetFamilies()
        {
            return FileContext.Families;
        }

        public Family GetFamily(int id)
        {
            return FileContext.Families.FirstOrDefault(family => family.Id==id);

        }

        public void AddFamily(Family family)
        {
            FileContext.Families.Add(family);
            FileContext.SaveChanges();
        }

        public void RemoveFamily(Family family)
        {
            FileContext.Families.Remove(family);
            FileContext.SaveChanges();
        }

        public void AddPet(Pet pet, int FamilyId)
        {
            GetFamily(FamilyId).Pets.Add(pet);
        }

        public void RemovePet(Pet pet)
        {
            throw new System.NotImplementedException();
        }

        public void AddChild(Child child, int FamilyId)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveChild(Child child)
        {
            throw new System.NotImplementedException();
        }

        public void AddInterest(Interest interest)
        {
            throw new System.NotImplementedException();
        }

        public IList<Interest> getInterests(Child child)
        {
            throw new System.NotImplementedException();
        }

        public void AddPet(Pet pet,Child child)
        {
            child.Pets.Add(pet);
            FileContext.SaveChanges();
        }

        public void RemovePet(Pet pet,int familyId)
        {
            GetFamily(familyId).Pets.Remove(pet);
        }
        public void AddChild(Child child, Family family)
        {
            family.Children.Add(child);
            FileContext.SaveChanges();
        }

        public void RemoveChild(Child child,Family family)
        {
            family.Children.Remove(child);
            FileContext.SaveChanges();
        }

        public void AddInterest(Child child,Interest interest)
        {
            child.Interests.Add(interest);
            FileContext.SaveChanges();

        }

        public IList<Child> GetChildrens(Family family)
        {
            return family.Children;
        }

        public IList<Pet> GetPets(Family family)
        {
            return family.Pets;
        }

        public IList<Pet> GetPets(Child child)
        {
            return child.Pets;
        }

        public IList<User> GetUsers()
        {
            return FileContext.Users;
        }
        public void AddUser(User user)
        {
            FileContext.Users.Add(user);
            FileContext.SaveChanges();
        }
        
        public void AddAdult(Adult adult)
        {
            FileContext.Adults.Add(adult);
            FileContext.SaveChanges();
        }

        public void RemoveAdult(Adult adult)
        {
            FileContext.Adults.Remove(adult);
            FileContext.SaveChanges();
        }

        public Adult GetAdult(int Id)
        {
            return FileContext.Adults.FirstOrDefault(adult => adult.Id==Id);
        }

        public void RemoveJob(Adult adult)
        {
            Adult toRemove = GetAdults().First(t => t.Id == adult.Id);
            toRemove.JobTitle.JobTitle = "no job";
            toRemove.JobTitle.Salary = 0;
            FileContext.SaveChanges();
        }

        public void AddJob(Adult adult)
        {
            Adult toAdd = GetAdults().First(t => t.Id == adult.Id);
            toAdd.JobTitle = adult.JobTitle;
            FileContext.SaveChanges();
        }
       

        
    }
}
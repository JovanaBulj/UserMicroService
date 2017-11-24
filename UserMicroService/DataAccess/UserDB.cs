using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserMicroService.Models;
using UserMicroService.Util;

namespace UserMicroService.DataAccess
{
    public class UserDB
    {
        //lista svih korisnika
        public static List<User> listOfUsers = new List<User>();

        public int Id { get; private set; }
        public object Name { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public string ZipCode { get; private set; }
        public string CityName { get; private set; }
        public string CountryName { get; private set; }
        public string Phone { get; private set; }

        //vraca sve korisnike 

        public static List<User> GetAllUser()
        {
            return listOfUsers;
        }

        public static UserDB GetUserById(int id)
        {
            foreach (UserDB u in listOfUsers)
            {
                if (u.Id == id)
                {
                    return u;
                }
            }
            Console.WriteLine("No user found!");
            return null;
        }
        public static void RemoveUser(UserDB testUser)
        {
            throw new NotImplementedException();
        }

        public static List<User> GetUserByName(string name)
        {
            List<User> userByName = new List<User>();
            foreach (UserDB user in listOfUsers)
            {
                if(user.Name.Equals(name))
                {
                    userByName.Add(user);
                }
            }

            if (userByName.Count > 0)
            {
                return userByName;
            }

            Console.WriteLine("No user found");
            return null;
        }
        //dodaje novog korisnika
        public static UserDB AddNewUser(UserDB user)
        {
            listOfUsers.Add(user);
            return user;
        }
        //brisanje korisnika na osnovu id 
        public static void RemoveUser(int id)
        {
            UserDB removeUser = GetUserById(id);
            listOfUsers.Remove(removeUser);
        }

        public static UserDB CreateNewUser(int id, string name, string email, string adresa, string zipCode, string cityName, string countryName, string phone)
        {
            UserDB user = new UserDB();
            user.Id = id;
            user.Name = name;
            user.Email = email;
            user.Address = adresa;
            user.ZipCode = zipCode;
            user.CityName = cityName;
            user.CountryName = countryName;
            user.Phone = phone;

            return user;
        }

        //modifikovanje korisnika
        public static UserDB ModifyUser(int id, string name, string email, string adresa, string zipCode, string cityName, string countryName, string phone)
        {
            UserDB user = CreateNewUser(id, name, email, adresa, zipCode, cityName, countryName, phone);
            RemoveUser(id);
            AddNewUser(user);

            return user;
        }

        
    }
}
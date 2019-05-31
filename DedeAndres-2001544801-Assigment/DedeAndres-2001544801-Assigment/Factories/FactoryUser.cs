using DedeAndres_2001544801_Assigment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DedeAndres_2001544801_Assigment.Factories
{
    public class FactoryUser
    {
        public static User createUser(string Name, string email, string password,string gender, DateTime birthdate,string pic, string phone,string address)
        {
            return new User()
            {
                Name = Name,
                Email = email,
                Password = password,
                Gender = gender,
                BirthDate = birthdate,
                Phone = phone,
                Address = address,
                ProfilePic = pic,
                Role = "Member"
            };
        }
    }
}
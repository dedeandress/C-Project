using DedeAndres_2001544801_Assigment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DedeAndres_2001544801_Assigment.Repositories
{
    public class UserReposit
    {
        static DatabaseEntities1 de = new DataBaseEntities1();

        public static List<User> getAll()
        {
            return de.Users.ToList();
        }

        public static bool findEmail(string email) {
            User EmailFound = (from x in de.Users where x.Email.ToString() == email select x).FirstOrDefault();
            if (EmailFound != null)
            {
                return true;
            }
            else {
                return false;
            }
            
        }

        public static User getUser(int id) {
            User GetUser = de.Users.Find(id);
            return GetUser;
        }

        public User compareUser(string email,string password) {
            User selectedUser = (from x in de.Users where x.Email.ToString() == email select x).FirstOrDefault();
            if (selectedUser == null)
            {
                return null;
            }
            else
            {
                if (selectedUser.Password == password)
                {
                    return selectedUser;
                }
                else
                {
                    return null;
                }
            }
        }

        public static int insertUser(User newUser) {
            de.Users.Add(newUser);
            return de.SaveChanges();
        }

        public static int updateUser(int Id, User newUser) {
            User oldUser = de.Users.Find(Id);
            oldUser.Name = newUser.Name;
            oldUser.Password = newUser.Password;
            oldUser.Phone = newUser.Phone;
            oldUser.ProfilePic = newUser.ProfilePic;
            oldUser.Role = newUser.Role;

            return de.SaveChanges();
        }

        public static int deleteUser(int id) {
            User oldProduct = de.Users.Find(id);
            de.Users.Remove(oldProduct);

            return de.SaveChanges();
        }

    }

    internal class DataBaseEntities1 : DatabaseEntities1
    {
    }
}
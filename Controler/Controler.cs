using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageUsers;
using System.ComponentModel.DataAnnotations;

namespace Controler
{
    public class Controler
    {
        public StorageUsers.StorageUsers su { get; set; }

        public Controler()
        {
             su = new StorageUsers.StorageUsers();
        }

        public User IsValid(string username,string password)
        {
            List<User> _users = su.AllUsers();
            foreach(User k in _users)
            {
                if(username == k.Username && password == k.Password)
                {
                    return k;
                }
            }
            return null;
        }

        public int SumNumber(string firstNumber,string secoundNumber)
        {
            if(IsValidInput(firstNumber) && IsValidInput(secoundNumber))
            {
                return Convert.ToInt32(firstNumber) + Convert.ToInt32(secoundNumber);
            }
            return Int32.MaxValue;
        }

        public bool IsValidInput(string input)
        {
            int result;
            
            if (int.TryParse(input, out result))
                return true;

            return false;
        }

        public int DifferenceBettwen(string firstNumber,string secoundNumber)
        {
            if(IsValidInput(firstNumber) && IsValidInput(secoundNumber))
            {
                return Convert.ToInt32(firstNumber) - Convert.ToInt32(secoundNumber);
            }
            return Int32.MaxValue;
        }

        public bool CreateNewUser(string name,string email,string username,string password)
        {
            if (ValidateEmail(email))
            {
                User newUser = new User();
                newUser.Name = name;
                newUser.Username = username;
                newUser.Password = password;
                newUser.Email = email;
                return su.AddUser(newUser);
            }
            return false;
        }

        public bool ValidateEmail(string input)
        {
            return new EmailAddressAttribute().IsValid(input);
        }


    }
}

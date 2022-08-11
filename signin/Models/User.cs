 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace signin.Models
{
    class User
    {
        public string UserName
        {
            get 
            {
                return UserName;
            }
            set
            {
                if (value.Length>5 && value.Length<26)
                 Console.WriteLine(value);
                else
                  Console.WriteLine("Wrong Username type");
            } 
        }
        public string Password 
        { 
            get  
            {
                return Password;
            }
            set
            {
                if (value.Length > 7 && value.Length < 26 && value.Any(char.IsDigit) && value.Any(char.IsLower)&& value.Any(char.IsUpper))
                    Console.WriteLine(value);
                else
                    Console.WriteLine("Wrong password type");
            }
        }
        public User(string UserName)
        {
            this.UserName = UserName;
        }
        //public bool HasDigit(string word)
        //{
        //    if (word.Any(char.IsDigit))
        //        return true;
        //    else
        //        return false;
        //}
        
    }
}


            
               
                

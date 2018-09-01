using Book.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Database
{
     public static class MyDataBase
    {
        static MyDataBase()
        {
            Users = new List<User>();
            Users.Add(new User()
            {
                Username = "Admin",
                Password = "123",
                Name = "Farid",
                Surname = "Gulmammadov",
                Email = "gnfarid@gmail.com"
            });

            Authors = new List<Author>();
            Authors.Add(new Author()
            {
                Name = "J.K.Rowling"
            });

            Categories = new List<Category>();
            Categories.Add(new Category()
            {
                Name = "Fantasy"
            });

            Categories.Add(new Category()
            {
                Name = "Thriller"
            });

              
            Langs = new List<Language>();
            Langs.Add(new Language()
            {
                Lang = "English"
            });
        }

        public static List<User> Users { get; set; }
        public static List<Books> Books { get; set; }
        public static List<Author> Authors {get; set;}
        public static List<Category> Categories { get; set; }
        public static List<Language> Langs { get; set; }

        public static bool Finduser(User user)
        {
            bool Found = false;
            foreach(User item in Users)
            {
                if(item.Username == user.Username && item.Password == user.Password)
                {
                    Found = true;
                    break;
                }
            }
            return Found;
        }
    }
}

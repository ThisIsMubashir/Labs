using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RecipiesEntities context = new RecipiesEntities();
            


            //List<string> my= new List<string>();
            //my.Add("Name");

            //Insert
           /* Recipe recipe = new Recipe();

            recipe.Name = "Salad";

            context.Recipes.Add(recipe);
            context.SaveChanges();*/
           

            //Select
            //Recipe recipe = context.Recipes.FirstOrDefault(r => r.Name == "Salad");
            Recipe recipe = context.Recipes.Where(r => r.Name == "Salad").FirstOrDefault();
            Console.WriteLine(recipe.Id + recipe.Name);
            Console.Read();

            //Update
            /*Recipe recipe = context.Recipes.FirstOrDefault(r => r.Name == "Salad");
            recipe.Name = "Burger";
            context.SaveChanges();*/

            /*Recipe recipe = context.Recipes.FirstOrDefault(r => r.Name == "Salad");
            context.Recipes.Remove(recipe);
            context.SaveChanges();*/

            //Console.WriteLine(recipe.Id);
            //Console.Read(); 

           /* LibraryEntities dbcontext = new LibraryEntities();
            Author a = new Author();
            a.AuthorID = 1;
            a.Affliations = "VIT";
            a.Name = "Mubashir";
            a.Affliations ="IEEE";
            dbcontext.Authors.Add(a);
            dbcontext.SaveChanges();*/

           /* Book b = new Book();
            b.BookId = 1;
            b.Title = "C#";
            b.ISBN = "13134";
            b.Publisher = "worx";
            b.Price = 48.75M;
            b.AuthorID = 1;

            
            dbcontext.Books.Add(b);
            dbcontext.SaveChanges();*/
            


            




        }
    }
}

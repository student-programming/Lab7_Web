using System;
using System.Data.Entity;  
 
namespace MvcMovie.Models 
{ 
// класс для описания фильма     
public class Movie 
    {
         public int ID { get; set; } // порядковый номер фильма в списке 
         public string Title { get; set; } // название фильма 
         public DateTime ReleaseDate { get; set; } // дата релиза
         public string Genre { get; set; } // жанр фильма
         public decimal Price { get; set; } // цена фильма 
    } 
    
     public class MovieDBContext : DbContext 
     { 
         // параметр (переменная) для списка фильмов 
         public DbSet<Movie> Movies { get; set; } 
     } 
} 
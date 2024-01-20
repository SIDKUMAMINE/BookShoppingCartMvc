using BookShoppingCartMvcUI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShoppingCartMvcUI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<OrderStatus> orderStatuses { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Book>().HasData(
    // Programmation
    new Book { Id = 1, BookName = "Refactoring: Improving the Design of Existing Code", AuthorName = "Martin Fowler", Price = 34.99, GenreId = 20, ImageUrl = "refact.jpeg" },
    new Book { Id = 2, BookName = "Code Complete: A Practical Handbook of Software Construction", AuthorName = "Steve McConnell", Price = 39.99, GenreId = 20, ImageUrl = "Code55.jpeg.jpeg" },
    new Book { Id = 3, BookName = "Eloquent JavaScript: A Modern Introduction to Programming", AuthorName = "Marijn Haverbeke", Price = 29.99, GenreId = 20, ImageUrl = "EloquentJavaScriptAModernIntroductiontoProgramming.jpeg" },

    // Science des Données
    new Book { Id = 4, BookName = "Hands-On Machine Learning with Scikit-Learn, Keras, and TensorFlow", AuthorName = "Aurélien Géron", Price = 49.99, GenreId = 30, ImageUrl = "Hands.jpeg" },
    new Book { Id = 5, BookName = "Data Science from Scratch: First Principles with Python", AuthorName = "Joel Grus", Price = 37.99, GenreId = 30, ImageUrl = "Datasc.jpeg" },
    new Book { Id = 6, BookName = "Spark: The Definitive Guide", AuthorName = "Bill Chambers, Matei Zaharia", Price = 44.99, GenreId = 30, ImageUrl = "Session_.jpeg" },

    // Cybersécurité
    new Book { Id = 7, BookName = "The Art of Deception: Controlling the Human Element of Security", AuthorName = "Kevin D. Mitnick, William L. Simon", Price = 42.99, GenreId = 40, ImageUrl = "Arthhh.jpg" },
    new Book { Id = 8, BookName = "Metasploit: The Penetration Tester's Guide", AuthorName = "David Kennedy, Jim O'Gorman, Devon Kearns, Mati Aharoni", Price = 45.99, GenreId = 40, ImageUrl = "ETA_.jpeg" },
    new Book { Id = 9, BookName = "Cybersecurity for Dummies", AuthorName = "Joseph Steinberg", Price = 29.99, GenreId = 40, ImageUrl = "dunnies.jpeg" },

    // Développement Personnel et Professionnel
    new Book { Id = 10, BookName = "The 7 Habits of Highly Effective People", AuthorName = "Stephen R. Covey", Price = 32.99, GenreId = 50, ImageUrl = "7-habits.jpeg" }
);
            builder.Entity<Genre>().HasData(
    // Programmation et Développement
    new Genre { Id = 20, GenreName = "Programmation et Développement" },

    // Science des Données
    new Genre { Id = 30, GenreName = "Science des Données" },

    // Cybersécurité
    new Genre { Id = 40, GenreName = "Cybersécurité" },

    // Développement Personnel et Professionnel
    new Genre { Id = 50, GenreName = "Développement Personnel et Professionnel" }
    );


        }


    }
    }

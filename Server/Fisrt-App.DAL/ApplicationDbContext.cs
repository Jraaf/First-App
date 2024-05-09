using Fisrt_App.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<ListBoard> ListBoards { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListBoard>().HasData(
                new ListBoard
                {
                    Id = 1,
                    Title = "MyBoard1",

                },
                new ListBoard
                {
                    Id = 2,
                    Title = "MyBoard2",

                });
            modelBuilder.Entity<Card>().HasData(
                new Card { Id= 1,Title = "MyCard1", Description = "MyDescription1",ListBoardId= 1},
                new Card { Id= 4,Title = "MyCard2", Description = "MyDescription2",ListBoardId= 1},
                new Card { Id= 5,Title = "MyCard3", Description = "MyDescription3",ListBoardId= 1},
                new Card { Id= 6,Title = "MyCard4", Description = "MyDescription4",ListBoardId= 1},
                new Card { Id= 7,Title = "MyCard5", Description = "MyDescription5",ListBoardId= 1},
                new Card { Id= 8,Title = "MyCard6", Description = "MyDescription6",ListBoardId= 2},
                new Card { Id= 9,Title = "MyCard7", Description = "MyDescription7",ListBoardId= 2},
                new Card { Id= 10,Title = "MyCard8", Description = "MyDescription8",ListBoardId= 2},
                new Card { Id= 11,Title = "MyCard9", Description = "MyDescription9",ListBoardId= 2},
                new Card { Id= 12,Title = "MyCard10", Description = "MyDescription10",ListBoardId= 2}
            );
        }

    }
}

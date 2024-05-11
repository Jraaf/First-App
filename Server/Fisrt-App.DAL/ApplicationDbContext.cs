using Fisrt_App.DAL.Entities;
using Fisrt_App.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public DbSet<Board> Boards { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Board>().HasData(
            //    new Board
            //    {
            //        Id = 1,
            //        Title = "MyBoard1"
            //    },
            //    new Board
            //    {
            //        Id = 2,
            //        Title = "MyBoard2"
            //    });
            //modelBuilder.Entity<ListBoard>().HasData(
            //    CreateListBoards(2, 2)
            //);
            //modelBuilder.Entity<Card>().HasData(
            //   CreateCards(10, 2)
            //);

            modelBuilder.Entity<Card>().ToTable("Cards");
            modelBuilder.Entity<ListBoard>().ToTable("ListBoards");
            modelBuilder.Entity<Board>().ToTable("Boards");

            modelBuilder.Entity<Card>()
                .HasOne(c => c.ListBoard)
                .WithMany(b => b.Cards)
                .HasForeignKey(c => c.ListBoardId);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number">number of cards per each ListBoard</param>
        /// <param name="listBoardsNumber"></param>
        /// <returns></returns>
        private List<Card> CreateCards(int number, int listBoardsNumber)
        {
            var cards = new List<Card>();
            int id = 0;
            for (int i = 1; i <= listBoardsNumber; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    id++;
                    cards.Add(new Card
                    {
                        Id = id,
                        Title = "MyCard" + id.ToString(),
                        Description = "MyDescription" + id.ToString(),
                        ListBoardId = i,
                        BoardId = j,
                    });
                }
            }
            return cards;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number">number of ListBoards per each Board</param>
        /// <param name="numberBoards"></param>
        /// <returns>List<ListBoard> to populate database</returns>
        private List<ListBoard> CreateListBoards(int number, int numberBoards)
        {
            var listBoards = new List<ListBoard>();
            int id = 0;
            for (int i = 1; i <= numberBoards; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    id++;
                    listBoards.Add(new ListBoard
                    {
                        Id = id,
                        Title = "MyTitle" + id.ToString(),
                        BoardId = i,
                    });
                }
            }
            return listBoards;
        }
    }
}

using Fisrt_App.DAL.Entities;
using Fisrt_App.DAL.Repository.Interfaces;
using Fisrt_App.DAL.Repository.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.DAL.Repository
{
    public class ListBoardRepository : Repo<ListBoard, int>, IListBoardRepository
    {
        private readonly ApplicationDbContext _context;
        public ListBoardRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }
        public new async Task<ListBoard?> FindAsync(int key)
        {
            var Cards = await _context.Cards.ToListAsync();
            var listCards=(from Card in Cards
                     where Card.ListBoardId == key
                     select Card).ToList();
            var listBoard = await _context.ListBoards.FindAsync(key);
            listBoard.Cards = listCards;
            await _context.SaveChangesAsync();
            return listBoard;
        }
    }
}

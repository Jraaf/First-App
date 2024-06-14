using Fisrt_App.DAL.Entities;
using Fisrt_App.DAL.Repository.Interfaces;
using Fisrt_App.DAL.Repository.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.DAL.Repository
{
    public class CardRepository : Repo<Card, int>, ICardRepository
    {
        private readonly ApplicationDbContext _context;


        public CardRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Card>> GetManyByListBoardId(int Id)
        {
            var cards = await _context.Cards.ToListAsync();
            var res = (from c in cards
                       where c.ListBoardId == Id
                       select c).ToList();

            return res;
        }
    }
}

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
        public async Task<List<ListBoard>> GetManyByBoardId(int Id)
        {
            var lists= await _context.ListBoards.ToListAsync();
            var res = (from l in lists
                       where l.BoardId == Id
                       select l).ToList();
            return res;
        }
    }
}

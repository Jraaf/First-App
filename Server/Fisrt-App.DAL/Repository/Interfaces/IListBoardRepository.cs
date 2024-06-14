using Fisrt_App.DAL.Entities;
using Fisrt_App.DAL.Repository.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.DAL.Repository.Interfaces
{
    public interface IListBoardRepository:IRepo<ListBoard,int>
    {
        Task<List<ListBoard>> GetManyByBoardId(int id);
    }
}

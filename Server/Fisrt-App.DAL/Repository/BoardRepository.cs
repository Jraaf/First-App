using Fisrt_App.DAL.Entities;
using Fisrt_App.DAL.Repository.Interfaces;
using Fisrt_App.DAL.Repository.Repo;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.DAL.Repository;

public class BoardRepository:Repo<Board,int>,IBoardRepository
{
    public BoardRepository(ApplicationDbContext context)
        : base(context)
    {
        
    }
}

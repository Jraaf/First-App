using Fisrt_App.DAL.Entities;
using Fisrt_App.DAL.Repository.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.DAL.Repository.Interfaces
{
    public interface ICardRepository:IRepo<Card,int>
    {
    }
}

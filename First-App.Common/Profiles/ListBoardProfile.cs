using AutoMapper;
using First_App.Common.DTO;
using Fisrt_App.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App.Common.Profiles;

public class ListBoardProfileL:Profile
{
    public ListBoardProfileL()
    {
        CreateMap<CreateListBoardDTO, ListBoard>();
        CreateMap<ListBoard,ListBoardDTO>();
    }
}

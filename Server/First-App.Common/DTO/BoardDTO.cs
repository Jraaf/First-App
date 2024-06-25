using Fisrt_App.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App.Common.DTO;

public class BoardDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    //public List<ListBoard>? ListBoards { get; set; }
    //public List<Card>? Cards { get; set; }
}

using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace First_App.Common.DTO;

public class ListBoardDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int BoardId { get; set; }
    public List<CardDTO>? Cards { get; set; }
}

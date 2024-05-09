using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App.Common.DTO;

public class CardDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int ListBoardId { get; set; }
    public DateOnly Deadline { get; set; }
}

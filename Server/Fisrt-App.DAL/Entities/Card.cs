﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.DAL.Entities;

public class Card
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public DateOnly Deadline { get; set; }
    public int ListBoardId { get; set; }
    public int BoardId { get; set; }
    public ListBoard ListBoard { get; set; }
    public Board Board { get; set; }

}

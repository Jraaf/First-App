﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.DAL.Entities;

public class ListBoard
{
    public int Id { get; set; }
    public string Title { get; set; } = "Title";
    public int BoardId { get; set; }
    public List<Card> Cards{ get; set; }
    public Board Board { get; set; }
}

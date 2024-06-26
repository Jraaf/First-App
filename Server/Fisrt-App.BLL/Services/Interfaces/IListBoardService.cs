﻿using First_App.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.BLL.Services.Interfaces;

public interface IListBoardService
{
    Task<List<ListBoardDTO>> GetAllAsync();
    Task<ListBoardDTO> GetByIdAsync(int id);
    Task<ListBoardDTO> CreateAsync(CreateListBoardDTO listBoardDTO);
    Task<bool> DeleteAsync(int id);
    Task<ListBoardDTO> UpdateAsync(CreateListBoardDTO listBoardDTO, int Id);
    Task<List<ListBoardDTO>> GetManyByBoardId(int Id);
}

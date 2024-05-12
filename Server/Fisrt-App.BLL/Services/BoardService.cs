using AutoMapper;
using First_App.Common.DTO;
using Fisrt_App.BLL.Exceptions;
using Fisrt_App.BLL.Services.Base;
using Fisrt_App.BLL.Services.Interfaces;
using Fisrt_App.DAL.Entities;
using Fisrt_App.DAL.Repository.Interfaces;
using Fisrt_App.DAL.Repository.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.BLL.Services;

public class BoardService :  IBoardService
{
    private readonly IBoardRepository _repo;
    private readonly IMapper _mapper;
    public BoardService(IBoardRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    public async Task<BoardDTO> CreateAsync(CreateBoardDTO cardDTO)
    {
        var data = _mapper.Map<Board>(cardDTO);
        return _mapper.Map<BoardDTO>(await _repo.AddAsync(data));
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var data = await _repo.GetAsync(id);
        if (data != null)
        {
            return await _repo.DeleteAsync(data);
        }
        throw new NotFoundException(id);
    }

    public async Task<List<BoardDTO>> GetAllAsync()
    {
        var data = await _repo.GetAllAsync();
        return _mapper.Map<List<BoardDTO>>(data);
    }

    public async Task<BoardDTO> GetByIdAsync(int id)
    {
        var data = await _repo.GetAsync(id);
        return _mapper.Map<BoardDTO>(data);
    }

    public async Task<BoardDTO> UpdateAsync(CreateBoardDTO cardDTO, int Id)
    {
        var data = await _repo.GetAsync(Id)
                ?? throw new NotFoundException(Id);

        var card = _mapper.Map(cardDTO, data);

        return _mapper.Map<BoardDTO>(await _repo.UpdateAsync(card));
    }
}

using AutoMapper;
using First_App.Common.DTO;
using Fisrt_App.BLL.Exceptions;
using Fisrt_App.BLL.Services.Interfaces;
using Fisrt_App.DAL.Entities;
using Fisrt_App.DAL.Repository.Interfaces;

namespace Fisrt_App.BLL.Services;

public class ListBoardService : IListBoardService
{
    private readonly IListBoardRepository _repo;
    private readonly IMapper _mapper;
    public ListBoardService(IListBoardRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    public async Task<bool> CreateAsync(CreateListBoardDTO listBoardDTO)
    {
        var data = _mapper.Map<ListBoard>(listBoardDTO);
        return await _repo.AddAsync(data);
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

    public async Task<List<ListBoardDTO>> GetAllAsync()
    {
        var data = await _repo.GetAllAsync();
        return _mapper.Map<List<ListBoardDTO>>(data);
    }

    public async Task<ListBoardDTO> GetByIdAsync(int id)
    {
        var data = await _repo.GetAsync(id);
        return _mapper.Map<ListBoardDTO>(data);
    }

    public async Task<bool> UpdateAsync(CreateListBoardDTO listBoardDTO, int Id)
    {
        var data = await _repo.GetAsync(Id)
                ?? throw new NotFoundException(Id);

        _mapper.Map(listBoardDTO, data);

        return await _repo.UpdateAsync(data);
    }
}

using AutoMapper;
using First_App.Common.DTO;
using Fisrt_App.BLL.Exceptions;
using Fisrt_App.BLL.Services.Interfaces;
using Fisrt_App.DAL.Entities;
using Fisrt_App.DAL.Repository.Interfaces;

namespace Fisrt_App.BLL.Services;

public class CardService : ICardService
{
    private readonly ICardRepository _repo;
    private readonly IMapper _mapper;
    public CardService(ICardRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    public async Task<CardDTO> CreateAsync(CreateCardDTO cardDTO)
    {
        var data = _mapper.Map<Card>(cardDTO);
        return _mapper.Map<CardDTO>(await _repo.AddAsync(data));
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

    public async Task<List<CardDTO>> GetAllAsync()
    {
        var data = await _repo.GetAllAsync();
        return _mapper.Map<List<CardDTO>>(data);
    }

    public async Task<CardDTO> GetByIdAsync(int id)
    {
        var data = await _repo.GetAsync(id);
        return _mapper.Map<CardDTO>(data);
    }

    public async Task<CardDTO> UpdateAsync(CreateCardDTO cardDTO, int Id)
    {
        var data = await _repo.GetAsync(Id)
                ?? throw new NotFoundException(Id);

        var card=_mapper.Map(cardDTO, data);

        return _mapper.Map<CardDTO>(await _repo.UpdateAsync(card));
    }
}

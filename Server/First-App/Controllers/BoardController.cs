using First_App.Common.DTO;
using Fisrt_App.BLL.Exceptions;
using Fisrt_App.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]

    public class BoardController : ControllerBase
    {
        private readonly IBoardService _service;
        public BoardController(IBoardService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(await _service.GetByIdAsync(id));

            }
            catch (NotFoundException e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateBoardDTO obj)
        {
            try
            {
                return Ok(await _service.CreateAsync(obj));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                return Ok(await _service.DeleteAsync(id));
            }
            catch (NotFoundException e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPatch]
        public async Task<IActionResult> Update(CreateBoardDTO obj, int id)
        {
            try
            {
                return Ok(await _service.UpdateAsync(obj, id));

            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}

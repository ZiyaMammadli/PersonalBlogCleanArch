using MediatR;
using Microsoft.AspNetCore.Mvc;
using PersonelBlog.Application.Exceptions.Common;
using PersonelBlog.Application.Features.Commands.BlogCommands.BlogCreateResponse;
using PersonelBlog.Application.Features.Queries.BlogQueries.BlogGetAllQueries;
using PersonelBlog.Application.Features.Queries.BlogQueries.BlogGetByIdQueries;

namespace PersonelBlog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BlogsController(IMediator mediatR)
        {
                _mediator = mediatR;
        }
        [HttpGet("")]
        public async Task <IActionResult> GetAll()
        {
            BlogGetAllRequest blogGetAllRequest = new BlogGetAllRequest();
            return Ok(await _mediator.Send(blogGetAllRequest));
        }
        [HttpGet("{id}")]
        public async Task <IActionResult>GetById(int id)
        {
            try
            {
                BlogGetByIdRequest blogGetByIdRequest = new BlogGetByIdRequest() { Id=id};
                return Ok( await _mediator.Send(blogGetByIdRequest));
            }
            catch(NotFoundException ex)
            {
                return StatusCode(ex.statusCode, ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(BlogCreateRequest blogCreateRequest)
        {
            return Ok( await _mediator.Send(blogCreateRequest));
        }
    }
}

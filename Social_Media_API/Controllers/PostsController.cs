using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Social_Media_API.DataAccess;
using Social_Media_API.DTO_s.PostDTO_s;
using Social_Media_API.Models;

namespace Social_Media_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PostsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result=await _context.Posts.Include(x=>x.Media).Include(x=>x.Likes).Include(x=>x.Comments).ToListAsync();
            if(!result.Any()) {return NotFound(); }
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _context.Posts.Include(x=>x.Media).Include(x=>x.Likes).Include(x=>x.Comments).FirstOrDefaultAsync(x=>x.Id==id);
            if (result is null) { return NotFound(); }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PostCreateDTO postCreateDTO)
        {
            if(postCreateDTO == null) { return BadRequest(); }
            await _context.Posts.AddAsync(new Post
            {
                Description = postCreateDTO.Description,
                Media=postCreateDTO.Media
            });
            await _context.SaveChangesAsync();
            return Ok(postCreateDTO);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(int id, PostUpdateDTO postUpdateDTO)
        {
            var result = await _context.Posts.Include(x=>x.Media).FirstOrDefaultAsync(x => x.Id == id);
            if (result is null) { return NotFound(); }
            if (postUpdateDTO == null) { return BadRequest(); }
            result.Description=postUpdateDTO.Description ?? result.Description;
            result.Media=postUpdateDTO.Media ?? result.Media;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _context.Posts.Include(x => x.Media).FirstOrDefaultAsync(x => x.Id == id);
            if (result is null) { return NotFound(); }
            _context.Remove(result);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}

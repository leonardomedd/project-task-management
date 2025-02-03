using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagementAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BoardController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Board>> GetBoards()
        {
            return _context.Boards.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Board> GetBoard(int id)
        {
            var board = _context.Boards.Find(id);

            if (board == null)
            {
                return NotFound();
            }

            return board;
        }

        [HttpPost]
        public ActionResult<Board> PostBoard(Board board)
        {
            _context.Boards.Add(board);
            _context.SaveChanges();

            return CreatedAtAction("GetBoard", new { id = board.Id }, board);
        }

        [HttpPut("{id}")]
        public IActionResult PutBoard(int id, Board board)
        {
            if (id != board.Id)
            {
                return BadRequest();
            }

            _context.Entry(board).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBoard(int id)
        {
            var board = _context.Boards.Find(id);

            if (board == null)
            {
                return NotFound();
            }

            _context.Boards.Remove(board);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
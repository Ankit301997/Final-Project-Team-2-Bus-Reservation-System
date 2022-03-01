#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusReservationAPI.Models;

namespace BusReservationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingMastersController : ControllerBase
    {
        private readonly OnlineBusBookingContext _context;

        public BookingMastersController(OnlineBusBookingContext context)
        {
            _context = context;
        }

        // GET: api/BookingMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingMaster>>> GetBookingMasters()
        {
            return await _context.BookingMasters.ToListAsync();
        }

        // GET: api/BookingMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingMaster>> GetBookingMaster(int id)
        {
            var bookingMaster = await _context.BookingMasters.FindAsync(id);

            if (bookingMaster == null)
            {
                return NotFound();
            }

            return bookingMaster;
        }

        // PUT: api/BookingMasters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookingMaster(int id, BookingMaster bookingMaster)
        {
            if (id != bookingMaster.BookingId)
            {
                return BadRequest();
            }

            _context.Entry(bookingMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingMasterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BookingMasters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookingMaster>> PostBookingMaster(BookingMaster bookingMaster)
        {
            _context.BookingMasters.Add(bookingMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookingMaster", new { id = bookingMaster.BookingId }, bookingMaster);
        }

        // DELETE: api/BookingMasters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingMaster(int id)
        {
            var bookingMaster = await _context.BookingMasters.FindAsync(id);
            if (bookingMaster == null)
            {
                return NotFound();
            }

            _context.BookingMasters.Remove(bookingMaster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookingMasterExists(int id)
        {
            return _context.BookingMasters.Any(e => e.BookingId == id);
        }
    }
}

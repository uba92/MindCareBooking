using MindCareBooking.Application.Commons;
using MindCareBooking.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindCareBooking.Application.Services.Interfaces
{
    public interface IBookingService
    {
        Task<Result<BookingResponse>> CreateBookingAsync(Guid userId, CreateBookingRequest request);
        Task<Result> DeleteBookingAsync(Guid userId, Guid bookingId);
        Task<Result<List<BookingResponse>>> GetBookingsByUserIdAsync(Guid userId);
    }
}

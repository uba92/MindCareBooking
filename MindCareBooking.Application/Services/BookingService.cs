using MindCareBooking.Application.Abstractions;
using MindCareBooking.Application.Commons;
using MindCareBooking.Application.DTOs;
using MindCareBooking.Application.Services.Interfaces;

namespace MindCareBooking.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IUnitOfWork _unitOfWork;
        public BookingService(IBookingRepository bookingRepository, IUnitOfWork unitOfWork)
        {
            _bookingRepository = bookingRepository;
            _unitOfWork = unitOfWork;
        }
        public Task<Result<BookingResponse>> CreateBookingAsync(Guid userId, CreateBookingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<Result> DeleteBookingAsync(Guid userId, Guid bookingId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<BookingResponse>>> GetBookingsByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}

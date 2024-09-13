using PracticeRestFulApiDemo.Models;

namespace PracticeRestFulApiDemo.Services
{
    public interface IBookingService
    {
        bool AddBooking(Details d);
        bool DeleteBooking(int id);
        List<Details> GetAllBookings();
        bool UpdateBooking(int id, Details obj);
    }
}
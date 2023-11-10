using System.Text;
using TratamentoExcecoes.Entities.Exceptions;

namespace TratamentoExcecoes.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            ThrowException(checkIn, checkOut);

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateReservation(DateTime checkIn, DateTime checkOut)
        {
            ThrowException(checkIn, checkOut);

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public void ThrowException(DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            else if (checkIn < DateTime.Now || checkOut < DateTime.Now)
            {
                throw new DomainException("Reservation dates for reservation or update must be future dates");
            }
        }

        public override string ToString()
        {
            StringBuilder strBiuld = new StringBuilder();
            strBiuld.Append("Room ");
            strBiuld.Append(RoomNumber);
            strBiuld.Append(", check-in: ");
            strBiuld.Append(CheckIn.ToString("dd/MM/yyyy"));
            strBiuld.Append(", cehck-out: ");
            strBiuld.Append(CheckOut.ToString("dd/MM/yyyy"));
            strBiuld.Append(", ");
            strBiuld.Append(Duration());
            strBiuld.AppendLine(" nights.");

            return strBiuld.ToString();
        }
    }
}
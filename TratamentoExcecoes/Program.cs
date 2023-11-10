using TratamentoExcecoes.Entities;
using TratamentoExcecoes.Entities.Exceptions;

Console.Clear();

try
{
    Console.Write("Room number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine(reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation:");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateReservation(checkIn, checkOut);
    Console.WriteLine(reservation);
}
catch (FormatException e)
{
    Console.WriteLine($"Error in format: {e.Message}");
}
catch (DomainException e)
{
    Console.WriteLine($"Error in reservation: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Unexpected error: {e.Message}");
}



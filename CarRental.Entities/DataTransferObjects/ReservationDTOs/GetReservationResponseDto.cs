namespace CarRental.Entities.DataTransferObjects.ReservationDTOs
{
    public record GetReservationResponseDto
    {
        public Guid Id { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public decimal TotalCost { get; init; }
    }
}

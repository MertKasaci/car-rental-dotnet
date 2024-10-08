namespace CarRental.Entities.DataTransferObjects.ReviewDTOs
{
    public record GetReviewResponseDto
    {
        public Guid Id { get; init; }
        public string Comment { get; init; }
        public int Rating { get; init; } // 1-5 arası bir değer
    }
}

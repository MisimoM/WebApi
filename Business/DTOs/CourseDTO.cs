namespace Business.DTOs
{
    public class CourseDTO
    {
        public required string ImgUrl { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public double Price { get; set; }
        public double? DiscountPrice { get; set; }
        public bool BestSeller { get; set; }
        public int Hours { get; set; }
        public int LikesCount { get; set; }
        public int LikePercentage { get; set; }
    }
}

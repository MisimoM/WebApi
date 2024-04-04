using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class CourseEntity
    {
        [Key]
        public string Id { get; set; } = null!;
        [Required]
        public string ImgUrl { get; set; } = null!;
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Author { get; set; } = null!;
        [Required]
        public double Price { get; set; }
        public double? DiscountPrice { get; set; }
        public bool BestSeller { get; set; }
        [Required]
        public int Hours { get; set; }
        [Required]
        public int LikesCount { get; set; }
        [Required]
        public int LikePercentage { get; set; }
    }
}

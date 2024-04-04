using Business.DTOs;
using Infrastructure.Entities;

namespace Business.Mapper
{
    public class CourseMapper
    {
        public static CourseEntity MapToEntity(CourseDTO dto)
        {
            return new CourseEntity
            {
                Id = Guid.NewGuid().ToString(),
                ImgUrl = dto.ImgUrl,
                Title = dto.Title,
                Author = dto.Author,
                Price = dto.Price,
                DiscountPrice = dto.DiscountPrice,
                BestSeller = dto.BestSeller,
                Hours = dto.Hours,
                LikesCount = dto.LikesCount,
                LikePercentage = dto.LikePercentage
            };
        }

        public static CourseDTO MapToDTO(CourseEntity entity)
        {
            return new CourseDTO
            {
                ImgUrl = entity.ImgUrl,
                Title = entity.Title,
                Author = entity.Author,
                Price = entity.Price,
                DiscountPrice = entity.DiscountPrice,
                BestSeller = entity.BestSeller,
                Hours = entity.Hours,
                LikesCount = entity.LikesCount,
                LikePercentage = entity.LikePercentage
            };
        }
    }
}

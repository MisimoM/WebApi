using Business.DTOs;
using Business.Mapper;
using Infrastructure.Entities;
using Infrastructure.Repositories;
using System.Diagnostics;

namespace Business.Services
{
    public class CourseService(CourseRepository courseRepository)
    {
        private readonly CourseRepository _courseRepository = courseRepository;

        public async Task CreateNewCourseAsync(CourseDTO courseDTO)
        {
            try
            {
                var courseEntity = CourseMapper.MapToEntity(courseDTO);
                await _courseRepository.AddAsync(courseEntity);
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }

        public async Task<List<CourseEntity>> GetAllCoursesAsync()
        {
            try
            {
                var courses = await _courseRepository.GetAllAsync();
                return courses;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }

        public async Task<bool> RemoveCourseAsync(string courseId)
        {
            try
            {
                var courseEntity = await _courseRepository.GetAsync(course => course.Id == courseId);

                if (courseEntity is not null)
                {
                    return await _courseRepository.DeleteAsync(course => course.Id == courseId);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return false;
        }
    }
}

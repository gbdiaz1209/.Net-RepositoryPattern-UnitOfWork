namespace lab.data.Repositories
{   
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;
    using lab.core.Domain;
    using lab.core.Repositories;   

    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(LabContext context) : base(context)
        {
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize)
        {
            return LabContext.Courses
                .Include(c => c.Authors)
                .OrderBy(c => c.Authors.Name)
                .Skip((pageIndex -1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return LabContext.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();           
        }
        public LabContext LabContext
        {
            get { return Context as LabContext; }
        }
    }
}

namespace lab.core.Repositories
{    
    using System.Collections.Generic;
    using core.Domain;

    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
        IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pagesize);
    }
}

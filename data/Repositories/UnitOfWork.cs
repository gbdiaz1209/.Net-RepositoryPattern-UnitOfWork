namespace lab.data.Repositories
{
    using lab.core.Repositories;
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LabContext _context;
        public UnitOfWork(LabContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
        }
        public ICourseRepository Courses { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
           
        }
      
    }
}

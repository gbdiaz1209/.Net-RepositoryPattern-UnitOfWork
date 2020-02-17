namespace ConsolePresentation
{
    using System;
    using lab.data;
    using lab.data.Repositories;
    using lab.core.Domain;

    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course
            {
                Title = "Azure",
                Description = "Azure Fundamentals",
                Author_Id = 1,
                FullPrice = 2,
                Level = 1
            };

            //IEnumerable<Course> TopSellingCourses;

            using (var unitOfWork = new UnitOfWork(new LabContext()))
            {
                //Create
                unitOfWork.Courses.Add(c);

                //Read
                //c = unitOfWork.Courses.Get(3);

                //Update                
                //c.Author_Id = 2;

                //Delete
                //unitOfWork.Courses.Remove(unitOfWork.Courses.Get(4));
                
                //unitOfWork.Complete();  

                //TopSellingCourses = unitOfWork.Courses.GetCoursesWithAuthors(1,1);
            }            
            
            //Console.WriteLine("Top Selling Courses:");
            //foreach (var course in TopSellingCourses)
            //{
            //    Console.WriteLine("Curso: " + c.Title + " - " + c.Description + "\nAutor: " + c.Authors.Name);
            //}

            Console.ReadLine();
        }
    }
}

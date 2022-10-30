using GraphqlSample.Models;

namespace GraphqlSample.Graphql
{
    public class Query
    {      
        public List<Student> GetStudentList()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                Id = 1,
                Name = "Leonardo",
                Number = 10,
                ClassRoom = new ClassRoom
                {
                    Id = 1,
                    Name = "A"
                }
            });
            students.Add(new Student
            {
                Id = 2,
                Name = "Donatello",
                Number = 20,
                ClassRoom = new ClassRoom
                {
                    Id = 1,
                    Name = "A"
                }
            });
            students.Add(new Student
            {
                Id = 3,
                Name = "Michalengelo",
                Number = 30,
                ClassRoom = new ClassRoom
                {
                    Id = 1,
                    Name = "A"
                }
            });
            students.Add(new Student
            {
                Id = 4,
                Name = "Raphael",
                Number = 40,
                ClassRoom = new ClassRoom
                {
                    Id = 1,
                    Name = "A"
                }
            });
            return students;
        }
            
        public Student GetSingleStudent()
        {
            return new Student
            {
                Id = 1,
                Name = "Leonardo",
                Number = 10,
                ClassRoom = new ClassRoom
                {
                    Id = 1,
                    Name = "A"
                }
            };
        }
    }
}

// See https://aka.ms/new-console-template for more information
using StudentSystem.App.Data;

var db = new StudentDbContext();

// 1.	Lists all students and their homework submissions. Display only their names and for each homework - content and content-type.
var studentsWithHomework = db.Students
    .Select(x =>
        new
        {
            x.Name,
            content = x.homeworks.Select(x =>
                    new
                    {
                        x.ContentType,
                        x.SubmissionDate
                    }
                )
        }
    );

foreach ( var student in studentsWithHomework )
{
    Console.WriteLine( student.Name );
    foreach ( var homework in student.content)
    {
        Console.WriteLine($"Content type: {homework.ContentType} SD {homework.SubmissionDate}");
    }
    Console.WriteLine("-------------------------");
}

// 2.List all courses with their corresponding resources. Display the course name and description and everything for each resource. Order the courses by start date (ascending), then by end date (descending).
var coursesWithRes = db.courses
    .Select(c =>
        new
        {
            c.Name,
            c.Description,
            c.StratDate,
            c.EndDate,
            resourse = c.Resources
        }
    )
    .OrderBy(c => c.StratDate)
    .ThenByDescending(c => c.EndDate);
    

foreach ( var course in coursesWithRes )
{
    Console.WriteLine($"{course.Name}: {course.Description} {course.StratDate} {course.EndDate}");
    foreach ( var resource in course.resourse)
    {
        Console.WriteLine ($"{resource.Name} id: {resource.Id} CId: {resource.CourseId}"); // add the other properties of a resource
    }
    Console.WriteLine("\n-------------------------\n");
}

/*db.Resources.AddRange(new List<Resource>
    {
    new Resource(11, "Python Basics Video", ResourceType.VIDEO, "https://example.com/video5", 5),
    new Resource(12, "JavaScript Fundamentals Presentation", ResourceType.PRESENTATION, "https://example.com/presentation4", 4),
    new Resource(13, "SQL Queries Document", ResourceType.DOCUMENT, "https://example.com/document4", 3),
    new Resource(14, "Java Advanced Video", ResourceType.VIDEO, "https://example.com/video6", 6),
    new Resource(15, "Algorithm Design Presentation", ResourceType.PRESENTATION, "https://example.com/presentation5", 5),
    new Resource(16, "Neural Networks Document", ResourceType.DOCUMENT, "https://example.com/document5", 9),
    new Resource(17, "iOS App Development Video", ResourceType.VIDEO, "https://example.com/video7", 7),
    new Resource(18, "Network Security Presentation", ResourceType.PRESENTATION, "https://example.com/presentation6", 8),
    new Resource(19, "Machine Vision Document", ResourceType.DOCUMENT, "https://example.com/document6", 6),
    new Resource(20, "Social Media Marketing Video", ResourceType.VIDEO, "https://example.com/video8", 10),
    new Resource(21, "Data Analysis Presentation", ResourceType.PRESENTATION, "https://example.com/presentation7", 7),
    new Resource(22, "Cloud Computing Document", ResourceType.DOCUMENT, "https://example.com/document7", 8),
    new Resource(23, "Robotics Video", ResourceType.VIDEO, "https://example.com/video9", 9),
    new Resource(24, "Cryptography Presentation", ResourceType.PRESENTATION, "https://example.com/presentation8", 10),
    new Resource(25, "Natural Language Processing Document", ResourceType.DOCUMENT, "https://example.com/document8", 9),
    new Resource(26, "Game Development Video", ResourceType.VIDEO, "https://example.com/video10", 10),
    new Resource(27, "E-commerce Strategies Presentation", ResourceType.PRESENTATION, "https://example.com/presentation9", 7),
    new Resource(28, "IoT Technologies Document", ResourceType.DOCUMENT, "https://example.com/document9", 8),
    new Resource(29, "Augmented Reality Video", ResourceType.VIDEO, "https://example.com/video11", 9),
    new Resource(30, "Blockchain Presentation", ResourceType.PRESENTATION, "https://example.com/presentation10", 10)
    }
    );

db.SaveChanges();*/

// 3.	List all courses with 3 or more resources. Order them by resources count (descending), then by start date (descending). Display only the course name and the resource count.
var MoreThanFive = db.courses
    .Select(c =>
        new
        {
            c.Name,
            c.StratDate,
            NumberOfresources = c.Resources.Count
        })
    .Where(c => c.NumberOfresources >= 3)
    .OrderByDescending(c => c.NumberOfresources)
    .ThenByDescending(c => c.StratDate);

foreach (var course in MoreThanFive)
{ Console.WriteLine($"{course.Name} Number of Resources: {course.NumberOfresources} "); }

Console.WriteLine("\n-------------------------\n");

// 4.	For each student, calculate the number of courses they have enrolled in, the total price of these courses and the average price per course for the student.
// Print the student name, number of courses, total price and average price. Order the results by total price (descending), then by number of courses (descending) and then by the student's name (ascending).

var StudentCourses = db.Students
    .Select(c =>
        new
        {
            c.Name,
            numberOfCourses = c.StudentCourses.Count,
            totalPrice = c.StudentCourses.Select(x => new { x.Course.price }).Sum(s => s.price),
            AvaragePrice = c.StudentCourses.Select(x => new { x.Course.price }).Average(s => s.price)
        })
    .OrderByDescending(c => c.totalPrice)
    .ThenByDescending (c => c.numberOfCourses)
    .ThenBy(c => c.Name);

foreach (var cour in StudentCourses)
{
    Console.WriteLine($"{cour.Name} Number of Courses: {cour.numberOfCourses} total price {cour.totalPrice} Avg: {cour.AvaragePrice}");
}
    
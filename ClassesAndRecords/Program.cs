var pluralsightCourse = new Course();
pluralsightCourse.Name = "Working with C# Records";
pluralsightCourse.Author = "Roland Guijt";

var classroomCourse = new CourseRecord(
    "Working with C# Records",
    "Roland Guijt"
    );

//Cloning
var anotherCourse = classroomCourse with { Name = "C# Getting Started", Author = "Kelly Lee" };
Console.WriteLine(anotherCourse.Name);
Console.WriteLine(anotherCourse.Author);

// Destructuring
var (name, author) = classroomCourse;
Console.WriteLine(name);
Console.WriteLine(author);

// Inheritance and Polymorphism
CourseRecord timedCourse = new TimedCourseRecord(
    "Working with C# Records",
    "Roland Guijt",
    Duration: 90
    );

var clonedCourse = timedCourse with { Name = "Inheritance and Polymorphism", Author = "John Taylor" };
var castCourse = (TimedCourseRecord)timedCourse;

Console.WriteLine(castCourse.Duration);

public class Course
{
    public string? Name { get; set; }
    public string? Author { get; set; }
}

public record CourseRecord(string Name, string Author);
public record TimedCourseRecord(string Name, string Author, int Duration): CourseRecord(Name, Author);

// Using a mix of positional and properties in the body
public record MixedCourseRecord(string Name)
{
    public MixedCourseRecord(string name, string author): this(name)
    {
        Author = author;
    }
    public string? Author { get; init; }
    public string Title
    {
        get
        {
            return $"{Name} - {Author}";
        }
    }

}



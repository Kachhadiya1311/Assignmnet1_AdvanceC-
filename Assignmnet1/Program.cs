using System;

public class Course
{
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    public string Description { get; set; }
    public string InstructorName { get; set; }
    public int NumberOfStudents { get; set; }

    public virtual string CourseType()
    {
        return "Base Course";
    }
}

public class DaytimeCourse : Course
{
    public int SectionNumber { get; set; }
    public string BlockNumber { get; set; }
    public string CertificateID { get; set; }

    public override string CourseType()
    {
        return "Daytime";
    }
}

public class EveningCourse : Course
{
    public string ContractorID { get; set; }
    public DateTime ContractEndDate { get; set; }

    public override string CourseType()
    {
        return "Evening";
    }
}

class Program
{
    static void Main(string[] args)
    {
        DaytimeCourse daytimeCourse = new DaytimeCourse
        {
            CourseName = "Intercultural",
            CourseCode = "CMSK01500",
            Description = "An introductory course on Multi Culture.",
            InstructorName = "Tetsu Nakashima",
            NumberOfStudents = 30,
            SectionNumber = 1000787,
            BlockNumber = "B1",
            CertificateID = "PP100-Y2"
        };

        Console.WriteLine("========Daytime Course Details:===========");
        Console.WriteLine($"Name: {daytimeCourse.CourseName}");
        Console.WriteLine($"Code: {daytimeCourse.CourseCode}");
        Console.WriteLine($"Description: {daytimeCourse.Description}");
        Console.WriteLine($"Instructor: {daytimeCourse.InstructorName}");
        Console.WriteLine($"Students: {daytimeCourse.NumberOfStudents}");
        Console.WriteLine($"Section: {daytimeCourse.SectionNumber}");
        Console.WriteLine($"Block: {daytimeCourse.BlockNumber}");
        Console.WriteLine($"Certificate ID: {daytimeCourse.CertificateID}");
        Console.WriteLine($"Course Type: {daytimeCourse.CourseType()}");

        Console.WriteLine();

        EveningCourse eveningCourse = new EveningCourse
        {
            CourseName = "Business Writing II",
            CourseCode = "PC19",
            Description = "All about formal writing.",
            InstructorName = "Lori Williams",
            NumberOfStudents = 20,
            ContractorID = "CVEN-9985",
            ContractEndDate = new DateTime(2025, 12, 31)
        };

        Console.WriteLine("=============Evening Course Details:============");
        Console.WriteLine($"Name: {eveningCourse.CourseName}");
        Console.WriteLine($"Code: {eveningCourse.CourseCode}");
        Console.WriteLine($"Description: {eveningCourse.Description}");
        Console.WriteLine($"Instructor: {eveningCourse.InstructorName}");
        Console.WriteLine($"Students: {eveningCourse.NumberOfStudents}");
        Console.WriteLine($"Contractor ID: {eveningCourse.ContractorID}");
        Console.WriteLine($"Contract End Date: {eveningCourse.ContractEndDate.ToShortDateString()}");
        Console.WriteLine($"Course Type: {eveningCourse.CourseType()}");
    }
}

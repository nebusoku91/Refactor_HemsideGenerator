using Refactor_HemsideGenerator.Classes;
using Refactor_HemsideGenerator.Interfaces;

namespace Refactor_HemsideGenerator;
class Program
{
    static void Main(string[] args)
    {
        string[] courses = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };
        string[] welcomeMessages = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };
        string className = "Klass A";

        IConsoleIO consoleIO = new ConsoleIO();
        ICourseGenerator courseGenerator = new CourseGenerator(courses);
        IWebsiteGenerator websiteGenerator = new WebsiteGenerator(consoleIO, welcomeMessages, className, courseGenerator);

        websiteGenerator.PrintPage();
    }
}





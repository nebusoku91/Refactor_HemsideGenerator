using Refactor_HemsideGenerator.Interfaces;

namespace Refactor_HemsideGenerator.Classes
{
    public class WebsiteGenerator : IWebsiteGenerator
    {
        readonly private IConsoleIO consoleIO;
        readonly private ICourseGenerator courseGenerator;
        readonly private string[] welcomeMessages;
        readonly private string className = "";

        public WebsiteGenerator(IConsoleIO consoleIO, string[] welcomeMessages, string className, ICourseGenerator courseGenerator)
        {
            this.consoleIO = consoleIO;
            this.welcomeMessages = welcomeMessages;
            this.className = className;
            this.courseGenerator = courseGenerator;
        }

        public void PrintPage()
        {
            PrintStart();
            PrintWelcome();
            PrintCourses();
            PrintEnd();
        }

        private void PrintStart()
        {
            consoleIO.PrintString("<!DOCTYPE html>\n<html>\n<body>\n<main>\n");
        }

        private void PrintWelcome()
        {
            consoleIO.PrintString($"<h1> Välkomna {this.className}! </h1>");

            foreach (var welcomeMessage in welcomeMessages)
            {
                consoleIO.PrintString($"\n<p><b> Meddelande: </b> {welcomeMessage} </p>");
            }
        }

        private void PrintCourses()
        {
            courseGenerator.TrimCourses();
            consoleIO.PrintString(courseGenerator.AddHTMLTags());
        }

        private void PrintEnd()
        {
            consoleIO.PrintString("</main>\n</body>\n</html>");
        }
    }
}









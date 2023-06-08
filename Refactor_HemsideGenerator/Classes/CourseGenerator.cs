using Refactor_HemsideGenerator.Interfaces;

namespace Refactor_HemsideGenerator.Classes
{
    public class CourseGenerator : ICourseGenerator
    {
        public string[] courses;

        public CourseGenerator(string[] Courses)
        {
            this.courses = Courses;
        }

        public string[] Courses { get { return this.courses; } }

        public void TrimCourses()
        {
            for (int i = 0; i < courses.Length; i++)
            {
                courses[i] = courses[i].Trim();
            }
        }

        public string AddHTMLTags()
        {
            string HTMLTaggedCourses = "";

            foreach (string course in courses)
            {
                HTMLTaggedCourses += "<p>" + course[0].ToString().ToUpper() + course.Substring(1).ToLower() + "</p>\n";
            }

            return HTMLTaggedCourses;
        }
    }
}

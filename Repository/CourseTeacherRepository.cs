using System.Linq;
using Comp4920_SAS.Common;
using Comp4920_SAS.Models;

namespace Comp4920_SAS.Repository
{
    public class CourseTeacherRepository
    {
        ResultProcess<CourseTeacher> result = new ResultProcess<CourseTeacher>();
        DataContext db = new DataContext();

        public Result<CourseTeacher> GetObjById(int id)
        {
            return result.GetT(db.CourseTeachers.SingleOrDefault(t => t.CourseId == id));
        }
    }
}
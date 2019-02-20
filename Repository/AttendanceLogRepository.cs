using System.Collections.Generic;
using System.Linq;
using Comp4920_SAS.Common;
using Comp4920_SAS.Models;

namespace Comp4920_SAS.Repository
{
    public class AttendanceLogRepository
    {
        private static DataContext db = new DataContext();
        ResultProcess<AttendanceLog> result = new ResultProcess<AttendanceLog>();

        public Result<List<AttendanceLog>> GetListByCourseStudentId(int id)
        {
            return result.GetListResult(db.AttendanceLogs.Where(t => t.CourseStudentId == id).ToList());
        }
    }
}
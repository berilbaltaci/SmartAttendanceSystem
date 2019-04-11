using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Comp4920_SAS.Common;
using Comp4920_SAS.Models;
using Microsoft.AspNetCore.Http;

namespace Comp4920_SAS.Repository
{
    public class AttendanceLogRepository
    {
        private static DataContext db = new DataContext();
        ResultProcess<AttendanceLog> result = new ResultProcess<AttendanceLog>();

        public Result<int> Insert(List<CourseStudent> gelenStudentList, List<CourseStudent> gelmeyenStudentList, User user)
        {
            Teacher tchr = db.Teachers.FirstOrDefault(t => t.UserId == user.UserId);
            foreach (var item in gelenStudentList)
            {
                //(int)DateTime.Now.DayOfWeek
                AttendanceLog al = new AttendanceLog();
                al.TeacherId = tchr.TeacherId;
                al.CourseStudentId = item.Id;
                al.Date = DateTime.Now;
                al.IsOnline=1;
                al.IsFingerprint = 0;
                al.IsSchoolCard = 0;
                db.AttendanceLogs.Add(al);
            }

            foreach (var item in gelmeyenStudentList)
            {
                AttendanceLog al = new AttendanceLog();
                al.TeacherId = tchr.TeacherId;
                al.CourseStudentId = item.Id;
                al.Date = DateTime.Now;
                al.IsOnline=0;
                al.IsFingerprint = 0;
                al.IsSchoolCard = 0;
                db.AttendanceLogs.Add(al);
                CourseStudent cs =db.CourseStudents.FirstOrDefault(t=>t.Id==al.CourseStudentId);
                cs.AttendanceSum=cs.AttendanceSum+1;
                Course getCourse = db.Courses.FirstOrDefault(t => t.Id == cs.CourseId);
                if (cs.AttendanceSum < (getCourse.LecturePerWeek * 14 * 30 / 100)-2)
                {
                    cs.AttendanceSituation = 1;
                }else if ((getCourse.LecturePerWeek * 14 * 30 / 100) - 2 <= cs.AttendanceSum &&
                          cs.AttendanceSum <= (getCourse.LecturePerWeek * 14 * 30 / 100))
                {
                    cs.AttendanceSituation = 2;
                }
                else if((getCourse.LecturePerWeek * 14 * 30 / 100)<cs.AttendanceSum)
                {
                    cs.AttendanceSituation = 3;
                }
                db.CourseStudents.Update(cs);
            }
            return result.GetResult(db);
        }
    }
}
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

        public Result<List<AttendanceLog>> GetListByCourseStudentId(int id)
        {
            return result.GetListResult(db.AttendanceLogs.Where(t => t.CourseStudentId == id).ToList());
        }
//        public Result<int> Update(List<AttendanceLog> attendanceLogList)
//        {
//            foreach (var item in attendanceLogList)
//            {
////                AttendanceLog al = db.AttendanceLogs.SingleOrDefault(t => t.LogId == item.LogId);
////                al.CourseStudentId = item.CourseStudentId;
////                al.Date = DateTime.Now.ToString();
////                al.IsOnline = 1;
////                al.IsFingerprint = 0;
////                al.IsSchoolCard = 0;
//            }
//            return result.GetResult(db);
//        }
        public Result<int> Insert(List<CourseStudent> newCourseStudentList, User user)
        {
            Teacher tchr = db.Teachers.FirstOrDefault(t => t.UserId == user.UserId);
            foreach (var item in newCourseStudentList)
            {
                //(int)DateTime.Now.DayOfWeek
                AttendanceLog al = new AttendanceLog();
                al.TeacherId = tchr.TeacherId;
                al.CourseStudentId = item.Id;
                al.Date = DateTime.Now.ToString();
                al.IsOnline=1;
                al.IsFingerprint = 0;
                al.IsSchoolCard = 0;
                db.AttendanceLogs.Add(al);
            }
            return result.GetResult(db);
        }
    }
}
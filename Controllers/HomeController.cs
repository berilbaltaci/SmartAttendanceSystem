using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Comp4920_SAS.Models;
using Comp4920_SAS.Repository;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;


namespace Comp4920_SAS.Controllers
{
    
    public class HomeController : Controller
    {
         private DataContext db=new DataContext();
         AttendanceLogRepository alr=new AttendanceLogRepository();
         CourseTeacherRepository ctr=new CourseTeacherRepository();
         InstanceResult<List<AttendanceLog>> result = new InstanceResult<List<AttendanceLog>>();

        public IActionResult Index()
        {
            var getUser = HttpContext.Session.GetObject<User>("user");
            if (HttpContext.Session.GetObject<User>("user") == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Detail(int id)
        {
            var getUser = HttpContext.Session.GetObject<User>("user");
            if (getUser == null)
            {
                return RedirectToAction("Login");
            }
            List<AttendanceLog> al = db.AttendanceLogs.Where(t => t.CourseStudentId == id).ToList();
            ViewBag.crstdId = id;
            return View(al);
        }
        public IActionResult CourseList(int id)
        {
            User getUser = HttpContext.Session.GetObject<User>("user");
            if (getUser == null)
            {
                return RedirectToAction("Login");
            }
            Teacher getTeacher = db.Teachers.FirstOrDefault(t => t.UserId == getUser.UserId);
            Course getCourse=new Course();
            
            List<CourseTeacher> getCourseTeacherList = db.CourseTeachers.Where(t => t.TeacherId == getTeacher.TeacherId).ToList();
            foreach (var item in getCourseTeacherList)
            {
                if (item.CourseId == id)
                {
                    getCourse=db.Courses.FirstOrDefault(t=>t.Id==id);            

                }
            }
            List<CourseStudent> getCourseStudentList=db.CourseStudents.Where(t=>t.CourseId==getCourse.Id).ToList();
            return View(getCourseStudentList);
        }
        [HttpGet]
        public IActionResult AttendanceEntryList(int id)
        {
            var getUser = HttpContext.Session.GetObject<User>("user");
            if (getUser == null)
            {
                return RedirectToAction("Login");
            }
            ViewBag.CourseId = id;
            return View();
        }

        [HttpPost]
        public IActionResult AttendanceEntryList(List<string> devam, int id)
        {
            User getUser = HttpContext.Session.GetObject<User>("user");
            if (getUser == null)
            {
                return RedirectToAction("Login");
            }
            int i = 0;
            var courseId = id;
            ViewBag.CourseId = courseId;
            Teacher getTeacher = db.Teachers.FirstOrDefault(t => t.UserId == getUser.UserId);            
            List<CourseTeacher> getCourseTeacherList = db.CourseTeachers.Where(t => t.TeacherId == getTeacher.TeacherId).ToList();
    
            Course getCourse=new Course();
            foreach (var item in getCourseTeacherList)
            {
                if (item.CourseId == id)
                {
                    getCourse=db.Courses.FirstOrDefault(t=>t.Id==item.CourseId);
                    break;
                }
            }
            List<CourseStudent> courseStudentList=db.CourseStudents.Where(t=>t.CourseId==getCourse.Id).ToList();  
            List<CourseStudent> gelenStudentList=new List<CourseStudent>();            
            List<CourseStudent> gelmeyenStudentList=new List<CourseStudent>();

            foreach (var item in devam)
            {
                if (item.Equals("Geldi"))
                {
                    gelenStudentList.Add(courseStudentList[i]);
                }else if (item.Equals("Gelmedi"))
                {
                    String date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                    AttendanceLog alSearch = db.AttendanceLogs.FirstOrDefault(t => t.CourseStudentId == courseStudentList[i].Id && t.Date==date);
                    if (alSearch == null)
                    {
                        gelmeyenStudentList.Add(courseStudentList[i]);
                        courseStudentList[i].AttendanceSum++;
                    }
                }
                i++;
            }
            result.resultint = alr.Insert(gelenStudentList, gelmeyenStudentList, getUser);
            if (result.resultint.IsSuccessed)
            {
                return RedirectToAction("AttendanceEntryList");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Login(User user)
        {
            using (DataContext db = new DataContext())
            {
                var userDetails = db.Users.FirstOrDefault(t => t.SchoolId.Equals(user.SchoolId ) && t.Password == user.Password);
                if (userDetails == null)
                {
                    ViewBag.HataMesaj = "E-mail veya şifre hatalı.";
                    return RedirectToAction("Login");
                }
                else
                {
                    HttpContext.Session.SetObject("user", userDetails);
                    var getUser = HttpContext.Session.GetObject<User>("user");

                    return RedirectToAction("Index");
                }
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
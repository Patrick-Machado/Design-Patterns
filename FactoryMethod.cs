using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{
    //referencia: https://www.codeproject.com/Articles/492900/From-No-Factory-to-Factory-Method
    // acessado em 24/5/2019
    class FactoryMethod
    {
    }
    public class CourseFactory
    {
        /*
        public static AbstractCourse CreateCourse(string ScheduleType)
        {
            AbstractCourse objCourse = null;
            switch (ScheduleType)
            {
                case "CN":
                    objCourse = new CNetCourse();
                    break;
                case "CJ":
                    objCourse = new CJavaCourse();
                    break;
                case "CB":
                    objCourse = new CBICourse();
                    break;
                case "OJ":
                    objCourse = new OJavaCourse();
                    break;
                case "ON":
                    objCourse = new ONetCourse();
                    break;
            }
            objCourse.CreateCourseMaterial();
            objCourse.CreateSchedule();
            return objCourse;
        }
    }
    public abstract class AbstractCourseFactory
    {
        public AbstractCourse CreateCourse(string ScheduleType)
        {
            AbstractCourse objCourse = this.GetCourse(ScheduleType);
            objCourse.CreateCourseMaterial();
            objCourse.CreateSchedule();
            return objCourse;
        }
        public abstract AbstractCourse GetCourse(string ScheduleType);
    }
    public abstract class AbstractCourseFactory
    {
        public AbstractCourse CreateCourse(string ScheduleType)
        {
            AbstractCourse objCourse = this.GetCourse(ScheduleType);
            objCourse.CreateCourseMaterial();
            objCourse.CreateSchedule();
            return objCourse;
        }
        public abstract AbstractCourse GetCourse(string ScheduleType);
    }
    public class CorporateCourseFactory : AbstractCourseFactory
    {
        public override AbstractCourse GetCourse(string ScheduleType)
        {
            switch (ScheduleType)
            {
                case "N":
                    return new CNetCourse();
                case "J":
                    return new CJavaCourse();
                default:
                    return null;
            }
        }
    }
    public class OnlineCourseFactory : AbstractCourseFactory
    {
        public override AbstractCourse GetCourse(string ScheduleType)
        {
            switch (ScheduleType)
            {
                case "N":
                    return new ONetCourse();
                case "J":
                    return new OJavaCourse();
                default:
                    return null;
            }
        }*/
    }
}

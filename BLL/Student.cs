using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.ExceptionClass;
using System.Runtime.Serialization;

namespace BLL
{
    public class Student : Human
    {
        int сourse;
        string studentID, diploma;
        double averageMark;
        public Student()
        {
        }
        public int Course
        {
            get
            {
                return сourse;
            }
            set
            {
                if (ExceptionsCheck.Course(value) == true)
                {
                    сourse = value;
                }
                else
                {
                    throw new CatchExceptions("Курс введено неправильно!");
                }
            }
        }
        public string StudentID
        {
            get { return studentID; }
            set
            {

                if (ExceptionsCheck.StudentID.IsMatch(value) == true)
                {
                    studentID = value;
                }
                else
                {
                    throw new CatchExceptions("Неправильний ID");
                }
            }
        }

        public double AverageMark
        {
            get
            {
                return averageMark;
            }
            set
            {
                if (ExceptionsCheck.AverageMark(value) == true)
                {
                    averageMark = value;
                }
                else
                {
                    throw new CatchExceptions("Оцінку введено неправильно!");
                }
            }
        }
        public string Diploma
        {
            get { return diploma; }
            set
            {
                if(Course >= 4)
                { 
                    if (ExceptionsCheck.Diploma(value) == true)
                    {
                        diploma = value;
                    }
                    else
                    {
                        throw new CatchExceptions("Тип диплому введено неправильно!");
                    } 
                }
                else
                {
                    throw new CatchExceptions("Тип диплому введено неправильно!");
                }
            }
        }
        
    }
}


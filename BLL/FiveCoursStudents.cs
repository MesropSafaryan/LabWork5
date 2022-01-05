using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class FiveCoursStudents
    {
        public static bool CheckStudent(this Student student)
        {
            if (student.Sex == "жіноча" && student.Course == 5 && (student.AverageMark >= 4.4 && student.AverageMark <= 5))
            {
                return true;
            }
            return false;
        }
    }
}

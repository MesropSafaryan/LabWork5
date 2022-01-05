using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BLL.ExceptionClass
{
    public static class ExceptionsCheck
    {
        public static readonly Regex IdentificationCode = new Regex("[0-9]{10}");
        public static bool Sex(string sex)
        {
            sex = sex.ToLower();
            if (sex == "чоловіча" || sex == "жіноча")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Coocking(string coock)
        {
            coock = coock.ToLower();
            if (coock == "так" || coock == "ні")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static readonly Regex StudentID = new Regex("[А-ЯІЇЙ]{2}[0-9]{8}");
        public static bool Course(int course)
        {
            if (course > 0 && course < 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool AverageMark(double mark)
        {
            if (mark > 5)
            {
                return false;
            }
            else if (mark < 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool Diploma(string typeOfDiploma)
        {
            if(typeOfDiploma == "з відзнакою" || typeOfDiploma == "звичайний")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool EquipmentForEntertainment(string equipment)
        {
            if (equipment == "в наявності" || equipment == "немає")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

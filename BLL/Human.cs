using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.ExceptionClass;

namespace BLL
{
    [Serializable]
    public abstract class Human
    {
        string sex, identificationCode, coocking, equipmentForEntertainment;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentificationCode
        {
            get
            {
                return identificationCode;
            }
            set
            {
                if (ExceptionsCheck.IdentificationCode.IsMatch(value))
                {
                    identificationCode = value;
                }
                else
                {
                    throw new CatchExceptions("Код введено невірно");
                }
            }
        }
        public string Sex
        {
            get { return sex; }
            set
            {
                if (ExceptionsCheck.Sex(value))
                {
                    sex = value;
                }
                else
                {
                    throw new CatchExceptions("Стать введено неправильно!");
                }
            }
        }
        public string Coocking
        {
            get { return coocking; }
            set
            {
                if (ExceptionsCheck.Coocking(value))
                {
                    coocking = value;
                }
                else
                {
                    throw new CatchExceptions("Неправильно введена інформація");
                }
            }
        }
        public string EquipmentForEntertainment
        {
            get { return equipmentForEntertainment; }
            set
            {
                if (ExceptionsCheck.EquipmentForEntertainment(value) == true)
                {
                    equipmentForEntertainment = value;
                }
                else
                {
                    throw new CatchExceptions("Не правильний ввід! Введіть \"в наявності\" чи \"немає\"");
                }
            }
        }
    }
}

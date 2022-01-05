using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using BLL.ExceptionClass;

namespace LabWork5.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StudentsCharacteristicsCheck()
        {
            Student student = new Student();
            student.Name = "Віталій";
            student.Surname = "Цаль";
            student.Sex = "чоловіча";
            student.IdentificationCode = "6578539045";
            student.StudentID = "АА01234567";
            student.Course = 4;
            student.AverageMark = 4.1;
            student.Coocking = "так";
            student.Diploma = "звичайний";
            student.EquipmentForEntertainment = "немає";
            string name = "Віталій";
            string surname = "Цаль";
            string sex = "чоловіча";
            string identificationCode = "6578539045";
            string studentID = "АА01234567";
            int course = 4;
            double averageMark = 4.1;
            string coocking = "так";
            string diploma = "звичайний";
            string equipmentForEntertainment = "немає";
            if (student.Name == name && student.Surname == surname && student.Sex == sex && student.IdentificationCode == identificationCode &&
                student.StudentID == studentID && student.Course == course && student.AverageMark == averageMark && student.Coocking == coocking &&
                student.Diploma == diploma && student.EquipmentForEntertainment == equipmentForEntertainment)
            {
                Assert.IsTrue(true);
            }
            else
            {
                throw new Exception();
            }
        }
        [TestMethod]
        public void StorytellerCharacteristicsCheck()
        {
            Storyteller stor = new Storyteller();
            stor.Name = "Віталій";
            stor.Surname = "Цаль";
            stor.Sex = "чоловіча";
            stor.IdentificationCode = "6578539045";
            stor.StoryTellLevel = "хороші";
            stor.Coocking = "так";
            stor.EquipmentForEntertainment = "немає";
            string name = "Віталій";
            string surname = "Цаль";
            string sex = "чоловіча";
            string identificationCode = "6578539045";
            string coocking = "так";
            string equipmentForEntertainment = "немає";
            string storyTellLevel = "хороші";
            if (stor.Name == name && stor.Surname == surname && stor.Sex == sex && stor.IdentificationCode == identificationCode &&
                 stor.Coocking == coocking && stor.StoryTellLevel == storyTellLevel && stor.EquipmentForEntertainment == equipmentForEntertainment)
            {
                Assert.IsTrue(true);
            }
            else
            {
                throw new Exception();
            }
        }
        [TestMethod]
        public void DentistCharacteristicsCheck()
        {
            Dentist dent = new Dentist();
            dent.Name = "Віталій";
            dent.Surname = "Цаль";
            dent.Sex = "чоловіча";
            dent.IdentificationCode = "6578539045";
            dent.DentistryLevel = "хороші";
            dent.Coocking = "так";
            dent.EquipmentForEntertainment = "немає";
            string name = "Віталій";
            string surname = "Цаль";
            string sex = "чоловіча";
            string identificationCode = "6578539045";
            string coocking = "так";
            string equipmentForEntertainment = "немає";
            string dentistryLevel = "хороші";
            if (dent.Name == name && dent.Surname == surname && dent.Sex == sex && dent.IdentificationCode == identificationCode &&
                 dent.Coocking == coocking && dent.DentistryLevel == dentistryLevel && dent.EquipmentForEntertainment == equipmentForEntertainment)
            {
                Assert.IsTrue(true);
            }
            else
            {
                throw new Exception();
            }
        }
        [TestMethod]
        public void FiveCoursStudentsCheck()
        {
            Student student = new Student();
            student.Name = "Оксака";
            student.Surname = "Кравчук";
            student.Sex = "жіноча";
            student.IdentificationCode = "6578539045";
            student.StudentID = "АА01234567";
            student.Course = 5;
            student.AverageMark = 4.9;
            student.Coocking = "так";
            student.Diploma = "звичайний";
            student.EquipmentForEntertainment = "немає";
            if (student.CheckStudent() == true)
            {
                Assert.IsTrue(true);
            }
            else
            {
                throw new Exception();
            }
        }
        [TestMethod]
        public void FiveCoursExStudentsCheck()
        {
            Student student = new Student();
            student.Name = "Оксака";
            student.Surname = "Кравчук";
            student.Sex = "жіноча";
            student.IdentificationCode = "6578539045";
            student.StudentID = "АА01234567";
            student.Course = 4;
            student.AverageMark = 4.9;
            student.Coocking = "так";
            student.Diploma = "звичайний";
            student.EquipmentForEntertainment = "немає";
            if (student.CheckStudent() == true)
            {
                throw new Exception();               
            }
            else
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void StudentsSexExceptionsCheck()
        {
            Student student = new Student();
            try
            {
                student.Sex = "dssvd";
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void StudentsIdentificationCodeExceptionsCheck()
        {
            Student student = new Student();
            try
            {
                student.IdentificationCode = "dssvd";
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void StudentsStudentIDExceptionsCheck()
        {
            Student student = new Student();
            try
            {
                student.StudentID = "dssvd";
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void StudentsCourseExceptionsCheck()
        {
            Student student = new Student();
            try
            {
                student.Course = 10000;
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void StudentsAverageMarkExceptionsCheck()
        {
            Student student = new Student();
            try
            {
                student.AverageMark = 10000;
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void StudentsAverageMarkExceptionsCheck2()
        {
            Student student = new Student();
            try
            {
                student.AverageMark = -1;
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void StudentsCoockingExceptionsCheck()
        {
            Student student = new Student();
            try
            {
                student.Coocking = "adsa";
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void StudentsDiplomaExceptionsCheck()
        {
            Student student = new Student();
            try
            {
                student.Course = 5;
                student.Diploma = "12";
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void StudentsDiplomaExceptionsCheck2()
        {
            Student student = new Student();
            try
            {
                student.Course = 3;
                student.Diploma = "12";
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void StudentsEquipmentForEntertainmentExceptionsCheck()
        {
            Student student = new Student();
            try
            {
                student.EquipmentForEntertainment = "adsa";
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL.Serialization;
using DAL.Serialization.Interface;
using EntityService;
using EntityService.Interface;

namespace MainMenu
{
    public static class Menu
    {
        static private List<Student> students = new List<Student>();
        static private List<Storyteller> storytellers = new List<Storyteller>();
        static private List<Dentist> dentists = new List<Dentist>();
        static private IDataFilling<List<Student>> studentDataProvider;
        static private IDataFilling<List<Storyteller>> storytellerDataProvider;
        static private IDataFilling<List<Dentist>> dentistDataProvider;
        static private IEntityService<List<Student>> StudentObj;
        static private IEntityService<List<Storyteller>> StorytellerObj;
        static private IEntityService<List<Dentist>> DentistObj;
        static private List<Student> StudentsDeserialize;
        static private List<Storyteller> StorytellerDeserialize;
        static private List<Dentist> DentistDeserialize;
        static Menu()
        {
            //serviseList = new EntityService<object>(listXML);
        }
        static public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
        static public List<Storyteller> Storytellers
        {
            get { return storytellers; }
            set { storytellers = value; }
        }
        static public List<Dentist> Dentists
        {
            get { return dentists; }
            set { dentists = value; }
        }
        private static void StartMenu()
        {
            Console.Clear();
            Console.WriteLine("Виберіть операцію:\n1. Ввести дані;\n2. Сериалізувати дані; " +
                "\n3. Десериалізувати дані " +
                "\n4. Дізнатись кількість студенток-відмінниць 5 курсу; \n5. Вийти;");
        }
        private static string Choice()
        {
            string c = Console.ReadLine();
            return c;
        }
        private static void StudentDataInput()
        {
            for (int i = 0; i < 1;)
            {
                Student stud = new Student();

                Console.WriteLine("Студент:");
                Console.Write("Введіть ім'я: ");
                stud.Name = Console.ReadLine();
                Console.Write("Введіть прізвище: ");
                stud.Surname = Console.ReadLine();
                while (true)
                {
                    try
                    {
                        Console.Write("Введіть стать (чоловіча або жіноча): ");
                        stud.Sex = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильний ввід. Спробуйте ще раз");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Введіть Ідентифікаційний номер: ");
                        stud.IdentificationCode = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильно введена інформація. Введіть Ідентифікаційний номер:");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Введіть номер курсу: ");
                        string a = Console.ReadLine();
                        stud.Course = Convert.ToInt32(a);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильно введена інформація. Введіть курс ще раз:");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Введіть номер студентського квитка: ");
                        stud.StudentID = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильно введена інформація. Введіть номер студентського квитка ще раз:");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Введіть середню оцінку (по 5-бальній шкалі): ");
                        string a = Console.ReadLine();
                        stud.AverageMark = Convert.ToDouble(a);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильно введена інформація. Введіть середню оцінку ще раз");
                    }
                }
                while (true)
                {
                    if (stud.Course >= 4)
                    {
                        Console.Write("Чи є у його(її) диплом?: ");
                        if (Console.ReadLine() == "так")
                        {
                            try
                            {
                                Console.Write("Який диплом? (з відзнакою/звичайний): ");
                                stud.Diploma = Console.ReadLine();
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Неправильний ввід. Спробуйте ще раз");
                            }
                        }
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Введіть чи вміє він(вона) гарно готувати:");
                        stud.Coocking = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильно введена інформація. Введіть так, або ні");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Чи є у його(її) обладнання для розважання дітей?: ");
                        stud.EquipmentForEntertainment = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильний ввід. Спробуйте ще раз");
                    }
                }
                Students.Add(stud);
                Console.Write("Бажаєте ввести дані ще одного студента?: ");
                for (int j = 0; j < 1;)
                {
                    string a = Console.ReadLine();
                    if (a == "ні")
                    {
                        Console.Clear();
                        j++;
                        i++;
                        StartMenu();
                    }
                    else if (a == "так")
                    {
                        Console.Clear();
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Неправильно введені дані. Введіть \"так \" або \"ні\"");
                    }
                }
                //i++;
            }
        }
        private static void StorytellerDataInput()
        {
            for (int i = 0; i < 1;)
            {
                Storyteller stor = new Storyteller();
                //list.Add(stor);
                Console.WriteLine("Оповідач:");
                Console.WriteLine("Введіть ім'я:");
                stor.Name = Console.ReadLine();
                Console.WriteLine("Введіть прізвище:");
                stor.Surname = Console.ReadLine();
                while (true)
                {
                    try
                    {
                        Console.Write("Введіть стать (чоловіча або жіноча): ");
                        stor.Sex = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильний ввід. Спробуйте ще раз");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Введіть рівень навичок росказування історій:");
                        stor.StoryTellLevel = Console.ReadLine();
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Неправильно введена інформація. Введіть рівень навичок росказування історій ще раз:");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Введіть Ідентифікаційний номер: ");
                        stor.IdentificationCode = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильно введена інформація. Введіть Ідентифікаційний номер:");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Введіть чи вміє він(вона) гарно готувати:");
                        stor.Coocking = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильно введена інформація. Введіть так, або ні");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Чи є у його(її) обладнання для розважання дітей?: ");
                        stor.EquipmentForEntertainment = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильний ввід. Спробуйте ще раз");
                    }
                }
                Storytellers.Add(stor);
                Console.WriteLine("Бажаєте ввести дані ще одного оповідача?");
                for (int j = 0; j < 1;)
                {
                    string a = Console.ReadLine();
                    if (a == "ні")
                    {
                        Console.Clear();
                        j++;
                        i++;
                        StartMenu();
                    }
                    else if (a == "так")
                    {
                        Console.Clear();
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Неправильно введені дані. Введіть \"так \" або \"ні\"");
                    }
                }

            }
        }
        private static void DentistDataInput()
        {
            for (int i = 0; i < 1;)
            {
                Dentist dent = new Dentist();
                //list.Add(dent);
                Console.WriteLine("Дантист:");
                Console.WriteLine("Введіть ім'я:");
                dent.Name = Console.ReadLine();
                Console.WriteLine("Введіть прізвище:");
                dent.Surname = Console.ReadLine();
                while (true)
                {
                    try
                    {
                        Console.Write("Введіть стать (чоловіча або жіноча): ");
                        dent.Sex = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильний ввід. Спробуйте ще раз");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Введіть Ідентифікаційний номер: ");
                        dent.IdentificationCode = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильно введена інформація. Введіть Ідентифікаційний номер:");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Введіть рівень навичок лікування зубів:");
                        dent.DentistryLevel = Console.ReadLine();
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Неправильно введена інформація. Введіть рівень навичок росказування історій ще раз:");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Введіть чи вміє він(вона) гарно готувати:");
                        dent.Coocking = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильно введена інформація. Введіть так, або ні");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Чи є у його(її) обладнання для розважання дітей?: ");
                        dent.EquipmentForEntertainment = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неправильний ввід. Спробуйте ще раз");
                    }
                }
                Console.WriteLine("Бажаєте ввести дані ще одного дантиста?");
                for (int j = 0; j < 1;)
                {
                    string a = Console.ReadLine();
                    if (a == "ні")
                    {
                        Console.Clear();
                        j++;
                        i++;
                        StartMenu();
                    }
                    else if (a == "так")
                    {
                        Console.Clear();
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Неправильно введені дані. Введіть \"так \" або \"ні\"");
                    }
                }

            }
        }
        private static void OutputType1()
        {
            Console.WriteLine("Виберіть чиї дані ви хочете ввести:\n1. Студент; \n2. Оповідач; \n3. Дантист; \n4. Перейти до основного меню");
            for (int i = 0; i < 1;)
            {
                switch (Choice())
                {
                    case ("1"):
                        {
                            StudentDataInput();
                            i++;
                            break;
                        }
                    case ("2"):
                        {
                            StorytellerDataInput();
                            i++;
                            break;
                        }
                    case ("3"):
                        {
                            DentistDataInput();
                            i++;
                            break;
                        }
                    case ("4"):
                        {
                            StartMenu();
                            i++;
                            break;
                        }
                    default:
                        Console.WriteLine("Неправильно введені дані. Введіть цифру від 1 до 4");
                        break;
                }
            }
        }
        private static void SerializingDataStudent()
        {
            if (Students != null)
            {
                studentDataProvider = new SerializeXML<List<Student>>(@"D:\vs project\LabWorkNo3Pt2\LabWork3.2\DLL\xmlListStudent.xml");
                StudentObj = new EntityService<List<Student>>(studentDataProvider);
                StudentObj.AddNewData(Students);
                Console.WriteLine("Дані про тип Student успішно серіалізовані.");
            }
        }
        private static void SerializingDataStoryteller()
        {
            if (Storytellers != null)
            {
                storytellerDataProvider = new SerializeXML<List<Storyteller>>(@"D:\vs project\LabWorkNo3Pt2\LabWork3.2\DLL\xmlListStoryteller.xml");
                StorytellerObj = new EntityService<List<Storyteller>>(storytellerDataProvider);
                StorytellerObj.AddNewData(Storytellers);
                Console.WriteLine("Дані про тип Storyteller успішно серіалізовані.");
            }
        }
        private static void SerializingDataDentist()
        {
            if (Dentists != null)
            {
                dentistDataProvider = new SerializeXML<List<Dentist>>(@"D:\vs project\LabWorkNo3Pt2\LabWork3.2\DLL\xmlListDentist.xml");
                DentistObj = new EntityService<List<Dentist>>(dentistDataProvider);
                DentistObj.AddNewData(Dentists);
                Console.WriteLine("Дані про тип Dentists успішно серіалізовані.");
            }
        }
        private static void ListMenuDeserializeStudent()
        {
            if (StudentObj != null)
            {
                new EntityService<List<Student>>(studentDataProvider);
                StudentsDeserialize = StudentObj.GetData();
                if (StudentsDeserialize != null)
                {
                    foreach (var stud in StudentsDeserialize)
                    {
                        Console.WriteLine("Студенти:");
                        Console.WriteLine("Ім'я: " + stud.Name);
                        Console.WriteLine("Прізвище: " + stud.Surname);
                        Console.WriteLine("Стать: " + stud.Sex);
                        Console.WriteLine("Ідентифікаційний код: " + stud.IdentificationCode);
                        Console.WriteLine("Студентський квиток: " + stud.StudentID);
                        Console.WriteLine("Курс: " + stud.Course);
                        Console.WriteLine("Середня оцінка: " + stud.AverageMark);
                        if (stud.Diploma == null)
                        {
                            Console.WriteLine("Диплом відсутній");
                        }
                        else
                        {
                            Console.WriteLine("Тип диплому: " + stud.Diploma); 
                        }
                        Console.WriteLine("Чи вміє гарно готувати?: " + stud.Coocking);
                        Console.Write("Чи вміє розважати дітеЙ?: ");
                        if(stud.EquipmentForEntertainment == "в наявності")
                        {
                            Console.WriteLine("так");
                        }
                        else
                        {
                            Console.WriteLine("ні");
                        }
                        Console.WriteLine("_________________________________________________\n");
                    }
                }
            }
        }
        private static void ListMenuDeserializeStoryteller()
        {
            if (StorytellerObj != null)
            {
                StorytellerObj = new EntityService<List<Storyteller>>(storytellerDataProvider);
                StorytellerDeserialize = StorytellerObj.GetData();
                if (StorytellerDeserialize != null)
                {
                    foreach (var stor in StorytellerDeserialize)
                    {
                        Console.WriteLine("Оповідачі:");
                        Console.WriteLine("Ім'я: " + stor.Name);
                        Console.WriteLine("Прізвище: " + stor.Surname);
                        Console.WriteLine("Стать: " + stor.Sex);
                        Console.WriteLine("Ідентифікаційний код: " + stor.IdentificationCode);
                        Console.WriteLine("Навички розповідати історії: " + stor.StoryTellLevel);
                        Console.WriteLine("Чи вміє гарно готувати?: " + stor.Coocking);
                        Console.Write("Чи вміє розважати дітеЙ?: ");
                        if (stor.EquipmentForEntertainment == "в наявності")
                        {
                            Console.WriteLine("так");
                        }
                        else
                        {
                            Console.WriteLine("ні");
                        }
                        Console.WriteLine("_________________________________________________\n");
                    }
                }
            }
        }
        private static void ListMenuDeserializeDentist()
        {
            if (DentistObj != null)
            {
                DentistObj = new EntityService<List<Dentist>>(dentistDataProvider);
                DentistDeserialize = DentistObj.GetData();
                if (DentistDeserialize != null)
                {
                    foreach (var dent in DentistDeserialize)
                    {
                        Console.WriteLine("Дантисти:");
                        Console.WriteLine("Ім'я: " + dent.Name);
                        Console.WriteLine("Прізвище: " + dent.Surname);
                        Console.WriteLine("Стать: " + dent.Sex);
                        Console.WriteLine("Ідентифікаційний код: " + dent.IdentificationCode);
                        Console.WriteLine("Навички лікування зубів: " + dent.DentistryLevel);
                        Console.WriteLine("Чи вміє гарно готувати?: " + dent.Coocking);
                        Console.Write("Чи вміє розважати дітеЙ?: ");
                        if (dent.EquipmentForEntertainment == "в наявності")
                        {
                            Console.WriteLine("так");
                        }
                        else
                        {
                            Console.WriteLine("ні");
                        }
                        Console.WriteLine("_________________________________________________\n");
                    }
                }
            }
        }
        private static List<Student> ExcellentStud5Course(List<Student> st)
        {
            var newList = new List<Student>();
            foreach (var item in st)
            {
                if (item.CheckStudent() == true)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }
        public static void StartProject()
        {
            for (int i = 0; i < 1;)
            {
                StartMenu();
                switch (Choice())
                {
                    case ("1"):
                        {
                            OutputType1();
                            break;
                        }
                    case ("2"):
                        {
                            SerializingDataStudent();
                            SerializingDataStoryteller();
                            SerializingDataDentist();
                            break;
                        }
                    case ("3"):
                        {
                            Console.Clear();
                            ListMenuDeserializeStudent();
                            ListMenuDeserializeStoryteller();
                            ListMenuDeserializeDentist();
                            Console.ReadLine();
                            break;
                        }
                    case ("4"):
                        {
                            Console.Clear();
                            int num = 0;
                            Console.WriteLine("Список студенток відмінниць:");
                            if (StudentsDeserialize != null)
                            {
                                foreach (var item in ExcellentStud5Course(StudentsDeserialize))
                                {
                                    Console.WriteLine("Ім'я: " + item.Name);
                                    Console.WriteLine("Прізвище: " + item.Surname);
                                    Console.WriteLine("Стать: " + item.Sex);
                                    Console.WriteLine("Ідентифікаційний код: " + item.IdentificationCode);
                                    Console.WriteLine("Студентський квиток: " + item.StudentID);
                                    Console.WriteLine("Курс: " + item.Course);
                                    Console.WriteLine("Середня оцінка: " + item.AverageMark);
                                    Console.WriteLine("Чи вміє гарно готувати?: " + item.Coocking);
                                    Console.WriteLine("_________________________________________________\n");
                                    num++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Для початку потрібно серіалізувати та десеріалізувати дані");
                                Console.ReadKey();
                                break;
                            }
                            Console.WriteLine("Кількість студенток відмінниць: " + num);
                            Console.ReadKey();
                            break;
                        }
                    case ("5"):
                        {
                            Environment.Exit(0);
                            i++;
                            break;
                        }
                    default:
                        Console.WriteLine("Неправильно введені дані. Введіть цифру від 1 до 4");
                        break;
                }
            }
        }
    }
}

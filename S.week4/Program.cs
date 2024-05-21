using System;

namespace S.week4
{
    class Student
    {
        private int studentId;
        private string name;
        private int birthYear;

        public Student(int nro, string nm, int year)
        {
            studentId = nro;
            name = nm;
            birthYear = year;
        }

        public override string ToString()
        {
            return studentId + ": " + name + ", age: " + (DateTime.Now.Year - birthYear) + " years\n";
        }
    }
    class Teacher
    {
        private string name;
        public Teacher(string nm)
        {
            name = nm;
        }
        public override string ToString()
        {
            return name;
        }
    }

    class Course
    {
        private string name;
        private int credits;

        private Teacher teacher;
        private Student[] students;
        private const int MAX_STUDENTS = 100;

        public Course(string nm, int points) : this(nm, points, new Teacher("NN")) { }
        public Course(string nm, int points, Teacher tchr)
        {
            name = nm;
            credits = points;
            teacher = tchr;
            students = new Student[MAX_STUDENTS];
        }

        public void SetTeacher(Teacher tchr)
        {
            teacher = tchr;
        }


        public bool AddStudent(Student stu)
        {
            int i = 0;
            while (i < MAX_STUDENTS && students[i] != null)
                i++;

            if (i < MAX_STUDENTS)
            {
                students[i] = stu;
                return true;
            }
            return false;
        }

        public Student GetStudent(string nm)
        {
            int i = 0;
            while (i < MAX_STUDENTS)
            {
                if (students[i] != null && students[i].ToString().Contains(nm))
                    return students[i];
                i++;
            }
            return null;
        }

        public override string ToString()
        {
            
            string retValue = name + " " + credits + " \n  " + teacher + "\n";
            retValue += "\n ";
            for (int i = 0; i < MAX_STUDENTS; i++)
            {
                if (students[i] != null)
                    retValue += students[i].ToString() + ", ";
            }
             //retValue = retValue.Remove(retValue.LastIndexOf(',', 2));

            

            return retValue;
        }

        public Boolean RemoveStudent(Student stud)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == stud)
                {
                    students[i] = null;
                    return true;
                }

            }
            return false;
        }


    }


    class Programme
    {
        private string name;
        private Teacher principalLecturer;

        private Student[] studentRegister;
        private Course[] courses;
        private Teacher[] teachers;

        private const int MAX_NUMBER = 100;

        public Programme(string nm)
        {
            name = nm;
            studentRegister = new Student[MAX_NUMBER];
            courses = new Course[MAX_NUMBER];
            teachers = new Teacher[MAX_NUMBER];
        }

        public bool AddStudent(Student std)
        {
            int i = 0;
            while (i < MAX_NUMBER && studentRegister[i] != null)
                i++;

            if (i < MAX_NUMBER)
            {
                studentRegister[i] = std;
                return true;
            }
            return false;
        }

        public bool AddCourse(Course crs)
        {
            int i = 0;
            while (i < MAX_NUMBER && courses[i] != null)
                i++;

            if (i < MAX_NUMBER)
            {
                courses[i] = crs;
                return true;
            }
            return false;
        }

        public bool AddTeacher(Teacher tch)
        {
            int i = 0;
            while (i < MAX_NUMBER && teachers[i] != null)
                i++;

            if (i < MAX_NUMBER)
            {
                teachers[i] = tch;
                return true;
            }
            return false;
        }

        public void SetPrincipalLecturer(Teacher tch)
        {
            principalLecturer = tch;
        }

        public Student GetStudent(string name)
        {
            int i = 0;
            while (i < MAX_NUMBER)
            {
                if (studentRegister[i] != null && studentRegister[i].ToString().Contains(name))
                    return studentRegister[i];
                    i++;
            }
            return null;
        }

        public Teacher GetTeacher(string name)
        {
            int i = 0;
            while (i < MAX_NUMBER)
            {
                if (teachers[i] != null && teachers[i].ToString().Contains(name))
                    return teachers[i];
                    i++;
            }
            return null;
        }

        public Course GetCourse(string name)
        {
            int i = 0;
            while (i < MAX_NUMBER)
            {
                if (courses[i] != null && courses[i].ToString().Contains(name))
                    return courses[i];
                    i++;
            }
            return null;
        }

        public Teacher GetPrincipalLecturer()
        {
            return principalLecturer;
        }


        public override string ToString()
        {
            string text = null;
            text += name + "\n " + GetPrincipalLecturer() + " ";
            for (int i = 0; i < MAX_NUMBER; i++)
            {
                if (courses[i] != null)
                    text += courses[i];
            }

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                if (studentRegister[i] != null)
                    text += studentRegister[i];
            }

            
            return text;
        }

    }

class Program
    {
        static void Main(string[] args)
        {
            Programme p1 = new Programme("Monitori");
            p1.AddCourse(new Course("Programming", 5));
            p1.AddCourse(new Course("Mathematics", 4));
            p1.AddCourse(new Course("Design", 3));
            p1.AddTeacher(new Teacher("Antti"));
            p1.AddTeacher(new Teacher("Liisa"));
            p1.AddTeacher(new Teacher("Eleonora"));
            p1.AddTeacher(new Teacher("Saara"));
            p1.AddTeacher(new Teacher("Karolina"));
            p1.AddStudent(new Student(1, "Mavi", 1996));
            p1.AddStudent(new Student(2, "Elsa", 1995));
            p1.AddStudent(new Student(3, "Aurora", 1994));
            p1.AddStudent(new Student(4, "Maria", 1996));
            p1.AddStudent(new Student(5, "Aurora", 1997));
            p1.AddStudent(new Student(6, "Roosa", 1996));
            p1.AddStudent(new Student(7, "Jussi", 1994));
            p1.AddStudent(new Student(8, "kalle", 1995));
            p1.AddStudent(new Student(9, "Ville", 1994));
            p1.AddStudent(new Student(10, "Ulla", 1996));
            p1.SetPrincipalLecturer(new Teacher("Antti"));
            p1.SetPrincipalLecturer(new Teacher("Liisa"));
            p1.SetPrincipalLecturer(new Teacher("Saara"));
            
            Console.WriteLine(p1.ToString());






            /*Teacher t1 = new Teacher("Antti");
            Course c1 = new Course("Programming", 5, t1);
            c1.AddStudent(new Student(1,"Anna",1996));
            c1.AddStudent(new Student(2, "Saara", 1995));
            Console.WriteLine(c1.ToString());*/


        }
    }
}

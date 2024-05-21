using System;

namespace S.week3
{

    public class Student
    {
        private String studentName;
        private int studentNr;
        private int birthYear;

        public Student(string stuName, int stuNr, int year)
        {
            studentName = stuName;
            studentNr = stuNr;
            birthYear = DateTime.Now.Year - year;
        }

        public override string ToString()
        {
            return studentNr + ": " + studentName + ", age: " + birthYear + " years";
        }
    }

    public class Teacher
    {
        private String teacherNm;

        public Teacher(string teacName)
        {
            teacherNm = teacName;
        }

        public override string ToString()
        {
            return teacherNm;
        }
    }

    public class Course
    {
        private int credits;
        private string name;
        private Teacher teacher_1;
        private Student student_1;


        public Course (string courseName, int creditos) { }
        public Course(string courseName, int creditos, Teacher nn)
        {
            name = courseName;
            credits = creditos;
            teacher_1 = nn;
        }

        public void SetTeacher(string nn)
        {
            teacher_1 = new Teacher(nn);
        }

        /*
        public void SetStudentsSo(Student list)
        {
            students_1 = list;
        }*/

        //PUT IT ON THE CONSTRUCTOR BECAUSE IT WILL DO IT ANYWAY NO MATTER WHAT HAPPENS
        private const int MAX_STUDENT = 100;
        private Student [] students = new Student[MAX_STUDENT];
        private int nrOfStudents = 0;

        public Course(Student [] stud)
        {
            
            students = stud;
        }

        public Boolean AddStudent(Student stud)
        {
            
            int i = 0;
            while (i < MAX_STUDENT && students[i] != null)
                i++;
            if (i < MAX_STUDENT)
            {
                students[i] = stud;
                nrOfStudents++;
                return true;
            }

            return false;
        }

        public Student GetStudent(int index)
        {
            if (index >= 0 && index < MAX_STUDENT)
                return students[index];
            return null;
        }

        public Student GetStudent(string studNm)
        {
            int index = 0;
            while (index < MAX_STUDENT && !students[index].ToString().Contains(studNm))
                return students[index];
            return null;
        }

        public int GetStudentIndex(string studNm)
        {
            int index = 0;
            while (index < MAX_STUDENT && !students[index].ToString().Contains(studNm))
                index++;
            if (index < MAX_STUDENT)
                return index;
            return -1;
        }

        public Student[] GetAllStudents()
        {
            Student[] retVal = new Student[nrOfStudents];
            int index = 0;
            for (int i = 0; i < MAX_STUDENT; i++)
            {
                if (students[i] != null)
                    retVal[index++] = students[i];
            }
            return retVal;
        }

        public override string ToString()
        {
            return "Course " + name + " " + credits + " ECTS; Teacher: " + teacher_1 + ", " + students.ToString() ;
            //no se como modificar esta parte para que salgan los estudiantes completos
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Antti");
            Course c1 = new Course("Programming", 5, t1);
            Console.WriteLine(c1.ToString());
            c1.AddStudent(new Student("Anna",1,1994));
            c1.AddStudent(new Student("Saara",2,1995));
            c1.AddStudent(new Student("Jonna", 3, 1996));
            c1.AddStudent(new Student("Kari", 4, 1995));
            c1.AddStudent(new Student("Tiina", 5, 1997));
            foreach (Student stud in c1.GetAllStudents())
               Console.WriteLine(stud); 






            //Student myStud = new Student("Anna", 1, 1995);

            //c1.SetTeacher("Saara");
            //Console.WriteLine(c1.ToString());


            //Student myStud = new Student("Kalle", 2, 1995);
            //Console.WriteLine(myStud);


            //if (c1.AddStudent(new Student("John", 1, 1996)))
            //Console.WriteLine(Student.To

            //Console.WriteLine("Adding new student succesful!");
            //myStud = c1.GetStudent("John");

            //Console.WriteLine(myStud);
           /* foreach (Student stud in c1.GetAllStudents())
                Console.WriteLine(stud);*/
            //Console.WriteLine(myStud);


        }

    }
}

    

namespace StudentApp
{
    public class Student
    {
        private int rollno,age;
        private string name;
        private float cgpa;
        public Student(int rollnoo,int agee,string namee,float cgpaa)
        {
            rollno = rollnoo;
            age = agee;
            name = namee;
            cgpa = cgpaa;
        }
        public Student(int roll,string name1,float cgpa1)
        {
            rollno = roll;
            name = name1;
            cgpa = cgpa1;
        }
        public int GetRollNo()
        {
            return rollno;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetName()
        {
            return name;
        }
        public float GetCgpa()
        {
            return cgpa;
        }

        public float ConvertCgpaToPercentage()
        {
            float percent = (cgpa*9.5f);
            return percent;
        }

    }
}
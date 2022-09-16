namespace university.Models
{
    public class Student
    {
        public Student(){}
        public Student(int id, string fn, string ln){
            this.ID=id;
            this.Fname=fn;
            this.Lname=ln;
        }
        public int ID {get; set;}
        public string Fname {get; set;}
        public string Lname {get; set;}

        public string GetAllStudents(){
            string result="";
            List<Student> studentsCollection=new List<Student>();
            studentsCollection.Add(new Student(1,"Jim","Jones"));
            studentsCollection.Add(new Student(2,"Lisa","Smith"));
            studentsCollection.Add(new Student(3,"Ann","Smith"));

            foreach(Student stu in studentsCollection){
                result+=stu.ID+" "+stu.Fname+" "+stu.Lname+"\n";
            }
            return result;
        }
    }
}
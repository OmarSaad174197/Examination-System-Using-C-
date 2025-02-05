namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string practicalExamFile = "PracticalExam.txt";
            string finalExamFile = "FinalExam.txt";

            
            PracticalExam practicalExam = new PracticalExam(practicalExamFile);
            FinalExam finalExam = new FinalExam(finalExamFile);

            
            Student student1 = new Student("Omar");
            Student student2 = new Student("Ahmed");
            //Student student3 = new Student("Mohammed");
            //Student student4 = new Student("Abdullah");


            practicalExam.OnExamStarted += student1.NotifyExamStart;
            finalExam.OnExamStarted += student2.NotifyExamStart;
            

            //practicalExam.ExamStarted += student3.NotifyExamStart;
            //finalExam.ExamStarted += student4.NotifyExamStart;


            Question question1 = new ChooseOne("Who is the ballon d`or winner in 2017 ?", 2, "Sports",
            new string[] { "C.Ronaldo", "L.Messi", "Neymar" }, "C.Ronaldo", practicalExamFile);

            Question question2 = new TrueOrFalse("Is there multiple inheritance in C#?", 2, "OOP", true, practicalExamFile);

            Question question3 = new ChooseOne("What are DML queries ?", 2, "Databases",
            new string[] { "Create", "Insert", "Grant" }, "Insert", practicalExamFile);

            Question question4 = new TrueOrFalse("Is the method that is used to print in python is Console.WriteLine()?", 2, "Python", true, practicalExamFile);

            practicalExam.AddQuestion(question1);
            practicalExam.AddQuestion(question2);
            practicalExam.AddQuestion(question3);
            practicalExam.AddQuestion(question4);

            finalExam.AddQuestion(question1);
            finalExam.AddQuestion(question2);
            finalExam.AddQuestion(question3);
            finalExam.AddQuestion(question4);

            
            Console.WriteLine("Select Exam Type:\n1. Practical Exam\n2. Final Exam");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                practicalExam.StartExam();
                practicalExam.ShowExam();
            }
            else if (choice == 2)
            {
                finalExam.StartExam(); 
                finalExam.ShowExam();
            }
            else
            {
                Console.WriteLine("Exam must be only practica or final, choose one of them.");
            }
        }
    }
}
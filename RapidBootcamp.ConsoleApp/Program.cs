// See https://aka.ms/new-console-template for more information

//string firstName = "Erick";
//string lastName = "Kurniawan";

//int age = 25;
//var height = 170.5;
//bool isMarried = false;

//string nama;
//nama = "Erick Kurniawan";


//var fullName = "Erick Kurniawan";
//fullName = "Agus Kurniawan";

//var saldo = 100_000_000;

//var strSql = @"select * from Employees 
//               where EmpId=@EmpId 
//               order by EmpId asc";


//int number1 = 99;

//Console.WriteLine("Number 1: " + number1.ToString());
//Console.WriteLine($"Nama anda: {firstName} {lastName}");
//Console.WriteLine("Nama anda : " + firstName + " " + lastName);
//Console.WriteLine(34.40M);




//using System.Collections;

//int number1 = 99;
//int number2 = number1;
//number1 = 199;

////Console.WriteLine("Number 1: " + number1);
////Console.WriteLine("Number 2: " + number2);


//Student student1 = new Student();
//student1.Name = "Erick";
//student1.Age = 25;

//Student student2 = student1;
//student1.Name = "Agus";

//Student student3 = new Student();
//student3.Name = "Erick";
//student3.Age = 25;

//Lecturer lecturer1 = new Lecturer();
//lecturer1.LecturerId = 1;
//lecturer1.LecturerName = "Budi";

//var result1 = student1 is Student;
//var result2 = student1 is Lecturer;
//var result3 = student2 == student1;
//var result4 = student3 == student1;
//var result5 = student1.Age == student3.Age;

//Console.WriteLine(result1);
//Console.WriteLine(result2);
//Console.WriteLine(result3);
//Console.WriteLine(result4);
//Console.WriteLine(result5);

//Console.WriteLine("Student 1: " + student1.Name + " " + student1.Age);
//Console.WriteLine("Student 2: " + student2.Name + " " + student2.Age);

//Hari hari1 = Hari.Senin;
//Console.WriteLine(hari1);

//string[] names = new string[3];
//names[0] = "Erick";
//names[1] = "Agus";
//names[2] = "Budi";

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}

//int[] ints = new int[3];
//ints[0] = 1;
//ints[1] = 2;
//ints[2] = 3;


////tidak disarankan untuk digunakan
//ArrayList list = new ArrayList();
//list.Add("Erick");
//list.Add("Budi");
//list.Add(12);
//list.Add("Joe");

//foreach (string item in list)
//{
//    Console.WriteLine(item);
//}

//List<string> strNama = new List<string>();
//strNama.Add("Erick");
//strNama.Add("Agus");
//strNama.Add("Joe");
//strNama.Add("Jojo");

//foreach (string nama in strNama)
//{
//    Console.WriteLine(nama);
//}

//enum Hari
//{
//    Senin = 1,
//    Selasa = 2,
//    Rabu = 3,
//    Kamis = 4,
//    Jumat = 5,
//    Sabtu = 6,
//    Minggu = 7
//}

Console.Write("Masukan Jumlah Matakuliah: ");
int jumlah = Convert.ToInt32(Console.ReadLine());

double sumOfScore = 0;

for (int i = 1; i <= jumlah; i++)
{
    Console.Write($"Masukan Nilai Matakuliah {i} (1-100) :");
    sumOfScore += Convert.ToDouble(Console.ReadLine());
}

double score = sumOfScore / jumlah;

string grade = string.Empty;

if (score >= 86 && score <= 100)
{
    grade = "A";
}
else if (score >= 71 && score <= 85)
{
    grade = "B";
}
else if (score >= 56 && score <= 70)
{
    grade = "C";
}
else if (score >= 40 && score <= 55)
{
    grade = "D";
}
else
{
    grade = "E";
}
//calculate grade
//86-100 A
//71-85 B
//56-70 C
//40-55 D
//E

Console.WriteLine($"Score: {score} - Grade: {grade}");


class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Lecturer
{
    public int LecturerId { get; set; }
    public string LecturerName { get; set; }
}




using System;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World");

// Types
int x = 0;
string s = "string";
float f = 0;
double d = 0.01;
char c = 'A';
long l = 12;
bool b = true;

List<Student> students = [new Student(1, 10)];

int[] ints = [0, 1, 2, 3];

if (b)
{
    Console.WriteLine("case if");
}
else if (x < 0)
{
    Console.WriteLine("case else if");
}
else
{
    Console.WriteLine("case else");
}

int ternario = f > d ? 20 : 15;

for (int i = 0; i < ints.Length; i++)
{
Console.WriteLine(ints[i]);
//action
}

Console.WriteLine(Enum.IsDefined(typeof(Teste), "E")) ;

foreach (Student student in students)
{
    Console.WriteLine(student.Id);
    Console.WriteLine(student.ToString());
}
    int opc = 1;
switch (opc)
{
    case 1:
        Console.WriteLine("o caso é 1");
        break;
    case 2:
        Console.WriteLine("o caso é 2");
        break;
}


public class Student   
{
    private int id { get; set; }
    private int idade { get; set; }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }


    public Student(int id, int idade)
    {
        this.id = id;
        this.idade = idade;
    }

    public override string ToString()
    {
        return $"id: {id}, idade: {idade}";
    }


}

enum Teste
{
    ISSO,
    E,
    UM,
    TESTE
}






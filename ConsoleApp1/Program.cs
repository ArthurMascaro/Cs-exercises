using System;
using System.Collections;
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

//condicionais

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

// loopings

List<Student> students = [new Student(1, 10)];

int[] ints = [0, 1, 2, 3];

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

// Switch
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

// Estruturas:
int[] inteiros = [1, 2, 3, 4]; // array
List<int> list = new List<int>(); // Lista
Dictionary<int, string> dic = new Dictionary<int, string>(); // Dicionario Chave - Valor
HashSet<int> set = new HashSet<int>(); // Conjunto -> não permite elementos duplicados
Queue<int> queue = new Queue<int>(); // fila -> FIFO (primeiro a entrar, primeiro a sair) 
Stack<int> stack = new Stack<int>(); // pilha -> LIFO (ultimo a entrar, primeiro a sair)
int[,] matriz = new int[3, 3]; // array multidimensional

// Tratamento de erros

/* 
Existem dois tipos:
Checked Exception -> necessitam ser tratadas (geralmente com try/catch) são != de runtime exceptions
Uncheked Exception -> não necessitam ser tratadas, ocorrem em erro de compilação como exemplo de ArgumentNullException
*/

try
{
    // Código que pode gerar uma exceção
}
catch (Exception ex)
{
    // Tratamento da exceção
}
finally
{
    // Código a ser executado sempre, independentemente de exceções
}

// Programação Funcional

/* 
 Funções de alta ordem
 se pode passar funções para outras funções e atribuí-las como variaveis, igual a seguir:
 */

Func<int, int, int> soma = (a, b) => a + b;

// Função de alta ordem que recebe uma função de transformação como argumento
static void ProcessarLista(List<int> lista, Func<int, int> funcaoTransformacao)
{
    foreach (var item in lista)
    {
        var resultado = funcaoTransformacao(item);
        Console.WriteLine(resultado);
    }
}

// Uso da função de alta ordem
var numeros = new List<int> { 1, 2, 3, 4, 5 };
ProcessarLista(numeros, x => x * 2); // Passando uma função lambda como argumento

// Expressões LINQ (Language Integrated Query):
/*  parte integral da linguagem que permite escrever consultas 
    sobre coleções de maneira semelhante à SQL, mas diretamente em código C#. */

// Exemplos:

/* 
 Filtragem:
 var numerosPares = numeros.Where(x => x % 2 == 0);

 Projeção:
 var nomes = pessoas.Select(p => p.Nome);
 
 Ordenação:
 var pessoasOrdenadas = pessoas.OrderBy(p => p.Nome);
 
 Agrupamento:
 var pessoasPorIdade = pessoas.GroupBy(p => p.Idade);

 Junção (Join):
 var resultado = from pessoa in pessoas
                join endereco in enderecos on pessoa.EnderecoId equals endereco.Id
                select new { Nome = pessoa.Nome, Endereco = endereco };

 Operações de Agregação:
 var somaIdades = pessoas.Sum(p => p.Idade);
 var mediaIdades = pessoas.Average(p => p.Idade);
 var maiorIdade = pessoas.Max(p => p.Idade);
 var menorIdade = pessoas.Min(p => p.Idade);
 
 */

// Funções de Composição:
// Juntar duas ou mais funções para criar uma
Func<int, int> quadrado = x => x * x;
Func<int, int> dobro = x => x * 2;
Func<int, int> quadradoDoDobro = x => quadrado(dobro(x));




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






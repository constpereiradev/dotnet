// See https://aka.ms/new-console-template for more information



//Variáveis declaradas com o tipo 
String nome;
String mensagem;
String atualLinguagem;
String novaLinguagem;
int idade;

nome = "Amanda";
idade = 20;
atualLinguagem = "PHP";
novaLinguagem = "C#";

//Interpolação
mensagem = $"Olá! Meu nome é {nome}. Tenho {idade} anos. Desenvolvo sistemas com {atualLinguagem} e estou aprendendo a desenvolver com {novaLinguagem}";
 
//Console.WriteLine(mensagem);


//Variáveis declaradas implicitamente
var nomeImplicito = "Amanda";
var idadeImplicito = 20;
//Console.WriteLine(nomeImplicito.GetType()); //System.String
//Console.WriteLine(idadeImplicito.GetType()); //System.Int32




//Operações com números

//Cálculadora de 13º

float salario = 20036.00F;
int mesesTrabalhados = 7;

float decimoTerceiro = (salario / 12) * mesesTrabalhados;
//Console.WriteLine($"Valor total a receber do décimo terceiro: {decimoTerceiro}");

//Fahrenheit em Celsius
int fahrenheit = 91;
float nonos = 5F/9F;
float celsius = (fahrenheit - 32) * nonos;
//Console.WriteLine(celsius);






//Notas de alunos
String classificacaoSophia = "";
String classificacaoNicolas = "";
String classificacaoZahirah = "";
String classificacaoJeong = "";

decimal currentAssignments = 5;

decimal sophia1 = 93;
decimal sophia2 = 87;
decimal sophia3 = 98;
decimal sophia4 = 95;
decimal sophia5 = 100;

decimal nicolas1 = 80;
decimal nicolas2 = 83;
decimal nicolas3 = 82;
decimal nicolas4 = 88;
decimal nicolas5 = 85;

decimal zahirah1 = 84;
decimal zahirah2 = 96;
decimal zahirah3 = 73;
decimal zahirah4 = 85;
decimal zahirah5 = 79;

decimal jeong1 = 90;
decimal jeong2 = 92;
decimal jeong3 = 98;
decimal jeong4 = 100;
decimal jeong5 = 97;
decimal  notaSophia = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / currentAssignments;
decimal  notaNicolas = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / currentAssignments;
decimal  notaZahirah = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / currentAssignments;
decimal  notaJeong = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / currentAssignments;


if(notaSophia >= 97){
    classificacaoSophia = "A";
}
if(notaSophia >= 93 && notaSophia <= 96){
    classificacaoSophia = "A";
}
if(notaSophia >= 90 && notaSophia <= 92){
    classificacaoSophia = "A-";
}
if(notaSophia >= 87 && notaSophia <= 89){
    classificacaoSophia = "B+";
}
if(notaSophia >= 83 && notaSophia <= 86){
    classificacaoSophia = "B";
}

if(notaNicolas >= 97){
    classificacaoNicolas = "A";
}
if(notaNicolas >= 93 && notaNicolas <= 96){
    classificacaoNicolas = "A";
}
if(notaNicolas >= 90 && notaNicolas <= 92){
    classificacaoNicolas = "A-";
}
if(notaNicolas >= 87 && notaNicolas <= 89){
    classificacaoNicolas = "B+";
}
if(notaNicolas >= 83 && notaNicolas <= 86){
    classificacaoNicolas = "B";
}


if(notaZahirah >= 97){
    classificacaoZahirah = "A";
}
if(notaZahirah >= 93 && notaZahirah <= 96){
    classificacaoZahirah = "A";
}
if(notaZahirah >= 90 && notaZahirah <= 92){
    classificacaoZahirah = "A-";
}
if(notaZahirah >= 87 && notaZahirah <= 89){
    classificacaoZahirah = "B+";
}
if(notaZahirah >= 83 && notaZahirah <= 86){
    classificacaoZahirah = "B";
}


if(notaZahirah >= 97){
    classificacaoJeong = "A";
}
if(notaJeong >= 93 && notaJeong <= 96){
    classificacaoJeong = "A";
}
if(notaJeong >= 90 && notaJeong <= 92){
    classificacaoJeong = "A-";
}
if(notaJeong >= 87 && notaJeong <= 89){
    classificacaoJeong = "B+";
}
if(notaJeong >= 83 && notaJeong <= 86){
    classificacaoJeong = "B";
}


//Console.WriteLine("Notas dos alunos - 2024");
//Console.WriteLine($"Sophia: { notaSophia } - {classificacaoSophia}" );
//Console.WriteLine($"Nicolas: { notaNicolas } - {classificacaoNicolas}");
//Console.WriteLine($"Zahirah: { notaZahirah } - {classificacaoZahirah}" );
//Console.WriteLine($"Jeong: { notaJeong } - {classificacaoJeong}" );



//Projeto de cálculo de GPA

int gradeA = 4;
int gradeB = 3;

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;


int gpaCourse1 = course1Credit * course1Grade;
int gpaCourse2 = course2Credit * course2Grade;
int gpaCourse3 = course3Credit * course3Grade;
int gpaCourse4 = course4Credit * course4Grade;
int gpaCourse5 = course5Credit * course5Grade;

int totalCredits = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

int gpa = (gpaCourse1 + gpaCourse2 + gpaCourse3 + gpaCourse4 + gpaCourse5) / totalCredits;


int leadingDigit = (int) gpa;
int firstDigit = (int) (gpa * 10 ) % 10;
int secondDigit = (int) (gpa * 100 ) % 10;

//Console.WriteLine("Curso    Grade   Créditos    GPA");
//Console.WriteLine($"{course1Name}   {course1Grade}      {course1Credit}     {gpaCourse1}");
//Console.WriteLine($"{course2Name}   {course2Grade}      {course2Credit}     {gpaCourse2}");
//Console.WriteLine($"{course3Name}   {course3Grade}      {course3Credit}     {gpaCourse3}");
//Console.WriteLine($"{course4Name}   {course4Grade}      {course4Credit}     {gpaCourse4}");
//Console.WriteLine($"{course5Name}   {course5Grade}      {course5Credit}     {gpaCourse5}");
//Console.WriteLine($"GPA Final: {leadingDigit}.{firstDigit}{secondDigit}");


Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
mensagem = "Você ganhou! :D";

int total = roll1 + roll2 + roll3;

if(total < 15){
    mensagem = "Desculpa, você perdeu :(";
}

Console.WriteLine(mensagem);


int numero1 = 1000;
int numero2 = 450;
Console.WriteLine(Math.Max(numero1, numero2));



//Foreach

string[] linguagens = new string[3];
linguagens[0] = "PHP";
linguagens[1] = "Javascript";
linguagens[2] = "C#";

//Console.WriteLine(linguagens[0]);

string[] projetos = ["Kenobi", "Vapt"];
//Console.WriteLine(projetos.Length);

/*
foreach (string linguagem in linguagens)
{
    Console.WriteLine(linguagem);
}
*/

string[] idPedidos = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
foreach (string id in idPedidos)
{
    if(id.StartsWith("B")){
        Console.WriteLine($"{id} Começa com a letra B.");
    }
}


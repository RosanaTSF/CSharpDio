using Avanade.cs.Design;

/*Stylist s = new Stylist();
s.Nome = "Pen";
s.Idade = 3;
s.Apresentar(); */

/*DateTime dataAtual = DateTime.Now.AddMinutes(1000);
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yy HH:mm")); */

int a = Convert.ToInt32(null);
int b = int.Parse("0"); //o parse n aceita null, dará erro.

int c = 13;
double d = c; //double aceita int e convert, acontece um casting implícito.

int e = 6;
long f = e; /*long cabe int, casting implícito, mas long n suporta int.

/*Teria que converter e específicar ou especificar o tam do long para MaxValue (tam maximo do int) que converte, casting implícito: */
int g = int.MaxValue;
long h = Convert.ToInt32(g);

/*Usando o convert: 
long g = long.MaxValue; Long tbm n poderia ser acima do valor suportado por int(32) abaixo:
int h = Convert.ToInt32(h); daria erro.*/

int inteiro = 10;
string i = inteiro.ToString(); //string não aceita parse, nem precisa do convert. 

string jota = "1-";
int.TryParse(jota, out int lol);

string amanha = "ccpx";
int geek = 10;
int.TryParse(amanha, out geek);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

Console.WriteLine(e);
Console.WriteLine(g);
Console.WriteLine(i);
Console.WriteLine(jota);
Console.WriteLine("Lol");
Console.WriteLine(amanha);
Console.WriteLine(geek);



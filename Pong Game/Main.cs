using System;
using System.Threading;
using bo;
using cam;
using jogador;

camp c = new camp();

int pontos=0, pontos2=0, pontos3=0, pont=0;

bool flag = true, flag2=true;
bool lado = true;

Console.Clear();
Console.WriteLine("\n\n\n\n\n\n\n");
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - $ $ $ $ - - - - $ $ - - - $ - - - - - - $ - - - $ $ $ $ - - - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - $ - - - $ - - $ - - $ - - $ $ - - - - - $ - - $ - - - - $ - - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - $ - - - $ - $ - - - - $ - $ - $ - - - - $ - $ - - - - - - $ - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - $ $ $ $ - - $ - - - - $ - $ - - $ - - - $ - $ - - - - - - - - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - $ - - - - - $ - - - - $ - $ - - - $ - - $ - $ - - - - - - - - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - $ - - - - - $ - - - - $ - $ - - - - $ - $ - $ - - - $ $ $ $ - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - $ - - - - - - $ - - $ - - $ - - - - - $ $ - - $ - - - - $ - - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - $ - - - - - - - $ $ - - - $ - - - - - - $ - - - $ $ $ $ - - - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
Console.WriteLine("M a d e   b y : h o r t - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - p r e s s   a n y   k e y");
Console.ReadKey();
Console.Clear();
Console.WriteLine("COMMANDS:\n");
Console.WriteLine("W - Up\t\tS - Down\t\tp - pause\t\te or ESC- exit");
Console.WriteLine("\nPress any key...");
Console.ReadKey();
while(flag)
{
  if( Console.KeyAvailable )
  {
    c.p.movement(c.campo, ref flag, ref flag2, c.b.getPosition());
  }
    c.p.move(c.campo, c.b.getPosition());
    if(flag2==false) {
    Console.ReadKey();
    flag2=true;
    }
    c.b.mexer(c.campo, ref lado, ref pontos, ref pont);
    c.print(pontos, pont);
    if(pontos>pontos2) {
    c.b.resetb(c.campo);
    c.resetc();
    c.p.resetp(c.campo, c.b.getPosition());
    pontos2=pontos;
    }
    if(pont>pontos3) {
    c.b.resetb(c.campo);
    c.resetc();
    c.p.resetp(c.campo, c.b.getPosition());
    pontos3=pont;
    }
    Console.WriteLine();
}
Console.Clear();
using System;
using System.Threading;
using bo;
using cam;
using jogador;

camp c = new camp();
ball b = new ball(c.campo);
int pontos=0, pontos2=0, pontos3=0, pont=0,posb=b.a;
player p = new player(c.campo, posb);

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
    p.movement(c.campo, ref flag, ref flag2, posb);
  }
    p.move(c.campo, posb);
    if(flag2==false) {
    Console.ReadKey();
    flag2=true;
    }
    b.mexer(c.campo, ref lado, ref pontos, ref posb, ref pont);
    c.print(pontos, pont);
    if(pontos>pontos2) {
    b.resetb(c.campo);
    c.resetc();
    p.resetp(c.campo, posb);
    pontos2=pontos;
    }
    if(pont>pontos3) {
    b.resetb(c.campo);
    c.resetc();
    p.resetp(c.campo, posb);
    pontos3=pont;
    }
    Console.WriteLine();
}
Console.Clear();
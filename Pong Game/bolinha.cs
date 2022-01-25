using System;
using System.Threading;

namespace bo {
    public class ball {
        protected int estado = 0;
        protected int x=15, score=0;
        private int y=0;
        public ball(String[,] campo) {
            Random rand = new Random();
            this.y = rand.Next(5,9);
            campo[y,15] = "*";
        }
        public void resetb(String[,] campo) {
            campo[y,x] = "-";
            this.x=15;
            Random rand = new Random();
            this.y = rand.Next(5,9);
            campo[y,15] = "*";
        }
        public int getPosition() {
            return this.y;
        }
        public void mexer(String[,] campo, ref bool lado, ref int sc, ref int sc2) {
            if(estado==0) {
                if(x-1==0) { 
                    try {
                    if(campo[y-1,x-1]=="|" ) { 
                        lado =  false;
                        campo[y,x] = "-";
                        x++;
                        campo[y,x] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Lose!!");
                        Thread.Sleep(1000);
                        sc2++;
                        x++;
                    }
                }catch(Exception) {
                        if(campo[y,x-1]=="|" || campo[y+1,x-1]=="|") { 
                        lado =  false;
                        campo[y,x] = "-";
                        x++;
                        campo[y,x] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Lose!!");
                        Thread.Sleep(1000);
                        sc2++;
                        x++;
                    }
                }
                }
                if(x+1==29) {
                    try{
                    if(campo[y-1,x+1]=="|") {
                        lado =  true;
                        campo[y,x] = "-";
                        x--;
                        campo[y,x] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Win!!");
                        Thread.Sleep(1000);
                        sc++;
                        x--;
                    }
                } catch(Exception) {
                    if(campo[y,x+1]=="|" || campo[y+1,x+1]=="|") {
                        lado =  true;
                        campo[y,x] = "-";
                        x--;
                        campo[y,x] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Win!!");
                        Thread.Sleep(1000);
                        sc++;
                        x--;                     
                    }
                }
                }
                else if(y-1==-1) {
                    estado = 1;
                }
                else{
                    if(lado==true) {
                        campo[y,x] = "-";
                        x--;
                        y--;
                        campo[y,x] = "*";
                    }
                    else if(lado==false) {
                        campo[y,x] = "-";
                        x++;
                        y--;
                        campo[y,x] = "*";
                    }
                }
            }
            if(estado==1) {
                if(x-1==0) { 
                    try {
                    if(campo[y+1,x-1]=="|") { 
                        lado =  false;
                        campo[y,x] = "-";
                        x++;
                        campo[y,x] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Lose!!");
                        Thread.Sleep(1000);
                        sc2++;
                        x++;
                    }
                    } catch(Exception) {
                        if(campo[y,x-1]=="|" || campo[y-1,x-1]=="|") { 
                        lado =  false;
                        campo[y,x] = "-";
                        x++;
                        campo[y,x] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Lose!!");
                        Thread.Sleep(1000);
                        sc2++;
                        x++;
                    }
                    }
                }
                if(x+1==29) {
                    try {
                    if(campo[y+1,x+1]=="|") {
                        lado =  true;
                        campo[y,x] = "-";
                        x--;
                        campo[y,x] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Win!!");
                        Thread.Sleep(1000);
                        sc++;
                        x--;
                    }
                    } catch(Exception) {
                        if(campo[y,x+1]=="|" || campo[y-1,x+1]=="|") {
                        lado =  true;
                        campo[y,x] = "-";
                        x--;
                        campo[y,x] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Win!!");
                        Thread.Sleep(1000);
                        sc++;
                        x--;
                    }
                    }
                }
                else if(y+1==15) {
                    estado = 0;
                }
                else {
                if(lado==true) {
                        campo[y,x] = "-";
                        x--;
                        y++;
                        campo[y,x] = "*";
                    }
                else if(lado==false) {
                        campo[y,x] = "-";
                        x++;
                        y++;
                        campo[y,x] = "*";
                    }
            }
            }
        }
    }
}
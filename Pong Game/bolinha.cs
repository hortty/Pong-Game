using System;
using System.Threading;

namespace bo {
    public class ball {
        protected int estado = 0;
        protected int b=15, score=0;
        public int a=0;
        public ball(String[,] campo) {
            Random rand = new Random();
            a = rand.Next(5,9);
            campo[a,15] = "*";
        }
        public void resetb(String[,] campo) {
            campo[a,b] = "-";
            b=15;
            Random rand = new Random();
            a = rand.Next(5,9);
            campo[a,15] = "*";
        }
        public void mexer(String[,] campo, ref bool lado, ref int sc, ref int a, ref int sc2) {
            if(estado==0) {
                if(b-1==0) { 
                    try {
                    if(campo[a-1,b-1]=="|" ) { 
                        lado =  false;
                        campo[a,b] = "-";
                        b++;
                        campo[a,b] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Lose!!");
                        Thread.Sleep(1000);
                        sc2++;
                        b++;
                    }
                }catch(Exception) {
                        if(campo[a,b-1]=="|" || campo[a+1,b-1]=="|") { 
                        lado =  false;
                        campo[a,b] = "-";
                        b++;
                        campo[a,b] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Lose!!");
                        Thread.Sleep(1000);
                        sc2++;
                        b++;
                    }
                }
                }
                if(b+1==29) {
                    try{
                    if(campo[a-1,b+1]=="|") {
                        lado =  true;
                        campo[a,b] = "-";
                        b--;
                        campo[a,b] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Win!!");
                        Thread.Sleep(1000);
                        sc++;
                        b--;
                    }
                } catch(Exception) {
                    if(campo[a,b+1]=="|" || campo[a+1,b+1]=="|") {
                        lado =  true;
                        campo[a,b] = "-";
                        b--;
                        campo[a,b] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Win!!");
                        Thread.Sleep(1000);
                        sc++;
                        b--;                     
                    }
                }
                }
                else if(a-1==-1) {
                    estado = 1;
                }
                else{
                    if(lado==true) {
                        campo[a,b] = "-";
                        b--;
                        a--;
                        campo[a,b] = "*";
                    }
                    else if(lado==false) {
                        campo[a,b] = "-";
                        b++;
                        a--;
                        campo[a,b] = "*";
                    }
                }
            }
            if(estado==1) {
                if(b-1==0) { 
                    try {
                    if(campo[a+1,b-1]=="|") { 
                        lado =  false;
                        campo[a,b] = "-";
                        b++;
                        campo[a,b] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Lose!!");
                        Thread.Sleep(1000);
                        sc2++;
                        b++;
                    }
                    } catch(Exception) {
                        if(campo[a,b-1]=="|" || campo[a-1,b-1]=="|") { 
                        lado =  false;
                        campo[a,b] = "-";
                        b++;
                        campo[a,b] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Lose!!");
                        Thread.Sleep(1000);
                        sc2++;
                        b++;
                    }
                    }
                }
                if(b+1==29) {
                    try {
                    if(campo[a+1,b+1]=="|") {
                        lado =  true;
                        campo[a,b] = "-";
                        b--;
                        campo[a,b] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Win!!");
                        Thread.Sleep(1000);
                        sc++;
                        b--;
                    }
                    } catch(Exception) {
                        if(campo[a,b+1]=="|" || campo[a-1,b+1]=="|") {
                        lado =  true;
                        campo[a,b] = "-";
                        b--;
                        campo[a,b] = "*";
                    }
                    else {
                        Console.WriteLine("\n\nYou Win!!");
                        Thread.Sleep(1000);
                        sc++;
                        b--;
                    }
                    }
                }
                else if(a+1==15) {
                    estado = 0;
                }
                else {
                if(lado==true) {
                        campo[a,b] = "-";
                        b--;
                        a++;
                        campo[a,b] = "*";
                    }
                else if(lado==false) {
                        campo[a,b] = "-";
                        b++;
                        a++;
                        campo[a,b] = "*";
                    }
            }
            }
        }
    }
}
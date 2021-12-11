using System;
using System.Threading;

namespace jogador {
    public class player {
        protected int pos = 6, pos2=6;
        protected int win=0;
        public player(String[,] campo, int ppp) {
            pos2=ppp;
            campo[7,0] = "|";
            campo[8,0] = "|";
            campo[6,0] = "|";
            campo[9,0] = "|";
            
            campo[pos2,29] = "|";
            campo[pos2+1,29] = "|";
            campo[pos2+2,29] = "|";
            campo[pos2+3,29] = "|";
            Random ran1 = new Random();
            win = ran1.Next(0,2);
        }
        public void resetp(String[,] campo, int ppp) {
            pos2=ppp;
            pos = 6;
            campo[7,0] = "|";
            campo[8,0] = "|";
            campo[6,0] = "|";
            campo[9,0] = "|";
            try {
            campo[pos2,29] = "|";
            campo[pos2+1,29] = "|";
            campo[pos2+2,29] = "|";
            campo[pos2+3,29] = "|";
            } catch(Exception) {
            while(pos2<=14) {
                campo[pos2,29] = "-";
                pos2++;
            }   
                pos2=7;
            campo[pos2,29] = "|";
            campo[pos2+1,29] = "|";
            campo[pos2+2,29] = "|";
            campo[pos2+3,29] = "|";
            }
            Random ran2 = new Random();
            win = ran2.Next(0,2);
        }
        public void movement(String[,] campo, ref bool fla, ref bool fla2, int po) {
            char cha = Console.ReadKey().KeyChar ;
                Thread.Sleep(10);
                if(cha=='e' || cha==27) {
                    fla=false;
                }
                else if (cha=='p') {
                    fla2=false;
                }
                else if (cha=='w') {
                    if((pos-1)>=0) {
                        campo[pos+3,0] = "-";
                        
                        pos--;
                        campo[pos,0] = "|";
                    } 
                }
                else if (cha=='s') {
                    if((pos+4)<=14) {
                        campo[pos,0] = "-";
                        
                        pos++;
                        campo[pos+3,0] = "|";
                        
                    } 
                }
        }
        public void move(String[,] campo, int po) {
                Thread.Sleep(10);
                if(win==0) {
                    if((pos2+1)>=po) {
                        if((pos2-1)>=0) {
                        campo[pos2,29] = "-";
                        campo[pos2+1,29] = "-";
                        campo[pos2+2,29] = "-";
                        campo[pos2+3,29] = "-";
                        pos2--;
                        campo[pos2,29] = "|";
                        campo[pos2+1,29] = "|";
                        campo[pos2+2,29] = "|";
                        campo[pos2+3,29] = "|";
                    } 
                    }
                    else if((pos2-1)<=po){
                        if((pos2+4)<=14) {
                        campo[pos2,29] = "-";
                        campo[pos2+1,29] = "-";
                        campo[pos2+2,29] = "-";
                        campo[pos2+3,29] = "-";
                        pos2++;
                        campo[pos2,29] = "|";
                        campo[pos2+1,29] = "|";
                        campo[pos2+2,29] = "|";
                        campo[pos2+3,29] = "|";
                    } 
                    }
                }
                else {
                    if((pos2+5)>=po) {
                        if((pos2-1)>=0) {
                            try {
                        campo[pos2,29] = "-";
                        campo[pos2+1,29] = "-";
                        campo[pos2+2,29] = "-";
                        campo[pos2+3,29] = "-";
                        pos2--;
                        campo[pos2,29] = "|";
                        campo[pos2+1,29] = "|";
                        campo[pos2+2,29] = "|";
                        campo[pos2+3,29] = "|";
                            }catch(Exception) {};
                    } 
                    }
                    else if((pos2-5)<=po){
                        if((pos2+4)<=14) {
                            try {
                        campo[pos2,29] = "-";
                        campo[pos2+1,29] = "-";
                        campo[pos2+2,29] = "-";
                        campo[pos2+3,29] = "-";
                        pos2++;
                        campo[pos2,29] = "|";
                        campo[pos2+1,29] = "|";
                        campo[pos2+2,29] = "|";
                        campo[pos2+3,29] = "|";
                            } catch(Exception) {};
                    } 
                    }
                }
        }
    }
}
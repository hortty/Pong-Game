using System;
using System.Threading;

namespace cam {
    public class camp {
        public String[,] campo = new String[15,30];
        protected int s=0, s1=0;
        public camp() {
            for(int i=0;i<15;i++) {
                for(int j=0;j<30;j++) {
                    campo[i,j] = "-";
            }
            }
        }
        public void resetc() {
            for(int i=0;i<15;i++) {
                for(int j=0;j<30;j++) {
                    campo[i,j] = "-";
            }
            }
        }
        public void print(int score, int score2) {
            s=score;
            s1=score2;
            Console.Clear();
            for(int i=0;i<15;i++) {
                Console.Write("\t\t\t");
                for(int j=0;j<30;j++) {
                    Console.Write(campo[i,j]+' ');
            }
            Console.WriteLine();
            }
            Console.WriteLine("\n\t\t\tPlayer Score: " + s + "\t\t\t\t\tPC Score: " + s1);
            Thread.Sleep(80);
        }
    }
}
using System;

class Calculadora {
    static void Main() {

        int n1;
        int n2;
        int r;
        string op;

        Console.Write("Qual operação deseja calcular?\n[+]\n[-]\n[*]\n[/]\nR:   ");
        op = Console.ReadLine();

        if (op == "+"){
            Console.Write("Digite o valor de N1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de N2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            r = (n1 + n2);

            Console.Write("A soma de " + n1 + " e " + n2 + " vale: " + r);
        }

        else if (op == "-") {
            Console.Write("Digite o valor de N1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de N2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            r = (n1 - n2);

            Console.Write("A diferença entre " + n1 + " e " + n2 + " vale: " + r);
            
        }

        else if (op == "*") {
            Console.Write("Digite o valor de N1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de N2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            r = (n1 * n2);

            Console.Write("O produto de " + n1 + " e " + n2 + " vale: " + r);
        }

        else if (op == "/") {
            Console.Write("Digite o valor de N1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de N2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            r = (n1 / n2);

            Console.Write("O quociente da divisão de " + n1 + " por " + n2 + " vale:" + r);

        }

    }
}

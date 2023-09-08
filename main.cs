using System;

struct Numeros {
    public int n1;
    public int n2;
}

class Calculadora {

    static Numeros Numbers() {

        Numeros nums;

        Console.Write("Digite o valor de N1:  ");
        nums.n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de N2:  ");
        nums.n2 = Convert.ToInt32(Console.ReadLine());

        return nums;

    }

    static void Main() {

        int r;
        string op;

        Console.Write("Qual operação deseja calcular?\n[+]\n[-]\n[*]\n[/]\nR:   ");
        op = Console.ReadLine();
        
        Numeros valores = Numbers();

        switch (op) {
            case "+":        
                r = (valores.n1 + valores.n2);
                Console.WriteLine("O resultado da soma é: " + r);
                break;
            case "-":
                r = (valores.n1 - valores.n2);
                Console.WriteLine("O resultado da subtração é: " + r);
                break;
            case "*":
                r = (valores.n1 * valores.n2);
                Console.WriteLine("O resultado da multiplicação é: " + r);
                break;
            case "/":
                if (valores.n2 != 0){
                    r = (valores.n1 / valores.n2);
                    Console.WriteLine("O resultado da divisão é: " + r);
                }

                else {
                    Console.WriteLine("É impossível dividir por 0.");
                }
                break;
            default:
                Console.Write("Opção inválida.");
                break;
        }

        Console.Write("\nPressione para sair: ");
        Console.ReadLine();

    }
}

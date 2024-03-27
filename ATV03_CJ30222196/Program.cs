namespace ATV4_CJ3022196
{
    internal class Program
    {
        static void Main(string[] args)
        {   //menu
            int exercicio;
            Console.WriteLine("Escolha um exercício:");
            Console.WriteLine("Digite 1 para 1");
            Console.WriteLine("Digite 2 para 2");
            Console.WriteLine("Digite 3 para 3");
            Console.WriteLine("Digite 4 para 4");
            Console.WriteLine("Digite 5 para 5");
            Console.WriteLine("Digite 6 para 6");
            exercicio = int.Parse(Console.ReadLine());


            switch (exercicio)
            {
                case 1:
                    int dia;
                    Console.WriteLine("Digite um número referente a um dia da semana");
                    dia = int.Parse(Console.ReadLine());
                    switch (dia)
                    {
                        case 1:
                            Console.WriteLine("Domingo");
                            break;

                        case 2:
                            Console.WriteLine("Segunda-Feira");
                            break;
                        case 3:
                            Console.WriteLine("Terça-Feira");
                            break;
                        case 4:
                            Console.WriteLine("Quarta-Feira");
                            break;
                        case 5:
                            Console.WriteLine("Quinta-Feira");
                            break;
                        case 6:
                            Console.WriteLine("Sexta-Feira");
                            break;
                        case 7:
                            Console.WriteLine("Sábado");
                            break;


                    }
                    break;

                case 2:
                    double valor, valorf;
                    int formap;
                    Console.WriteLine("Digite o valor da compra: ");
                    valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escolha a foma de pagamento: ");
                    Console.WriteLine(" 1 - a vista no dinheiro");
                    Console.WriteLine(" 2 - a vista no pix");
                    Console.WriteLine(" 3 - cartão de débito");
                    Console.WriteLine(" 4 - cartão de crédito");
                    formap = int.Parse(Console.ReadLine());

                    switch (formap)
                    {
                        case 1:
                            valorf = valor - valor * 0.15;
                            Console.WriteLine("O valor total é de R$", valorf);
                            break;
                        case 2:
                            valorf = valor - valor * 0.10;
                            Console.WriteLine("O valor total é de R$", valorf);
                            break;
                        case 3:
                            valorf = valor + valor * 0.05;
                            Console.WriteLine("O valor é de R$", valorf);
                            break;
                        case 4:
                            valorf = valor + valor * 0.10;
                            Console.WriteLine("O valor é de R$", valorf);
                            break;

                    }


                    break;
                case 3:
                    int meses, ano;
                    Console.WriteLine("Digite um número de 1 a 12:");
                    meses = int.Parse(Console.ReadLine());

                    switch (meses)
                    {
                        case 1:
                            Console.WriteLine(" janeiro - 31 dias ");
                            break;
                        case 2:
                            Console.WriteLine("O ano é bissexto ?");
                            Console.WriteLine("1 - Sim");
                            Console.WriteLine("2 - Não");
                            ano = int.Parse(Console.ReadLine());

                            switch (ano)
                            {
                                case 1:
                                    Console.WriteLine("Fevereiro - 29 dias");
                                    break;
                                case 2:
                                    Console.WriteLine("Fevereiro - 28 dias");
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Março - 31 dias");
                            break;
                        case 4:
                            Console.WriteLine("Abriu - 30 dias");
                            break;
                        case 5:
                            Console.WriteLine("Maio - 31 dias");
                            break;
                        case 6:
                            Console.WriteLine("Junho - 30 dias");
                            break;
                        case 7:
                            Console.WriteLine("Julho - 31 dias");
                            break;
                        case 8:
                            Console.WriteLine("Agosto - 31 dias");
                            break;
                        case 9:
                            Console.WriteLine("Setembro - 30 dias");
                            break;
                        case 10:
                            Console.WriteLine("Outubro - 31 dias");
                            break;
                        case 11:
                            Console.WriteLine("Novembro - 30 dias");
                            break;
                        case 12:
                            Console.WriteLine("Dezembro - 31 dias");
                            break;


                    }
                    break;



                case 4:

                    int op = 0, num1, num2, resultado;

                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Escolha a operação: ");
                    Console.WriteLine("1 - Adição");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");
                    Console.WriteLine("Digite a operação: ");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            resultado = num1 + num2;
                            Console.WriteLine(resultado);
                            break;

                        case 2:
                            resultado = num1 - num2;
                            Console.WriteLine(resultado);
                            break;
                        case 3:
                            resultado = num1 * num2;
                            Console.WriteLine(resultado);
                            break;
                        case 4:
                            resultado = num1 % num2;
                            break;
                    }
                    break;


            }
        }


    }
}

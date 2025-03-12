
/*
 * As classes a serem dsenvolvidas devem atender aos seguintes requisitos:
 * - Devem estar na pasta Model
 * - Para a classe SomaDoisNumeros, deve-se criar um método estático chamado Somar que recebe dois inteiros e retorna a soma deles
 * - Para a classe MetrosMilimetros, deve-se criar um método estático chamado Converter que recebe um double e retorna o valor em milímetros
 * - A  classe CalculaAumento deve ter um método estático chamado Calcular que recebe um double salario e um double aumento e retorna o valor do salário com o aumento aplicado
 * A classe CalculaDesconto deve ter um método estático chamado Calcular que recebe um double valor e um double desconto e retorna o valor com o desconto aplicado
 * - A classe CalculaAluguelCarro deve ter um método estático chamado Calcular que recebe um int dias, um int quilometragemInicial, um int quilometragemFinal e retorna o valor total do aluguel
 */

//Primeira tarefa realizada
    public static class SomaDoisNumeros
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
    }

//Segunda tarefa realizada
    public static class MetrosMilimetros
    {
        public static double Converter(double metros)
        {
            return metros * 1000;
        }
    }

//Terceira tarefa realizada
    public static class CalculaAumento
    {
        public static double Calcular(double salario, double aumento)
        {
            return salario + aumento;
        }
    }

//Quarta tarefa realizada
    public static class CalculaDesconto
    {
        public static double Calcular(double valor, double desconto)
        {
            return valor - desconto;
        }
    }

//Quinta tarefa realizada
    public static class CalculaAluguelCarro
    {
        public static double Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
        {
            const double precoPorDia = 100.0; // Exemplo de valor fixo por dia
            const double precoPorKm = 0.75; // Exemplo de valor fixo por km rodado
            
            int kmRodados = quilometragemFinal - quilometragemInicial;
            return (dias * precoPorDia) + (kmRodados * precoPorKm);
        }
    }
}


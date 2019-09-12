using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_DALPPI
{
    public class Utilitarios
    {
        //PRIMEIRA PARTE
        //EXERCICIO_1
        /// <summary>
        /// Conversão de tempo
        /// </summary>
        /// <param name="seg">segundos</param>
        /// <returns>segundo, minuto,hora</returns>
        public Tuple<int, int, int> Segundos(int seg)
        {
            int min;
            int hrs;

            min = seg / 60;
            hrs = min / 60;

            seg = seg % 60;
            min = min % 60;
            hrs = hrs % 60;

            return new Tuple <int,int,int>(seg, min, hrs);
        }

        //EXERCICIO_2
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numI"></param>
        /// <param name="numF"></param>
        /// <returns></returns>
        public string NumeroPar(int numI, int numF)
        {
            string pares = "";

            for (int i = numI; i <= numF; i++)
            {
                if (i % 2 == 0)
                {
                    pares += Convert.ToString(i)+", ";
                }
            }
            return pares;
        }

        //EXERCICIO_3
        /// <summary>
        /// Conversão de Temperatura de Celsiuas para Kelvin ou Fahrenheit
        /// </summary>
        /// <param name="celsius">Temperatura em Graus Celsius</param>
        /// <param name="opcao">Fazer a escolha entre Kelvin ou Fahrenheit</param>
        /// <returns>Temperatura escolhida</returns>
        public double Temperatura(double celsius, bool opcao)
        {
            if (opcao)
            {
                return celsius + 273;
            }
            else
            {
                return (1.8 * celsius) + 32;
            }
        }

        //EXERCICIO_4
        /// <summary>
        /// Número divisível por 3
        /// </summary>
        /// <param name="numero">Numero digitado</param>
        /// <returns>Divisível ou Não Divisível</returns>
        public string DivisivelTres(int numero)
        {
            if(numero % 3 == 0)
            {
                return "É divisível por 3!";
            }
            else
            {
                return "Não é divisível por 3!";
            }
        }

        //EXERCICIO_5
        /// <summary>
        /// Descobrir a idade pela data de aniversário
        /// </summary>
        /// <param name="dtNasc">Data de Nascimento</param>
        /// <returns>Idade da pessoa</returns>
        public int Idade(DateTime dtNasc)
        {
            int idade;
            idade = DateTime.Now.Year - dtNasc.Year;

            if (DateTime.Now.Month < dtNasc.Month || (DateTime.Now.Month == dtNasc.Month && DateTime.Now.Day < dtNasc.Day))
            {
                idade--;
            }
            return idade;
        }


        //SEGUNDA PARTE
        //EXERCICIO_1
        /// <summary>
        /// Programa para exibir o dobro ou a metade dependendo se o número for par ou impar
        /// </summary>
        /// <param name="num">Número digitado</param>
        /// <returns>Impar ou Par e sua variação</returns>
        public Tuple<string,double> DobroMetade(double num)
        {
            if(num % 2 == 0)
            {
                return new Tuple<string, double> ("O número é par seu dobro é: ", num * 2);
            }
            else
            {
                return new Tuple<string, double>("O número é impar sua metade é: ", num / 2);
            }
        }

        //EXERCICIO_2
        /// <summary>
        /// Exibir a diferença entre 2 números
        /// </summary>
        /// <param name="num1">Primeiro Número</param>
        /// <param name="num2">Segundo Número</param>
        /// <returns>Exibe a Diferença</returns>
        public int Diferenca(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1 - num2;
            }
            else
            {
                return num2 - num1;
            }
        }

        //EXERCICIO_3
        /// <summary>
        /// Exibe o IMC de uma pessoa
        /// </summary>
        /// <param name="peso">Peso em Kg</param>
        /// <param name="altura">Altura em metros</param>
        /// <returns>IMC</returns>
        public double IMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        //EXERCICIO_4
        /// <summary>
        /// Exibir a nota
        /// </summary>
        /// <param name="nota">Nota de 0 a 10</param>
        /// <returns>Classificação da Nota</returns>
        public string VerificaNota(double nota)
        {
            string result = "";

            if (nota < 0 || nota > 10)
            {
                result = "Nota inválida";
            }
            else if (nota == 10)
            {
                result = "Excelente";
            }
            else if (nota >= 8)
            {
                result = "Muito bom";
            }
            else if (nota >= 7)
            {
                result = "Bom";
            }
            else if (nota >= 0)
            {
                result = "Insatisfatório";
            }

            return result;
        }

        //EXERCICIO_5
        /// <summary>
        /// Exibir a diferença de dias entre duas datas xx/xx/xxxx
        /// </summary>
        /// <param name="dtInicial">Primeira Data</param>
        /// <param name="dtFinal">Segunda Data</param>
        /// <returns>Diferença em dias</returns>
        public int DiferencadeDias(DateTime dtInicial,DateTime dtFinal)
        {
            TimeSpan date = dtInicial - dtFinal;
            int dias = date.Days;
            return dias;
        }


        //TERCEIRA PARTE
        //EXERCICIO_1

        //EXERCICIO_2

        //EXERCICIO_3
        /// <summary>
        /// Exibir letras repetidas em uma frase
        /// </summary>
        /// <param name="frase">Frase digitada</param>
        /// <param name="letra">Letra digitada</param>
        /// <returns>Exibe quantidade de letras da frase</returns>
        public int ContaLetras(string frase, string letra)
        {
            var chars = frase.ToCharArray();
            int letr_repit = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (letra == Convert.ToString(chars[i]))
                {
                    letr_repit++;
                }
            }
            return letr_repit;
        }

        //EXERCICIO_4
        /// <summary>
        /// Exibe se o ano digitado é Bissexto
        /// </summary>
        /// <param name="num">Digite o Ano</param>
        /// <returns>Resposta se é ou não Bissexto</returns>
        public string AnoBissexto(int num)
        {
            bool resultado = false;
            if (num % 400 == 0)
            {
                resultado = true;
            }
            else if (num % 100 == 0)
            {
                resultado = false;
            }
            else if (num % 4 == 0)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            if (resultado)
            {
                return "Esse é um ano bissexto";
            }
            else
            {
                return "Esse não é um ano bissexto";
            }
        }

        //QUARTA PARTE
        //EXERCICIO_1
        //EXERCICIO_1
        /// <summary>
        /// Soma uma quantia de elementos e multiplica pelas suas posições
        /// </summary>
        /// <param name="n1">Primeiro Número</param>
        /// <param name="n2">Segundo Número</param>
        /// <param name="n3">Terceiro Número</param>
        /// <param name="n4">Quarto Número</param>
        /// <param name="n5">Quinto Número</param>
        /// <param name="n6">Sexto Número</param>
        /// <param name="n7">Sétimo Número</param>
        /// <param name="n8">Oitavo Número</param>
        /// <returns>Resultado das Somas e Multiplicações</returns>
        public int recebernum(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8)
        {
            int[] recebidos = new int[8];
            int total = 0;
            recebidos[0] = n1;
            recebidos[1] = n2;
            recebidos[2] = n3;
            recebidos[3] = n4;
            recebidos[4] = n5;
            recebidos[5] = n6;
            recebidos[6] = n7;
            recebidos[7] = n8;

            for (int i = 0; i < recebidos.Length; i++)
            {
                recebidos[i] = recebidos[i] * (i+1);
            }

            for (int i = 0; i < recebidos.Length; i++)
            {
                total += recebidos[i];
            }
            return total;
        }
    }
}


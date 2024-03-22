/* Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 * C.S.T. em Análise e Desenvolvimento de Sistemas
 * Disciplina de Algoritmo e Lógica de Programação I
 * Professor Clayton Ferraz Andrade
 *
 * Acadêmico Vinícius de Oliveira Pinheiro
 * Atividade Prática
 */
using System.Security.AccessControl;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@"


   ----------------------------------------------------------------------    
   Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
   ----------------------------------------------------------------------
   
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          +++++++++++++++++     +++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++++.....+++      ++        +++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        
          C.S.T. em Análise e Desenvolvimento de Sistemas
          Disciplina de Algoritmo e Lógica 1
          Professor Clayton Ferraz Andrade
          Acadêmico Vinícius de Oliveira Pinheiro

       ");
Console.ReadLine();
Console.Clear();
while (true)
{
    Console.Write(@"


 
    C.S.T. em Análise e Desenvolvimento de Sistemas
    Disciplina de Algoritmo e Lógica 1
    Professor Clayton Ferraz de Andrade
    Acadêmico Vinícius de Oliveira Pinheiro


    Exercícios com For, While e DoWhile.
    
        Lista de Exercícios 5.5 [01]
        Lista de Exercícios 5.6 [02]

    Qual lista de exercícios você gostaria de verificar?
    ");
    int list = int.Parse(Console.ReadLine()!);
    switch (list)
    {
        case 1 or 01:
            Console.Clear();
            do
            {
                Console.Write(@"



    Lista 5.5; Exercícios com For, While e DoWhile.
           --- Exercícios Principais ---

      Exercício [02] - As alturas de Lucas e Pedro
      Exercício [03] - Tabuada por índice
      Exercício [04] - Identificadores de uma sequência de números
      Exercício [05] - Demonstração da sequência Fibonacci
      Exercício [06] - Equações para números par ou ímpar
      Exercício [07] - Mediana de sequência com números inteiros
      Exercício [09] - Registro de candidatos a vagas de emprego
      Exercício [10] - Cálculo de INSS e IRPF sobre salários

    Qual exercício gostaria de verificar ? 
    ");
                int exercise = int.Parse(Console.ReadLine()!);
                switch (exercise)
                {
                    case 2 or 02:
                        Console.Clear();
                        Console.WriteLine(@"



    Pedro tem 1,50m e cresce 2 cm por ano, enquanto Lucas tem 1,10m
    e cresce 3 cm por ano. Quantos anos serão necessários para que:
  
    a) Lucas e Pedro tenham o mesmo tamanho?;
    b) Lucas seja maior que Pedro?");
                        int pedro = 150;
                        int lucas = 110;
                        int time = 0;
                        while (lucas < pedro)
                        {
                            pedro += 2;
                            lucas += 3;
                            time++;
                        }
                        Console.ReadLine();
                        Console.WriteLine($"\n    Resposta:\n    Serão necessários {time} anos para Lucas e Pedro terem a mesma altura.");
                        Console.Write($"    Serão necessários {time + 1} anos para Lucas ser maior que Pedro.");
                        Console.ReadLine();

                        /* Observação:
                         * 
                         * O Prof. Clayton recomendou em sala, na aula do dia 10/05/2023 que 
                         * usássemos variáveis do tipo 'int', para esse exercício. Assim, ao
                         * invés de representarmos a altura de Lucas e Pedro por 1.10 e 1.50,
                         * devemos escrever eles em centímetros (110 e 150).
                         * 
                         * Antes de sua recomendação, eu havia tentado usar 'double', no lugar
                         * de 'int', mas isso parece afetar 'a precisão das operações de ponto
                         * flutuante'. Com isso, eu sempre obtinha a resposta "40 anos" para o
                         * item (a) desse exercício.
                         * 
                         * Pelo que entendi do que pesquisei, essas operações podem variar, a
                         * depender do hardware ou da implementação da linguagem de programa
                         * utilizada. Com isso, elas podem sofrer erros de precisão ao longo
                         * do tempo.
                         * 
                         * Da mesma forma que 2/3 é sempre mais preciso que 0.666..., numeros
                         * inteiros representas melhor seus valores do que em forma decimal.
                         * Usar variáveis do tipo constante pode minimizar esse tipo de problema.
                         */
                        break;
                    case 3 or 03:
                        Console.Clear();
                        int index, qtt;
                        Console.WriteLine("\n\n    Este algoritmo calcula e exibe a tabuada.");
                        Console.Write("    Digite o índice da tabuada: ");
                        index = int.Parse(Console.ReadLine()!);
                        Console.Write("    Digite a quantidade da tabuada: ");
                        qtt = int.Parse(Console.ReadLine()!);
                        for (int table = 0; table <= qtt; table++)
                        {
                            Console.WriteLine($"      {table} x {index} = {index * table}.");
                        }
                        Console.ReadLine();

                        /* Para cada iteração, o 'table' é incrementado, apresentando um novo
                         * número para ser multiplicado pelo índice escolhido pelo usuário.
                         * 
                         * O resultado de cada multiplicação é apresentado diretamente na 
                         * string, com a operação {index * table}.
                         */
                        break;

                    case 4 or 04:
                        Console.Clear();
                        Console.Write(@"




    A partir de um conjunto de números inteiros sequenciais,
    vamos identificar e apresentar:
  
    a) a quantidade de números inteiros e positivos.
    b) a quantidade de números pares.
    c) a quantidade de números ímpares.
    d) a quantidade de números ímpares e divisíveis por 3 e 7.
    e) a respectiva média para cada um dos itens. ");
                        int start, end;
                        Console.Write("\n    Digite o número inicial: ");
                        start = Convert.ToInt32(Console.ReadLine());
                        Console.Write("    Digite o número final: ");
                        end = Convert.ToInt32(Console.ReadLine());
                        int positive = 0, even = 0, odd = 0, divisible = 0;
                        // declarando cada item do exercício.
                        double sPositive = 0, sEven = 0, sOdd = 0, sDivisible = 0;
                        //declarando a soma de cada item, para responder o item (e)
                        for (int digit = start; digit <= end; digit++)
                        {
                            if (digit > 0) // poderia ser adicionado a condição (...&& i & i == 0),
                                           // mas como as incrementações adicionarão números inteiros,
                                           // isso se tornaria redundante;
                            {
                                positive++;
                                sPositive += digit;
                            }
                            if (digit % 2 == 0)
                            {
                                even++;
                                sEven += digit;
                            }
                            else
                            {
                                odd++;
                                sOdd += digit;
                            }
                            if (digit % 3 == 0 && digit % 7 == 0)
                            {
                                divisible++;
                                sDivisible += digit;
                            }
                        }
                        double mPositive = sPositive / positive;
                        double mEven = sEven / even;
                        double mOdd = sOdd / odd;
                        double mDivisible = sDivisible / divisible;
                        Console.Clear();
                        Console.WriteLine($"\n\n\n\n    A quantidade de números inteiros positivos é: " +
                            $"{positive}, e a média deles é: {mPositive}.");
                        Console.WriteLine($"    A quantidade de números pares é: {even}, e a " +
                            $"média deles é: {mEven}.");
                        Console.WriteLine($"    A quantidade de números ímpares é: {odd}, e " +
                            $"a média deles é: {mOdd}.");
                        Console.WriteLine($"    A quantidade de números divisíveis por 3 e 7 é: " +
                            $"{divisible}, e a média deles é: {mDivisible}.");

                        Console.ReadLine();
                        break;

                    case 5 or 05:
                        Console.Clear();
                        ulong last, first = 0, second = 1, next;
                        Console.WriteLine("\n\n\n\n    Este algoritmo escreve a sequência Fibonacci, no limite de termos que você inserir.");
                        Console.Write("    Digite o número de termos que deseja gerar dentro da sequência Fibonacci: ");
                        last = ulong.Parse(Console.ReadLine()!);
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Sequência Fibonacci: ");
                        for (ulong k = 1; k < last; k++)
                        {
                            if (k <= 1)
                            {
                                Console.Write($"|    {k} |");
                            }
                            else
                            {
                                next = first + second;
                                first = second; // se esta linha e a de baixo forem trocadas,
                                second = next; // o algoritmo será de progressão geométrica.
                                Console.Write($"    {next} |");
                            }
                        }
                        Console.ReadLine();
                        /* A cada iteração, o resultado obtido será sempre guardado em 'next' (com
                         * "second = next"), fazendo com que na próxima iteração, o resultado mais 
                         * recente seja o próprio valor obtido na iteração anterior adicionado ao último valor
                         * anterior a ele, guardado em 'first'.
                         */
                        break;
                    case 6 or 06:
                        Console.Clear();
                        Console.Write(@"



  Este algoritmo executa os seguintes cálculos:
  
  a) se 'n' for par, n = n ÷ 2;
  b) Se ""n"" for ímpar, n = n x 3 + 1. ");
                        Console.Write("\n    Digite um valor inteiro para 'n': ");
                        int n = int.Parse(Console.ReadLine()!);
                        do
                        {
                            if (n % 2 == 0)
                            {
                                Console.WriteLine($"    Quando 'n' = {n},\n  Equação (a): ");
                                n /= 2; // n = n / 2;
                                Console.WriteLine($"      n ÷ 2 = {n}.");
                            }
                            else
                            {
                                Console.WriteLine($"    Quando 'n' = {n},\n  Equação (b): ");
                                n = n * 3 + 1;
                                Console.WriteLine($"      n x 3 + 1 = {n}.");
                            }
                            Console.WriteLine($"    Logo, 'n' recebe {n}.\n");
                        } while (n != 1);
                        Console.ReadLine();
                        /* Usando o "Do...While", esse algoritmo usa o número de entrada fornecido
                         * pelo usuário como base para calcular as equações (a) ou (b), do enunciado 
                         * do exercício. 
                         * 
                         *    1. Se o número "n" digitado pelo usuário for diferente de 1 e par, ele 
                         *       executará a equação (a) primeiro, e, por conseguinte, vai dividir o 
                         *       número de entrada por 2. 
                         * 
                         *    2. Se o número "n" digitado pelo usuário for diferente de '1" e ímpar, 
                         *       ele executará a equação (b) primeiro, e, por conseguinte, multiplicará
                         *       o número de entrada por 3 adicionará +1 ao resultado.
                         * 
                         *    3. O algoritmo se repetirá, alternando entre as equações (a) e (b), a 
                         *       depender do resultado de "n" na última equação (isto é, se ele resultar 
                         *       em um número par ou ímpar).
                         * 
                         * Eventualmente, o resultado de uma das duas equações poderá ser "n = 2".
                         * Isso fará com que a equação (a) se repita, e o novo valor de "n" será 
                         * "n = 1". Com isso, o verificador "while" será ativado, pondo fim a novas
                         * iterações. O mesmo acontece se o número de entrada escolhido pelo usuário
                         * for "2", o que encerraria o algoritmo já na primeira iteração. Mas se a 
                         * equação resultar em um número diferente de 1, o laço de repetição continua.
                         */
                        break;
                    case 7 or 07:
                        Console.Clear();
                        Console.WriteLine("\n\n    Este algoritmo encontra a mediana de uma sequência de números inteiros.");
                        Console.Write("\n    Digite o número inicial da sequência: ");
                        int i = int.Parse(Console.ReadLine()!);
                        Console.Write("    Digite o número final da sequência: ");
                        double j = int.Parse(Console.ReadLine()!);
                        double sum;
                        // a variável 'sum' coletará os valores de cada algarismo da sequência;
                        double counter = 0;
                        // a variável 'counter' contará quantas iterações foram necessárias
                        // até se chegar no último número;
                        for (sum = 0; i <= j; i++)
                        {
                            sum += i;
                            Console.WriteLine("      " + i);
                            if (i != 0)
                            {
                                counter++;
                            }
                        }
                        double middle = sum / counter;
                        Console.WriteLine($"\n    A mediana da sequência de números é: {middle}.");
                        Console.ReadLine();
                        /* Haverá novas iterações enquanto 'i' for menor ou igual a 'j'. Para 
                         * cada iteração, i ganha +1, e o número que começou em 'i' ganha um 
                         * novo valor na sequência seguinte. A variável 'sum' vai guardar esses
                         * valores.
                         * 
                         * A mediana será a soma dos valores acumulados divido pela quantidade 
                         * de iterações, como em uma média aritmética.
                         * 
                         * Por fim, a mediana é apresentada para o usuário.
                         */
                        break;
                    case 9 or 09:
                        int male = 0, female = 0; // variáveis para contar o número de homens e mulheres.
                        int maleAge, femaleAge; // variáveis para identificar a idade de homens e mulheres.
                        int gentlemen = 0; // variável para contar o número de homens entre 35 e 45.
                        int minor = int.MaxValue; // vai ser usado para definir a menor idade entre as mulheres ***
                        double xpMenAge = 0.00; // vai guardar a soma da idade dos homens que tem experiência.
                        double xpMenCounter = 0.00; // vai contar a quantidade de homens que tem experiência.
                        double xpWomenAge = 0.00; // vai guardar a soma da idade das mulheres que tem experiência.
                        double xpWomenCounter = 0.00; // vai contar a quantidade de mulheres que tem experiência.
                        int education, elementary = 0, highSchool = 0, undergraduate = 0, graduate = 0;
                        double maleAverage, femaleAverage;
                        while (true)
                        {
                            Console.WriteLine("\n\n    Este algoritmo cadastra candidatos para uma empresa de recrutamento.");
                            Console.WriteLine("    Vamos registrar um novo candidato.\n");
                            Console.WriteLine("    Qual é o nível de escolaridade do candidato?.");
                            Console.WriteLine("    1. Ensino Fundamental.\n  2. Ensino Médio." +
                                "\n    3. Ensino Superior.\n  4. Pós-graduação.");
                            education = int.Parse(Console.ReadLine()!);
                            switch (education)
                            {
                                case 1: elementary++; break;
                                case 2: highSchool++; break;
                                case 3: undergraduate++; break;
                                case 4: graduate++; break;
                                default:
                                    Console.Write("\n    Entrada inválida. Tente novamente. ");
                                    continue;
                            }
                            Console.Write("\n    Informe o gênero do candidato." +
                                "\n    Pressione (M) para masculino." +
                                "\n    Pressione (F) para feminino. ");
                            string gender = Console.ReadLine()!.ToUpper();
                            switch (gender)
                            {
                                case "M" or "MASCULINO" or "HOMEM" or "1" or "01":
                                    male++;
                                    Console.Write("\n    Qual é a idade do candidato? ");
                                    maleAge = int.Parse(Console.ReadLine()!);
                                    if (maleAge >= 35 && maleAge <= 45)
                                    {
                                        gentlemen++;
                                    }
                                    Console.Write("\n    O candidato tem experiência na área?" +
                                            "\n    Responda (S) para sim, ou (N) para não. ");
                                    string yesOrNo = Console.ReadLine()!.ToUpper();
                                    if (yesOrNo == "S" || yesOrNo == "1")
                                    {
                                        xpMenCounter++;
                                        xpMenAge += maleAge;
                                    }
                                    break;
                                case "F" or "FEMININO" or "MULHER" or "2" or "02":
                                    female++;
                                    Console.Write("    Qual é a idade da candidata? ");
                                    femaleAge = int.Parse(Console.ReadLine()!);
                                    Console.Write("\n    A candidata tem experiência na área?" + "\n  Responda (S) para sim, ou (N) para não. ");
                                    yesOrNo = Console.ReadLine()!.ToUpper();
                                    if (yesOrNo == "S" || yesOrNo == "1")
                                    {
                                        xpWomenCounter++;
                                        xpWomenAge += femaleAge;
                                        if (femaleAge < minor)
                                        {
                                            minor = femaleAge;
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("    Não entendi bem. Poderia repetir?");
                                    break;
                            }
                            Console.WriteLine("\n    Deseja registrar um novo candidato?");
                            Console.Write("    Pressione (S) para sim ou (N) para não. \n");
                            string option = Console.ReadLine()!.ToUpper();
                            Console.Clear();
                            if (option == "N" || option == "2" || option == "2")
                            {
                                break;
                            }
                        }
                        double percentage = (gentlemen * 100.00) / male;
                        Console.WriteLine($"\n    a) O número de candidatos do sexo feminino é: {female}.");
                        Console.WriteLine($"    b) O número de candidatos do sexo masculino é: {male}.");
                        if (xpMenCounter != 0)
                        {
                            maleAverage = xpMenAge / xpMenCounter;
                            Console.WriteLine($"    c) A idade média dos homens com experiência é: {maleAverage}.");
                        }
                        else
                        {
                            Console.WriteLine($"    c) A idade média dos homens com experiência é: 0.");
                        }
                        if (xpWomenCounter != 0)
                        {
                            femaleAverage = xpWomenAge / xpWomenCounter;
                            Console.WriteLine($"    d) A idade média das mulheres com experiência é: {femaleAverage}.");
                        }
                        else
                        {
                            Console.WriteLine($"    d) A idade média das mulheres com experiência é: 0.");
                        }
                        if (gentlemen > 0)
                        {
                            Console.WriteLine($"    e) A porcentagem dos homens entre 35 e 45 anos é: {percentage}%.");
                        }
                        else
                        {
                            Console.WriteLine($"    e) A porcentagem dos homens entre 35 e 45 anos é: 0%.");
                        }
                        if (female != 0)
                        {
                            Console.WriteLine($"    f) A menor idade entre as mulheres que já tem experiência no serviço é: {minor}.");
                        }
                        else
                        {
                            Console.WriteLine($"    f) Não houve registro de candidatas mulheres.");
                        }
                        break;
                    case 10:
                        double wage; // indica o valor do salário sem nenhum desconto.
                        double payroll = 0; // soma o total da folha de pagamento da empresa.
                        double discount; // indica os descontos do INSS sobre o salário.
                        double rate; // indica os descontos do IRPF sobre o salário
                        double social; // soma os valores dos descontos do INSS de cada faixa de progressão.
                        double tax; // soma os valores dos descontos do IRPF de cada faixa de progressão.
                        double salary; // indica o valor do salário com os descontos do INSS.
                        double income; // indica o valor do salário com os descontos do INSS e do IRPF.
                        double tax_range1 = 1903.98, tax_range2 = 2826.65, tax_range3 = 3751.05, tax_range4 = 4664.68;
                        // tax_range: indicam as faixas de progressão do IRPF;
                        double ss_range1 = 1556.94, ss_range2 = 2594.92, ss_range3 = 5189.82;
                        // ss_range: indicam as faixas de progressão do INSS;
                        int counting = 0; // servirá apenas para indicar quantas entradas de salários de funcionários foram dadas.
                        double total_tax = 0; // servirá para calcular o valor total de imposto de renda que a empresa deve recolher.
                        Console.WriteLine("\n\n    Cálculo dos descontos do INSS e do IRPF sobre o salário.");
                        while (true)
                        {
                            social = 0;
                            tax = 0;
                            {
                                counting++;
                                Console.Clear();
                                Console.Write($"\n\n    Digite o salário do {counting}º funcionário: ");
                                wage = int.Parse(Console.ReadLine()!);
                                payroll += +wage;
                                if (wage <= ss_range1)
                                {
                                    discount = wage * 0.08;
                                    social += discount;
                                    string discountF = discount.ToString("C");
                                    Console.Write($"\n    Na faixa de contribuição até R${Math.Round(ss_range1, 2)}, a alíquota do INSS é 8%, e o valor descontado é: {discountF}.");
                                }
                                if (wage > ss_range1 && wage <= ss_range2)
                                {
                                    discount = ss_range1 * 0.08;
                                    social += discount;
                                    string discountF = discount.ToString("C");
                                    Console.Write($"\n    Na faixa de contribuição R${Math.Round(ss_range1, 2)}, a alíquota do INSS é de 8%, e o valor descontado é: {discountF}.");
                                    discount = (wage - ss_range1) * 0.09;
                                    social += discount;
                                    discountF = discount.ToString("C");
                                    Console.WriteLine($"    Na faixa de contribuição R${Math.Round(ss_range2, 2)}, a alíquota do INSS é de 9%, e o valor descontado é: {discountF}.");
                                }
                                if (wage > ss_range2 && wage <= ss_range3)
                                {
                                    discount = ss_range1 * 0.08;
                                    social += discount;
                                    string discountF = discount.ToString("C");
                                    Console.WriteLine($"\n    Na faixa de contribuição R${Math.Round(ss_range1, 2)}, a alíquota do INSS é 08%, e o valor descontado é: {discountF}.");
                                    discount = (ss_range2 - ss_range1) * 0.09;
                                    social += discount;
                                    discountF = discount.ToString("C");
                                    Console.WriteLine($"    Na faixa de contribuição R${Math.Round(ss_range2, 2)}, a alíquota do INSS é 09%, e o valor descontado é: {discountF}.");
                                    discount = (wage - ss_range2) * 0.11;
                                    social += discount;
                                    discountF = discount.ToString("C");
                                    Console.WriteLine($"    Na faixa de contribuição R${Math.Round(ss_range1, 2)}, a alíquota do INSS é 11%, e o valor descontado é: {discountF}.");
                                }
                                if (wage > ss_range3)
                                {
                                    discount = ss_range1 * 0.08;
                                    social += discount;
                                    string discountF = discount.ToString("C");
                                    Console.WriteLine($"\n    Na faixa de contribuição R${Math.Round(ss_range1, 2)}, a alíquota do INSS é 08%, e o valor descontado é: {discountF}.");
                                    discount = (ss_range2 - ss_range1) * 0.09;
                                    social += discount;
                                    discountF = discount.ToString("C");
                                    Console.WriteLine($"    Na faixa de contribuição R${Math.Round(ss_range2, 2)}, a alíquota do INSS é 09%, e o valor descontado é: {discountF}.");
                                    discount = (ss_range3 - ss_range2) * 0.11;
                                    social += discount;
                                    discountF = discount.ToString("C");
                                    Console.WriteLine($"    Na faixa de contribuição R${Math.Round(ss_range1, 2)}, a alíquota do INSS é 11%, e o valor descontado é: {discountF}.");
                                }
                                salary = wage - social; ;
                                string wageF = wage.ToString("C");
                                string salaryF = salary.ToString("C");
                                Console.WriteLine($"\n    O total de descontos do INSS sobre o salário de {wageF} deste funcionário é de: R$ {Math.Round(social, 2)}.");
                                Console.WriteLine($"    O salário deste funcionário com os descontos do INSS é: {salaryF}.");
                                if (salary <= tax_range1)
                                {
                                    string noTax = salary.ToString("C");
                                    Console.WriteLine($"\n    Não incide o IRPF sobre essa faixa salarial. Portanto, o salário líquido é: {noTax}.");
                                }
                                if (salary > tax_range1 && salary <= tax_range2)
                                {
                                    rate = (salary * 0.075) - 142.80;  // parcela a deduzir do IRPF, nessa faixa de progressão;
                                    tax += rate;
                                    string taxF = tax.ToString("C");
                                    Console.WriteLine($"\n    Incidem {taxF} de IRPF sobre o salário informado.");
                                }
                                if (salary > tax_range2 && salary <= tax_range3)
                                {
                                    rate = (salary * 0.15) - 354.80;
                                    tax += rate;
                                    string taxF = tax.ToString("C");
                                    Console.WriteLine($"\n    Incidem {taxF} de IRPF sobre o salário informado.");
                                }
                                if (salary > tax_range3 && salary <= tax_range4)
                                {
                                    rate = (salary * 0.225) - 636.13;
                                    tax += rate;
                                    string taxF = tax.ToString("C");
                                    Console.WriteLine($"\n    Incidem {taxF} de IRPF sobre o salário informado.");
                                }
                                if (salary > tax_range4)
                                {
                                    rate = (salary * 0.275) - 869.36;
                                    tax += rate;
                                    string taxF = tax.ToString("C");
                                    Console.WriteLine($"\n    Incidem {taxF} de IRPF sobre o salário informado.");
                                }
                                income = salary - tax;
                                string incomeF = income.ToString("C");
                                Console.WriteLine($"\n    O salário líquido deste funcionário será {incomeF}.");
                                string sheet = payroll.ToString("C");
                                Console.WriteLine($"    O valor total da folha de pagamento da empresa será: R$ {sheet}.");
                                total_tax += tax;
                                string total = total_tax.ToString("C");
                                Console.WriteLine($"    O valor total do imposto de renda que a empresa deve recolher é: {total}.");
                            }
                            Console.ReadLine();
                            Console.WriteLine("\n    Deseja calcular os descontos para um novo salário?");
                            Console.WriteLine("    Pressione '1' para sim ou '2' para não.\n");
                            int option = int.Parse(Console.ReadLine()!);
                            if (option == 2)
                            {
                                break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("    Desculpa, eu não entendi. Poderia repetir?");
                        break;
                }
                Console.Clear();
                Console.Write("\n\n\n\n    Selecionar outro exercício ou sair?");
                Console.Write("    Digite [sim] ou [não].\n");
                string exit = Console.ReadLine()!.ToLower();
                if (exit == "nao" || exit == "não" || exit == "2" || exit == "n")
                {
                    break;
                }
                Console.Clear();
            } while (true);
            break;
        case 2 or 02:
            Console.Clear();
            do
            {
                Console.Write(@"



    Lista 5.6; Exercícios com For, While e DoWhile
          --- Exercícios Complementares ---

      Exercício [01] - Contagem de números em conjuntos
      Exercício [02] - Registro de candidatos em censo
      Exercício [03] - Cálculo de fatorial de um número
      Exercício [04] - Cálculo dos expoentes
      Exercício [06] - Cálculo de números primos
      Exercício [07] - Máximo Divisor Comum (M.D.C.)
      Exercício [08] - Números Perfeitos em um conjunto
      Exercício [09] - Linhas dos Trens A e B
      Exercício [10] - Conceito de notas de alunos

  Qual exercício gostaria de verificar ? ");
                int exercise = int.Parse(Console.ReadLine()!);
                switch (exercise)
                {
                    case 1 or 01:
                        Console.Clear();
                        int start;
                        Console.WriteLine(@"  



    Este algoritmo faz contagem de números em um intervalo 
    fornecido pelo usuário, e conta quantos números estão em
    intervalos específicos, descritos no exercício. ");
                        Console.WriteLine("\n    Por favor, digite um número de início da sequência: ");
                        start = int.Parse(Console.ReadLine()!);
                        Console.WriteLine("    Por favor, digite um número de fim da sequência: ");
                        int j = int.Parse(Console.ReadLine()!);
                        int groupOne = 0, groupTwo = 0, groupThree = 0, groupFour = 0;
                        for (int i = start; i <= j; i++)
                        {
                            if (i >= 0 && i <= 25.9)
                            { groupOne++; }
                            if (i >= 26 && i <= 50.9)
                            { groupTwo++; }
                            if (i >= 51 && i <= 75.9)
                            { groupThree++; }
                            if (i >= 76 && i <= 100)
                            { groupFour++; }
                        }
                        Console.WriteLine($"    Há {groupOne} números no interalo entre [0 e 25.9];");
                        Console.WriteLine($"    Há {groupTwo} números no interalo entre [26 e 50.9];");
                        Console.WriteLine($"    Há {groupThree} números no interalo entre [51 e 75.9];");
                        Console.WriteLine($"    Há {groupFour} números no interalo entre [76 e 100].");
                        Console.ReadLine();
                        break;
                    case 2 or 02:
                        Console.Clear();
                        int age, ageSum = 0, people = 0, counter = 0;
                        double weight, weightSum = 0, height, heightSum = 0;
                        int men = 0, women = 0, dark = 0, brown = 0, blond = 0, red = 0, green = 0, blue = 0, chestnut = 0, elvish = 0;
                        while (true)
                        {
                            counter++;
                            Console.Write(@"  



    Registro de participantes para o censo regional!
    Olá! Importa-se de responder algumas perguntas? ");
                            {
                                people++;
                                Console.Write("    Qual é a sua idade? ");
                                age = int.Parse(Console.ReadLine()!);
                                ageSum += age;
                                Console.Write("    Quanto você pesa?\n  Favor informar o peso em kg (quilogramas). ");
                                weight = int.Parse(Console.ReadLine()!);
                                weightSum += weight;
                                Console.Write("    Qual é a sua altura?\n  Favor informar em cm (centímetros). ");
                                height = int.Parse(Console.ReadLine()!);
                                heightSum += height;
                                Console.Write("    Qual é o seu gênero?\n  Masculino ou Feminino? ");
                                string gender = Console.ReadLine()!.ToLower();
                                switch (gender)
                                {
                                    case "masculino" or "homem" or "m" or "1" or "01":
                                        men++;
                                        break;
                                    case "feminino" or "mulher" or "f" or "2" or "02":
                                        women++;
                                        break;
                                    default:
                                        Console.Write("    Não entendi. Poderia repetir? ");
                                        break;
                                }
                                Console.Write("    De que cor são os seus cabelos?\n  Louros, Castanhos, Negros ou Ruivos? ");
                                string hair = Console.ReadLine().ToLower();
                                blond = 0;
                                switch (hair)
                                {
                                    case "louros" or "louro" or "loiros" or "louro" or "1" or "01":
                                        blond++;
                                        break;
                                    case "castanho" or "castanhos" or "marrom" or "marrons" or "2" or "02":
                                        brown++;
                                        break;
                                    case "negros" or "negro" or "pretos" or "preto" or "3" or "03":
                                        dark++;
                                        break;
                                    case "ruivos" or "ruivo" or "4" or "04":
                                        red++;
                                        break;
                                    default:
                                        Console.WriteLine("    Eu não entendi. Poderia repetir?");
                                        break;
                                }
                                Console.WriteLine("    De que cor são seus olhos?\n  Verdes, azuis ou castanhos?");
                                string eyes = Console.ReadLine()!.ToLower();
                                switch (eyes)
                                {
                                    case "verdes" or "verde" or "1" or "01":
                                        green++;
                                        if (blond > 0)
                                        {
                                            elvish++;
                                        }
                                        break;
                                    case "castanhos" or "pretos" or "marrons" or "3" or "03":
                                        chestnut++;
                                        break;
                                    case "azuis" or "azul" or "2" or "02":
                                        blue++;
                                        break;
                                }
                                Console.Clear();
                                Console.Write("\n    Deseja entrevistar mais alguém?\n    Se sim, aperte 1;\n    Se deseja encerrar, aperte -1. ");
                                int option = int.Parse(Console.ReadLine()!);
                                if (option == -1)
                                {
                                    break;
                                }
                            }
                        }
                        double ageAverage = ageSum / people;
                        double weightAverage = weightSum / people;
                        string ponderatio = weightAverage.ToString("C");
                        double heightAverage = heightSum / people;
                        double menAverage = (men * 100) / people;
                        double womenAverage = (women * 100) / people;
                        Console.WriteLine($"\n    a) A média da idade dos participantes é: {ageAverage} anos.");
                        Console.WriteLine($"    b) A média de peso dos participantes é: {ponderatio} kgs.");
                        Console.WriteLine($"    c) A média de altura dos participantes é: {heightAverage} cms.");
                        Console.WriteLine($"    d) A percentagem de pessoas do sexo feminino é: {womenAverage}%.");
                        Console.WriteLine($"    e) A percentagem de pessoas do sexo masculino é: {menAverage}%.");
                        Console.WriteLine($"    f) Um total de [{elvish}] pessoas possuem olhos verdes e cabelos louros.");
                        break;
                    case 3 or 03:
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Este algoritmo calcula e exibe o fatorial de um número.");
                        Console.Write("    Digite um número inteiro e positivo: ");
                        ulong number = ulong.Parse(Console.ReadLine()!);
                        ulong factorial = 1, f;
                        if (number < 0)
                        {
                            Console.WriteLine("\n    Número ínválido. Por favor, digite um número >= 0.");
                        }
                        else if ((number == 0) || (number == 1))
                        {
                            Console.WriteLine($"\n    {number}! = 1.");
                        }
                        else
                        {
                            for (f = number; f >= 1; f--)
                            {
                                Console.WriteLine($"\n    {factorial} × {f} = ");
                                factorial *= f;
                                Console.WriteLine($"    {factorial}");
                            }
                            Console.WriteLine($"\n    O fatorial {number}! = {factorial}.");
                        }
                        Console.ReadLine();
                        break;
                    case 4 or 04:
                        Console.Clear();
                        Console.WriteLine($"\n\n\n\n    Este algoritmo realiza a potência de um número inteiro por outro.");
                        Console.Clear();
                        Console.WriteLine($"\n\n\n\n    Digite o número de base: ");
                        ulong numerus = ulong.Parse(Console.ReadLine()!);
                        Console.Clear();
                        Console.WriteLine($"\n\n\n\n    Digite o número do expoente: ");
                        ulong power = ulong.Parse(Console.ReadLine()!);
                        Console.Clear();
                        ulong result = 1, previous;
                        for (ulong i = 0; i < power; i++)
                        {
                            if (i < 1)
                            {
                                result *= numerus;
                                Console.WriteLine($"\n\n\n\n    {numerus} × 1 = {result}.");
                            }
                            else
                            {
                                previous = result;
                                result *= numerus;
                                Console.WriteLine($"    {numerus} × {previous} = {result}.");
                            }
                        }
                        Console.WriteLine($"\n    O resultado da potência [{numerus}^{power}] é: {result}.");
                        Console.ReadLine();
                        break;
                    case 6 or 06:
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Este algoritmo mostra se um dado número é primo.\n    I.e., se ele é divisível apenas por 1 ou ele mesmo.");
                        Console.Write("    Digite um número inteiro positivo: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (input < 0)
                        {
                            Console.WriteLine("\n\n\n\n    Número inválido.");
                            Console.WriteLine("    Números negativos não podem ser primos.");
                            Console.WriteLine("    Por favor, digite um número inteiro positivo. ");
                        }
                        else if (input == 0)
                        {
                            Console.WriteLine("\n\n\n\n    O número 0 não é primo, pois é divisível por qualquer número.");
                        }
                        else if (input == 1)
                        {
                            Console.WriteLine("\n\n\n\n    O número 1 não é primo, pois apenas é divisível por ele mesmo.");
                        }
                        else
                        {
                            int divisor = 0;
                            for (int i = 2; i < input; i++)
                            {
                                if (input % i == 0)
                                {
                                    divisor++; // vai indicar que número foi divisível por um número além dele mesmo.
                                    break;
                                }
                            }
                            if (divisor > 0)
                            {
                                Console.WriteLine($"\n\n\n\n    O número [{input}] não é primo.");
                            }
                            else
                            {
                                Console.WriteLine($"\n\n\n\n    O número [{input}] é primo.");
                            }
                        }
                        Console.ReadLine();
                        break;
                    case 7 or 07:
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Este algoritmo calcula o M.D.C. entre 2 números.");
                        Console.Write("    Por favor, digite o valor de A: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("    Digite o valor de B: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        int A = a, B = b, mdc, novum;
                        while (b != 0)
                        {
                            novum = b;
                            b = a % b;
                            a = novum;
                        }
                        mdc = a;
                        Console.Clear();
                        Console.WriteLine($"\n\n\n\n    O máximo divisor comum (M.D.C.) entre {A} e {B} é: {mdc}.");
                        Console.ReadLine();
                        break;
                    case 8 or 08:
                        Console.Clear();
                        Console.WriteLine(@"
        


    Este algoritmo verifica quais são os números perfeitos em um conjunto de números inteiros.");
                        Console.Write("    Informe o número inicial do conjunto: ");
                        int debut = int.Parse(Console.ReadLine()!);
                        Console.Write("    Informe o número final do conjunto: ");
                        int fin = int.Parse(Console.ReadLine()!);
                        Console.WriteLine("    Números perfeitos no conjunto: ");
                        for (int numero = debut; numero <= fin; numero++)
                        {
                            int sommeDiviseurs = 0;
                            for (int i = 1; i < numero; i++)
                            {
                                if (numero % i == 0)
                                {
                                    sommeDiviseurs += i;
                                }
                            }
                            if (sommeDiviseurs == numero)
                            {
                                Console.WriteLine($"    {numero} ");
                            }
                        }
                        Console.ReadLine();
                        break;
                    case 9 or 09:
                        Console.Clear();
                        Console.Write(@"



    Considere uma linha férrea que ligue as cidades A e B. Existe
    um trem M, partindo da cidade A a uma velocidade constante de 
    80 km/h, em direção à cidade B. Há, ainda um trem N, partindo
    da cidade B, a uma velocidade também constante de 100 km/h, e
    viajando em direção à cidade A. Este algoritmo calcula o tempo
    necessário (em minutos) para os trens se encontrarem, a partir 
    de uma dada distância entre as cidades fornecida pelo usuário,
    informando também quantos quilômetros foram percorridos por 
    eles até este encontro. ");
                        Console.Write("\n    Informe a distância entre as cidades (em quilômetros): ");
                        int distance = int.Parse(Console.ReadLine()!);
                        int trainA_speed = 80;  // km/h (quilômetros por hora);
                        int trainB_speed = 100; // km/h (quilômetros por hora);
                        int meetingTime = 0; // horário em que os dois trens se encontrarem;
                        int trainA_distance = 0; // começa da distância inicial, e será incrementado com trainA_speed;
                        int trainB_distance = distance; // ele começa da distância final, e será decrementado com trainB_speed;
                        while (trainA_distance < trainB_distance) // quando o trem A alcançar o B, o meetingTime para de ser incrementado;
                        {
                            trainA_distance += trainA_speed;
                            trainB_distance -= trainB_speed;
                            meetingTime++; // será incrementado em horas, e multiplicado depois por 60 para se achar os minutos;
                        }
                        int tempoMinutos = meetingTime * 60; // para transformar as horas em minutos.
                        int finalDistance = distance - trainB_distance;
                        Console.Clear();
                        Console.WriteLine($"\n\n\n\n    Tempo necessário para os trens se encontrarem: {tempoMinutos} minutos.");
                        Console.WriteLine($"    O trem A percorreu {trainA_distance} quilômetros.");
                        Console.WriteLine($"    O trem B percorreu {finalDistance} quilômetros.");
                        Console.ReadLine();
                        break;
                    case 10:
                        Console.Clear();
                        double scoreA = 0, scoreB = 0, scoreC = 0, scoreD = 0, scoreE = 0;
                        double gradeSum = 0;
                        Console.Write(@"



    Este algoritmo apresenta o conceito de nota dos alunos,
    com base na nota que eles alcançaram: ");
                        Console.Write("\n    Digite quantos alunos há nesta turma: ");
                        int students = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= students; i++)
                        {
                            Console.Write($"    Digite a nota do {i}º aluno de 0 a 10: ");
                            double grade = Convert.ToDouble(Console.ReadLine());
                            gradeSum += grade;
                            if (grade >= 0 && grade < 3)
                            {
                                Console.Write($"    O conceito de nota deste aluno é: [E]. \n");
                                scoreE++;
                            }
                            else if (grade >= 3 && grade < 5)
                            {
                                Console.Write($"    O conceito de nota deste aluno é: [D]. \n");
                                scoreD++;
                            }
                            else if (grade >= 5 && grade < 7)
                            {
                                Console.Write($"    O conceito de nota deste aluno é: [C]. \n");
                                scoreC++;
                            }
                            else if (grade >= 7 && grade < 9)
                            {
                                Console.Write($"    O conceito de nota deste aluno é: [B]. \n");
                                scoreB++;
                            }
                            else if (grade >= 9 && grade <= 10)
                            {
                                Console.Write($"    O conceito de nota deste aluno é: [A]. \n");
                                scoreA++;
                            }
                            else
                            {
                                Console.Write("    Esta nota é inválida.\n  Por favor, digite um número de 0 a 10.\n");
                                i--;
                            }
                        }
                        double average = (gradeSum / students);
                        Console.WriteLine($"    O total de alunos com conceito [A] é: {scoreA}");
                        Console.WriteLine($"    O total de alunos com conceito [B] é: {scoreB}");
                        Console.WriteLine($"    O total de alunos com conceito [C] é: {scoreC}");
                        Console.WriteLine($"    O total de alunos com conceito [D] é: {scoreD}");
                        Console.WriteLine($"    O total de alunos com conceito [E] é: {scoreE}");
                        Console.WriteLine($"\n    A média aritmética do alunos desta turma é: {average}.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Write("    Desculpa, eu não entendi. Poderia repetir? ");
                        break;
                }
                Console.Clear();
                Console.WriteLine("\n\n\n\n      Selecionar outro exercício ou sair?");
                Console.WriteLine("      Digite [sim] ou para [não].\n");
                string sortie = Console.ReadLine()!.ToLower();
                if (sortie == "nao" || sortie == "não" || sortie == "2" || sortie == "n")
                {
                    break;
                }
                Console.Clear();
            } while (true);
            break;
        default:
            Console.Write("    Desculpa, eu não entendi. Poderia repetir? ");
            break;
    }
    Console.Clear();
    Console.WriteLine("\n\n\n\n      Selecionar outra lista ou encerrar?");
    Console.Write("      Se deseja encerrar, digite 'sair'.\n    ");
    string uscita = Console.ReadLine()!.ToLower();
    if (uscita == "sair")
    {
        break;
    }
    Console.Clear();
}
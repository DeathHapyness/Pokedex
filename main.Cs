//mensagem inicial
            Console.WriteLine("----------Pokedex----------");
            Console.WriteLine("Prencha com os dados do pokemon");

            //tipos de sintaxe 
            string nomeDoPokemon, tipo;
            double ataque, defesa ;
            int nivel, pontosDeVida;

            {
                //strings
                Console.Write("Digite o nome do pokemon:");
                nomeDoPokemon = Console.ReadLine();

                Console.Write("Digite o tipo do pokemon:");
                tipo = Console.ReadLine();

                //double
                Console.Write("Digite a quantia de defesa:"); //pede a quantida de ataque do pokemon "Double"
                defesa = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o ataque do pokemon:");
                ataque = Convert.ToDouble(Console.ReadLine());

                //int
                Console.Write("Digite o nivel do pokemon:");
                nivel = Convert.ToInt16(Console.ReadLine());

                Console.Write("Digite os pontos de vida do pokemon:");
                pontosDeVida = Convert.ToInt16(Console.ReadLine());

                //faz aprecer no terminal
                Console.WriteLine("Resumo do pokemon:");
                Console.WriteLine("Nome do pokmeon:" + nomeDoPokemon);
                Console.WriteLine("Tipo do pokemon:" + tipo);
                Console.WriteLine("Digite a quantiade de defesa:" + defesa);
                Console.WriteLine("Digite a quantiade de ataque:" + ataque);
                Console.WriteLine("Digite o nivel do pokemon:" + nivel);
                Console.WriteLine("Digite a quantiade de pontos de vida que o pokemon tem:" + pontosDeVida)

            Console.ReadKey();

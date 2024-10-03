using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
    internal class Atributos
    {
        //atributos
        private int força;
        private int agilidade;
        private int intelecto;
        private int vigor;
        private int presença;

        //construtor
        public Atributos(int força, int agilidade, int intelecto, int vigor, int presença)
        {
            this.força = força;
            this.agilidade = agilidade;
            this.intelecto = intelecto;
            this.vigor = vigor;
            this.presença = presença;
        }

        //métodos getters e setters
        //get
        public int getForça() { return this.força; }
        public int getAgilidade() { return this.agilidade; }
        public int getIntelecto() { return this.intelecto; }
        public int getVigor() { return this.vigor; }
        public int getPresença() { return this.presença; }

        //set
        public void setForça(int força) { this.força = força; }
        public void setAgilidade(int agilidade) { this.agilidade = agilidade; }
        public void setIntelecto(int intelecto) { this.intelecto = intelecto; }
        public void setVigor(int vigor) { this.vigor = vigor; }
        public void setPresença(int presença) { this.presença = presença; }
    }

    internal class Personagem
    {
        // Atributos
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int Nivel { get; set; }
        public int Experiencia { get; set; }
        public Atributos Atributos { get; set; }
        public double vida = 100;
        public int experienciaNecessaria = 1000;

    //construtor
    public Personagem(string nome, string classe)
    {
        Nome = nome;
        Classe = classe;
        Nivel = 1;
        Experiencia = 0;
        Atributos = new Atributos(10, 10, 10, 10, 10); // Valores iniciais dos atributos
    }

    //métodos
    public void Atacar(Personagem alvo)
    {
        // Calcula o dano baseado na força do atacante e agilidade do alvo
        int dano = Atributos.getForça() - alvo.Atributos.getAgilidade() / 2;

        // Garante que o dano nunca seja negativo
        if (dano < 0)

            dano = 0;

        Console.WriteLine($"{Nome} ataca {alvo.Nome} e causa {dano} de dano!");

        // Reduz a vida do alvo
        //alvo.Vida -= dano;

    }

    public void SubirNivel()
    {
        Nivel++;
        Console.WriteLine($"{Nome} subiu para o nível {Nivel}!");

        // Aumenta os atributos do personagem, aqui como um exemplo, aumenta 2 pontos em cada atributo
        Atributos.setForça(Atributos.getForça() + 2);
        Atributos.setAgilidade(Atributos.getAgilidade() + 2);
        Atributos.setIntelecto(Atributos.getIntelecto() + 2);
        Atributos.setVigor(Atributos.getVigor() + 2);
        Atributos.setPresença(Atributos.getPresença() + 2);
    }

    public void GanharExperiencia(int xp)
    {
        Experiencia += xp;
        Console.WriteLine($"{Nome} ganhou {xp} de experiência!");
        if (xp >= experienciaNecessaria)
        {
            Console.WriteLine($"{Nome} Upou para {Nivel + 1}!!");
            experienciaNecessaria = experienciaNecessaria * 2;
            xp = 0;
        }

        // Verifica se o jogador tem experiência suficiente para subir de nível
        // Implementar lógica de quanto XP é necessário por nível
    }
        public void status(int xp, string nome, string classe,int Força, int Agilidade, int intelecto, int vigor, int presença, int Nivel)
        {
            Console.WriteLine("----------------------------------");
            Console.Write($"Nome: {nome}");
            Console.Write($"\tClasse: {Classe}");
            Console.Write($"\nNível: {Nivel}");
            Console.Write($"\tExperiência: {xp}");
            Console.WriteLine("\n\n ----------------- ATRIBUTOS -----------------");
            
            
            Console.Write($" | Força: {Força}"); Console.Write($"\tAgilidade: {Agilidade}"); Console.Write($"\tIntelecto: {intelecto} |");
            Console.Write($"\n |\t    Vigor {vigor} \t Presença {presença}\t     |");
            Console.Write("\n ---------------------------------------------");
        }

}

class Program
{
    static void Main(string[] args)
    {
        // Criando os personagens
        Personagem jogador1 = new Personagem("Player", "Combatente");
        Personagem inimigo = new Personagem("Zumbi de sangue", "Monstro");

        // Simulando um combate
        jogador1.Atacar(inimigo);
        inimigo.Atacar(jogador1);

        // Simulando ganho de experiência e subida de nível
        jogador1.GanharExperiencia(1000);
        jogador1.SubirNivel();

            Console.Write("\n");
            jogador1.status(100,"Murilo","Combatente",12,12,4,8,10,2);
        Console.ReadKey();
    }
}
}
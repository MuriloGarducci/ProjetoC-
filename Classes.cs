using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto02 { 
	
	enum Classes
    {
		Combatente, Ocultista, Especialista,Rtimista
    }
	Protected class Classes
    {
		private Classes Combatente;
		private Classes Ocultista;
		private Classes Especialista;
		private Classes Ritmista;

		public Classes Escolher(Classes)
        {
			Console.WriteLine("Escolha sua Classe!");
			Console.Write("Combatente  \t Ocultitsta\nEspecialista  \t Ritmista");
			String EscolhaClasse = Console.ReadLine();
			if (EscolhaClasse == "Combatente")
        }
    }
	
}

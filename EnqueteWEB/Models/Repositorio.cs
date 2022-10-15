using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnqueteWEB.Models
{
    public class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta>Respostas { get { return respostas; } }
        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }
        
        static Repositorio()
        {
            respostas.Add(new Resposta()
            { Nome = "Fulano", Email = "fulano@gmail.com", Sim = true });
            respostas.Add(new Resposta()
            { Nome = "Ciclano", Email = "Ciclano@gmail.com", Sim = false });
            respostas.Add(new Resposta()
            { Nome = "Beltrano", Email = "Beltrano@gmail.com", Sim = true });
        }
    }
       
}


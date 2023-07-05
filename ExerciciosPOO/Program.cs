using ExerciciosPOO;
using System.Linq;

internal class Program {
    private static void Main(string[] args) {
        Animal pedro = new("pedro", "pedro");
        Animal carlos = new("carlos", "carlos");
        Animal marcos = new("marcos", "marcos");
        Animal leandro = new("leandro", "leandro");
        AnimalOrcamento pedroOrcamento = new(pedro, "vacina w", 300);
        AnimalOrcamento carlosOrcamento = new(carlos, "vacina y", 300);
        AnimalOrcamento marcosOrcamento = new(marcos, "vacina z", 300);
        AnimalOrcamento leandroOrcamento = new(leandro, "vacina w", 300);

        AnimalOrcamento[] turma = new AnimalOrcamento[4];
        turma[0] = (pedroOrcamento);
        turma[1] = (marcosOrcamento);
        turma[2] = (carlosOrcamento);
        turma[3] = (leandroOrcamento);

        
        foreach(AnimalOrcamento animalretornado in AnimalOrcamento.RetornaRegistroHistorico(turma, "vacina w")) {
            Console.WriteLine(animalretornado.AnimalInstance.Nome);
            Console.WriteLine(animalretornado.Historico);
        }

    }
}

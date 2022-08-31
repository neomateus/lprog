using System;
using Modelos;

class Aula3{
  public static void print(Aluno aluno){
    Console.WriteLine(
      "-----------------------------\n" +
      "Matricula: " + aluno.matricula + "\n" +
      "Nome: " + aluno.nome + "\n" +
      "Periodo: " + aluno.periodo + "\n" +
      "----------------------------"
    );
  }

  public static void print(Disciplina disciplina){
    Console.WriteLine(
      "----------------------------\n" +
      "Nome: " + disciplina.nome + "\n" +
      "Semestre: " + disciplina.semestre + "\n" +
      "---------------------------"
    );
  }
  public static void Main(string[] args){
    Aluno aluno1 = new Aluno{
      matricula = "2021ENEL123",
      nome = "Davi",
      periodo = 0
    };
    print(aluno1);
    Aluno aluno2 = new Aluno();
    print(aluno2);
    Aluno aluno3 = new Aluno(2);
    print(aluno3);
    Aluno aluno4 = new Aluno("2021ENEL456","Breno");
    print(aluno4);
    Aluno aluno5 = new Aluno("2021ENEL789","NaoePossivel",3);
    print(aluno5);

    Disciplina disciplina1 = new Disciplina (0);

    Disciplina disciplina2 = new Disciplina (11);

    print(disciplina1);
    print(disciplina2);
  }
}
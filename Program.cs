namespace JogoRPG
{
  public class Program
  {
    public static void Main()
    {
      var dado = new Random();

      
      while (true)
      {
        Console.WriteLine("Qual dado você deseja usar? Opções: Orlog, Fallout e Dado normal");
        var estiloDeJogo = Console.ReadLine();
        if (estiloDeJogo == "Orlog")
        {
          switch (dado.Next(1, 6))
          {
            case 1:
              Console.WriteLine("Ataque- O Machado");
              break;
            case 2:
              Console.WriteLine("Defesa e contra ataque corpo a corpo- O Elmo");
              break;
            case 3:
              Console.WriteLine("Ataque a distância- o Arqueiro");
              break;
            case 4:
              Console.WriteLine("Defesa e contra ataque distância- O Escudo");
              break;
            case >= 5:
              Console.WriteLine("Roubar fichas do outro jogador- O Ladrão");
              break;            
          }
          break;
        }
        if (estiloDeJogo == "Fallout")
        {       
          switch (dado.Next(1, 6))
          {
            case 1:
              Console.WriteLine("Um de dano");
              break;
            case 2:
              Console.WriteLine("Dois de dano");
              break;
            case <= 4:
              Console.WriteLine("Nada acontece");
              break;
            case <= 5:
              Console.WriteLine("Um de dano mais efeito de dano");
              break;
          }
          break;
        } 
        if (estiloDeJogo == "Dado normal")
        {
          Console.WriteLine($"Você tirou:{dado.Next(1, 6)} no dado");
          break;
        }
      }
    }
  }
}

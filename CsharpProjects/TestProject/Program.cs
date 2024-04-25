// uma instância de uma classe
// 'new' = operador (Resposavel por criar a instancia de uma classe) / 'Random' = classe / 'dice' = variavel
Random dice = new Random();
// Métodos com estado, pq ele precisa de uma variavel 
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

Random dice = new Random();
int roll = dice.Next();
using ExemploPOO.Models;
using ExemploPOO.Interfaces;

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));
Console.WriteLine(calc.Dividir(9, 3));



// Object Class

// Computador c = new Computador();

// Console.WriteLine(c.ToString());



// Constructor by inherite

// Pessoa p5 = new Pessoa("Breno");
// Aluno a5 = new Aluno("Patricia");
// a5.Apresentar();
// p5.Apresentar();



// Abstract class

// Corrente c = new Corrente();

// c.Creditar(500);
// c.ExibirSaldo();



// Polimorfism example

// Professor p2 = new Professor();

// p2.Nome = "Patricia";
// p2.Idade = 40;
// p2.Salario = 1000;
// p2.Apresentar();

// Aluno a2 = new Aluno();

// a2.Nome = "Breno";
// a2.Idade = 40;
// a2.Nota = 10;
// a2.Apresentar();



//inheritance example

// Aluno a1 = new Aluno();

// a1.Nome = "Breno Lucena";
// a1.Idade = 40;
// a1.Email = "breno.lucena@gmail.com";
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor();

// p1.Nome = "Furistreca";
// p1.Idade = 55;
// p1.Apresentar();



//Encapsulation example

// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo(); //unable to access attribute saldo cause the protection lvl (declared as private type)
// c1.Sacar(500);
// c1.ExibirSaldo();
// c1.Sacar(5000);
// c1.ExibirSaldo();




//Abstraction example

// Pessoa p1 = new Pessoa();

// p1.Nome = "Breno";
// p1.Idade = 40;

// p1.Apresentar();

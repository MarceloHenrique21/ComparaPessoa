using System;
using System.Globalization;
using arquivo5_Ler_dados_de_duas_pessoas;

class arquivo1{

 public static void Main(){

     Usuario User1, User2;
     
     User1 = new Usuario();

     User2 = new Usuario();

// ------------------------------------------------------------- User 1

            Console.WriteLine("Digite seu nome: ");
            User1.Nome = Console.ReadLine();


            Console.WriteLine("Digite sua idade: ");
            User1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu Salario: ");
            User1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Digite seu Estado: ");
            User1.Estado = Console.ReadLine();


            Console.WriteLine("Digite seu Sexo: ");
            User1.Sexo = char.Parse(Console.ReadLine());
Console.Clear();
// ---------------------------------------------------------------------------------------------User 2
           
            Console.WriteLine("Digite seu nome: ");
            User2.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            User2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu Salario: ");
            User2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu Estado: ");
            User2.Estado = Console.ReadLine();

            Console.WriteLine("Digite seu Sexo: ");
            User2.Sexo = char.Parse(Console.ReadLine());
Console.Clear();
            

            

            Console.WriteLine("Dados do User 1");
           
                Console.WriteLine("Nome: " +User1.Nome);
                Console.WriteLine("Idade: " +User1.Idade);
                Console.WriteLine("Salario: " +User1.Salario + " Mil");
                Console.WriteLine("Estado: " +User1.Estado);
                Console.WriteLine("Sexo: " +User1.Sexo + " \r\n");


                


                 Console.WriteLine("Dados do User 2");
           
                Console.WriteLine("Nome: " +User2.Nome);
                Console.WriteLine("Idade: " +User2.Idade);
                Console.WriteLine("Salario: " +User2.Salario + " Mil");
                Console.WriteLine("Estado: " +User2.Estado);
                Console.WriteLine("Sexo: " +User2.Sexo + " \r\n");
                
  Console.WriteLine("pressione qualquer tecla para prosseguir o programa  \r\n");
  Console.ReadKey();

  
  
     if(User1.Idade > User2.Idade){

                 Console.WriteLine("Usuario 1 é mais velho  \r\n");

                  if (User1.Salario > User2.Salario){

                 Console.WriteLine("O Salario do usuario 1 é maior  \r\n");

             }else{


                 Console.WriteLine("O Salario do Usuario 2 é maior  \r\n");
             }

             }else{

                 Console.WriteLine("Usuario 2 é mais velho \r\n");

                  if (User1.Salario > User2.Salario){

                 Console.WriteLine("O Salario do usuario 1 é maior  \r\n");

             }else{


                 Console.WriteLine("O Salario do Usuario 2 é maior  \r\n");
             }

             }

           







    Console.WriteLine("pressione qualquer tecla para continuar");
    Console.ReadKey();

}
} 
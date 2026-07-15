Console.WriteLine("Hello, World!");

// criar um simulador de login com tentativas limitadas
int maxTentativas = 3;
int tentativas = 0;

while (tentativas < maxTentativas)
{
    Console.Write("Digite seu usuário: ");
    string usuario = Console.ReadLine();

    Console.Write("Digite sua senha: ");
    string senha = Console.ReadLine();

    // Simulação de verificação de login
    if (usuario == "admin" && senha == "1234")
    {
        Console.WriteLine("Login bem-sucedido!");
        break; // usado para sair do loop caso o login seja bem-sucedido
    }
    else
    {
        tentativas++;
        Console.WriteLine($"Usuário ou senha incorretos. Tentativa {tentativas} de {maxTentativas}.");
        
        if (tentativas == maxTentativas)
        {
            Console.WriteLine("Número máximo de tentativas atingido. Acesso negado.");
        }
    }
}
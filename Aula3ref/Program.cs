using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Penélope";
p1.Idade = 5;
p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "Rua do Manda-Chuva",
    Numero = 3,
    CEP = "0456301",
    Cidade = "São Paulo",
};

    WriteLine("Fim");


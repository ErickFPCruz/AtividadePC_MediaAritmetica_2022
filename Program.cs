Console.Clear();

double numeroReal1, numeroReal2, numeroReal3, mediaDosNumeros;
const int qntdNumeros = 3;

Console.Write("Escreva um número qualquer: ");
numeroReal1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Escreva um segundo número qualquer: ");
numeroReal2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Escreva um terceiro número qualquer: ");
numeroReal3 = Convert.ToDouble(Console.ReadLine());

mediaDosNumeros = (numeroReal1 + numeroReal2 + numeroReal3) / qntdNumeros;
// Média = n_1 + n_2 + n_3 + ... + n_f / f

Console.Write($"Média = {mediaDosNumeros}");
Console.WriteLine();
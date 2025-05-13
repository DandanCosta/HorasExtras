double salariohoraBase, salario;
int horas, horasExtras;

Console.WriteLine("--- Horas Extras ---\n");

Console.Write("Digite o salario-hora base: ");
salariohoraBase = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite as horas trabalhadadas: ");
horas = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a quantidade de horas extras: ");
horasExtras = Convert.ToInt32(Console.ReadLine());

salario = salariofinal();

Console.WriteLine($"O salario é {salario:C2} por hora");

double salariofinal(){
    double salarionormal = salariohoraBase * horas;
    double salarioHorasExtras = salariohoraBase * horasExtras * 1.4;
    return salarionormal + salarioHorasExtras;
}

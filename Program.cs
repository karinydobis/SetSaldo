try
{
    Conta c = new Conta();
    Console.WriteLine("Informe o saldo:");
    double saldo = double.Parse(Console.ReadLine());
    c.SetSaldo(saldo);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

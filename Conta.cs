public class Conta
{
    private double saldo;

    public void SetSaldo(double s)
    {
        try
        {
            if (s >= 0)
            {
                saldo = s;
                Console.WriteLine("\nSUCESSO!");
            }
            else
            {
                throw new Exception("O VALOR NÃO PODE SER NEGATIVO!");
            }
        }catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    
    }

}


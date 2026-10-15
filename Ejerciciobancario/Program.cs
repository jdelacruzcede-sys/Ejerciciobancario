using System;

class CuentaBancaria
{
    // Campo privado
    private double _saldo;

    // Constructor
    public CuentaBancaria(double saldoInicial)
    {
        _saldo = saldoInicial;
    }

    // Propiedad de solo lectura
    public double Saldo
    {
        get { return _saldo; }
    }

    // Método para depositar
    public void Depositar(double monto)
    {
        if (monto > 0)
        {
            _saldo += monto;
            Console.WriteLine("Depósito realizado correctamente.");
        }
        else
        {
            Console.WriteLine("El monto debe ser mayor que 0.");
        }
    }

    // Método para retirar
    public void Retirar(double monto)
    {
        if (monto > 0 && monto <= _saldo)
        {
            _saldo -= monto;
            Console.WriteLine("Retiro realizado correctamente.");
        }
        else
        {
            Console.WriteLine("No se puede realizar el retiro.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Creamos una cuenta con saldo inicial
        CuentaBancaria cuenta = new CuentaBancaria(5000);

        Console.WriteLine("Saldo inicial: " + cuenta.Saldo);

        // Hacemos un depósito
        cuenta.Depositar(2000);
        Console.WriteLine("Saldo después del depósito: " + cuenta.Saldo);

        // Hacemos un retiro
        cuenta.Retirar(1000);
        Console.WriteLine("Saldo después del retiro: " + cuenta.Saldo);

        // Intentamos retirar más dinero del disponible
        cuenta.Retirar(10000);
        Console.WriteLine("Saldo final: " + cuenta.Saldo);
    }
}

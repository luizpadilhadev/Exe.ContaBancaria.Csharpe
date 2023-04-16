using System.Globalization;

namespace Exe.ContaBancaria
{
    //Atributos
    class Conta {
        public int  NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Construtor
        public Conta(int numeroConta, string titular)
                {
                    NumeroConta = numeroConta;
                    Titular = titular;
                }

        public Conta(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Saldo = saldo;
        }

        //metodos

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        //ToString para formatar a forma da apresentação da classa

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titutar: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

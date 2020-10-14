namespace _05.ByteBank
{

    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numeroConta;
        public double saldo = 100; // Definindo com default o valor 100

        // função sacar
        public bool Sacar(double valor) // função sempre começa com maiuscula
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        // metodo depositar
        // é costume chamar de metodo quando não retonar nada.
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor; //retirar o saldo da conta de origem
            contaDestino.Depositar(valor); // atribui saldo na conta destino
            return true;
        }
    }
}


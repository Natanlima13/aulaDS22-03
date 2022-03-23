public class Conta {
    private int numero;
    private Cliente titular;
    private double saldo;

    public int Numero{
        set{
            this.numero = value;
        }
    }
    public Cliente Titular{
        set{
            this.titular = value;
        }
        get{
            return this.titular;
        }
    }

    public double Saldo{
        set{
            this.saldo = value;
        }
    }

}
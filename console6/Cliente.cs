public class Cliente {
    private string nome;
    private string cpf;
    private string rg;
    private string endereco;

    public string Nome{
        set{
            this.nome = value;
        }
        get{
            return this.nome;
        }
    }

    public string CPF{
        set{
            this.cpf = value;
        }
        get{
            return this.cpf;
        }
    }

    public string RG{
        set{
            this.rg = value;
        }
        get{
            return this.rg;
        }
    }
    public string Endereco{
        set{
            this.endereco = value;
        }
        get{
            return this.endereco;
        }
    }
}
namespace pilhaFibonacci
{
    internal class Numero
    {
        int N;
        Numero? anterior;

        public Numero(int n)
        {
            this.N = n;
            this.anterior = null;
        }

        public void Setanterior(Numero num) 
        { 
            this.anterior = num; 
        }
        public Numero? Getanterior() 
        { return this.anterior; 
        }
        public int GetN() 
        { return this.N;
        }
        public string PrintN() 
        { return $"Numero: {this.N}";
        }
    }
}
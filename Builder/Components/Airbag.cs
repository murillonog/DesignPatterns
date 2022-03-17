namespace Builder.Components
{
    class Airbag
    {
        private string existe;
        public string Existe { 
            get => existe; 
            set => existe = value; 
        }
        public Airbag(string existe)
        {
            this.Existe = existe;
        }
    }
}

namespace ProgramacionOrientadaAObjetos.NewFolder
{
    class Camion : Vehiculo
    {
        private int cargaMaxima;

        
        public Camion(string color, string modelo, string year) : base(color, modelo, year)
        {
            cargaMaxima = 2350; // Peso máximo de carga en kg
        }

        // opcion de Acelerar
        public override void Acelerar()
        {
            base.Acelerar();
            Console.WriteLine("Acelerando el camión. Velocidad actual: " + velocidad + " km/h");
        }

        // opcion de frenar
        public override void Frenar()
        {
            base.Frenar();
            Console.WriteLine("Frenando el camión.");
        }

        // peso maximo del camion
        public void CargarCamion(int peso)
        {
            if (peso <= cargaMaxima)
            {
                Console.WriteLine("Cargando camión con " + peso + " kg.");
            }
            else
            {
                Console.WriteLine("Carga excede el límite máximo de " + cargaMaxima + " kg.");
            }
        }
    }
}

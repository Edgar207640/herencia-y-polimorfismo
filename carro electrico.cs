namespace ProgramacionOrientadaAObjetos.NewFolder
{
    class AutoElectrico : Vehiculo
    {
        private int cargaBateria;

        
        public AutoElectrico(string color, string modelo, string year) : base(color, modelo, year)
        {
            cargaBateria = 100; // Nivel inicial de la batería
        }

        // opcion Acelerar
        public override void Acelerar()
        {
            if (cargaBateria > 0)
            {
                base.Acelerar();
                cargaBateria -= 2; // Consumir batería al acelerar
                Console.WriteLine("Nivel de batería restante: " + cargaBateria + "%");
            }
            else
            {
                Console.WriteLine("La batería está descargada, no se puede acelerar.");
            }
        }

        // opcion Frenar
        public override void Frenar()
        {
            base.Frenar();
            Console.WriteLine("Frenando el auto eléctrico.");
        }

        // opcion para cargar la batería
        public void CargarBateria(int cantidad)
        {
            cargaBateria = Math.Min(100, cargaBateria + cantidad);
            Console.WriteLine("Cargando la batería... Nivel actual: " + cargaBateria + "%");
        }
    }
}

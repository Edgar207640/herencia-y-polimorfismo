namespace ProgramacionOrientadaAObjetos.NewFolder
{
    class AutoDeCombustion : Vehiculo
    {
        private int nivelGasolina;

        
        public AutoDeCombustion(string color, string modelo, string year) : base(color, modelo, year)
        {
            nivelGasolina = 100; // Nivel inicial de gasolina
        }

        // opcion Acelerar
        public override void Acelerar()
        {
            if (nivelGasolina > 0)
            {
                base.Acelerar();
                nivelGasolina -= 2; // Consumir gasolina al acelerar
                Console.WriteLine("Nivel de gasolina restante: " + nivelGasolina + "%");
            }
            else
            {
                Console.WriteLine("No hay suficiente gasolina para acelerar.");
            }
        }

        // opcion Frenar
        public override void Frenar()
        {
            base.Frenar();
            Console.WriteLine("El freno ha sido aplicado en el Auto de Combustión.");
        }

        // opcion para cargar gasolina
        public void CargarGasolina(int cantidad)
        {
            nivelGasolina = Math.Min(100, nivelGasolina + cantidad);
            Console.WriteLine("Cargando gasolina... Nivel actual: " + nivelGasolina + "%");
        }
    }
}

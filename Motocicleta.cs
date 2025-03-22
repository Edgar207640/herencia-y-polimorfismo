namespace ProgramacionOrientadaAObjetos.NewFolder
{
    class Motocicleta : Vehiculo
    {
        private int nivelAceite;

        
        public Motocicleta(string color, string modelo, string year) : base(color, modelo, year)
        {
            nivelAceite = 100; // Nivel inicial de aceite
        }

        // opcion Acelerar
        public override void Acelerar()
        {
            base.Acelerar();
            velocidad += 80; // Motocicleta acelera más rápido
            Console.WriteLine("La motocicleta está acelerando. Velocidad actual: " + velocidad + " km/h");
        }

        // opcion  Frenar
        public override void Frenar()
        {
            base.Frenar();
            Console.WriteLine("Frenando la motocicleta.");
        }

        // opcion para cambiar el aceite
        public void CambiarAceite()
        {
            nivelAceite = 100;
            Console.WriteLine("Aceite cambiado. Nivel de aceite: " + nivelAceite + "%");
        }
    }
}

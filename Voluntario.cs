public class Voluntario : Personas
{
    private double horasTrabajadas;
    public double HorasTrabajadas{get{return this.horasTrabajadas;} set {this.horasTrabajadas = value;}}

    public Voluntario(string nombre, string dni, double horasTrabajadas) : base(nombre, dni)
    {
        HorasTrabajadas = horasTrabajadas;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Voluntario: {Nombre}, DNI: {Dni}, Horas Trabajadas: {HorasTrabajadas}");
    }
}
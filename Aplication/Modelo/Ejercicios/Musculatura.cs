using System;

public class Musculatura : Ejercicio
{
	
	public string nombre_ejer_m {  get; set; }

	public string grupo_musc {  get; set; }

    public Musculatura() {}


	public Musculatura(int id_ejer, string nombre_ejer_m, string grupo_musc) : base (id_ejer)
	{
		this.nombre_ejer_m = nombre_ejer_m;
		this.grupo_musc = grupo_musc;

    }
}

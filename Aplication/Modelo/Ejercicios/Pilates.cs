using System;

public class Pilates : Ejercicio
{

	public string nombre_ejer_p {  get; set; }

	public string destreza {  get; set; }


	public Pilates()
	{
	}


	public Pilates(, int id_ejer, string nombre_ejer_p, string destreza) : base (id_ejer)
    {
        this.nombre_ejer_p = nombre_ejer_p;
        this.destreza = destreza;
    }
}

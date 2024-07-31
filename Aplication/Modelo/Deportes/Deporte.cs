using System;

public class Deporte
{

	public int id_deporte { get; set; }

	public string deporte { get; set; }
    
	public Deporte() {}

	public Deporte (int id_deporte, string deporte)
	{
		this.id_deporte = id_deporte;
		this.deporte = deporte;
	}
}

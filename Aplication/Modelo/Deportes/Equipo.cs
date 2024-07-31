using System;

public class Equipo
{
	public int id_team { get; set; }

	public string nombre_team { get; set; }

	public Equipo() { }

	public Equipo(int id_team, string nombre_team)
	{
		this.id_team = id_team;
		this.nombre_team = nombre_team;

	}
	
}

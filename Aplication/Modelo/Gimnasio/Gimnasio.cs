using System;

public class Gimnasio
{
	public int id_gym {  get; set; }
	
	public string departamento { get; set; }


	public Gimnasio(int id_gym, string departamento)
	{
		this.id_gym = id_gym;
		this.departamento = departamento;
	}



}

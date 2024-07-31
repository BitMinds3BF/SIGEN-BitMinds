using System;

public class Agenda 
{
	
	
	public string dia_semana {  get; set; }

    public int id_gym { get; set; }
    
	public TimeSpan hora_inicio { get; set; }

	public TimeSpan hora_fin {  get; set; }


	public Gimnasio Gimnasio { get; set; }


	public Agenda(string dia_semana, TimeSpan hora_inicio, TimeSpan hora_fin)
	{
		this.dia_semana = dia_semana;
		this.hora_fin = hora_inicio;
		this.hora_fin= hora_fin;	
	}
}

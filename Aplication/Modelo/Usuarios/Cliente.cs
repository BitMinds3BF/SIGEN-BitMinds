using System;
using System.Security.Cryptography.X509Certificates;

public class Cliente
{


    public string tipo_doc { get; set; }

    public string num_doc { get; set; }

    public string nombre {  get; set; }

	public string apellido { get; set; }

	public string direccion {  get; set; }

	public string departamento { get; set; }

	public int telefono { get; set; }


	 public Cliente() {}

	 public Cliente(string tipo_doc, string num_doc, string nombre, string apellido, string direccion, string departamento, int telefono)
     {
        this.tipo_doc = tipo_doc;
        this.num_doc = num_doc;
        this.nombre = nombre;
        this.apellido = apellido;
        this.direccion = direccion;
        this.departamento = departamento;
        this.telefono = telefono;
     }




}

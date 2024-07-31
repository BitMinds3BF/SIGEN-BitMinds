using System;

public class Estado
{
    public int id_estado { get; set; }

    public bool estado { get; set; }

    public Estado() { }

    public Estado(int id_estado, bool estado)
    {
        this.id_estado = id_estado;
        this.estado = estado;
    }
}

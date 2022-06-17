using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Persona
{
	private int id_Perso;
	private int contra_Perso;
	private int saldo_Perso;
	private string nombre_Perso;
	private int estado_Perso;
	private int telef_Perso;

    public global::System.Int32 Id_Perso { get => id_Perso; set => id_Perso = value; }
    public global::System.Int32 Contra_Perso { get => contra_Perso; set => contra_Perso = value; }
    public global::System.Int32 Saldo_Perso { get => saldo_Perso; set => saldo_Perso = value; }
    public global::System.String Nombre_Perso { get => nombre_Perso; set => nombre_Perso = value; }
    public global::System.Int32 Estado_Perso { get => estado_Perso; set => estado_Perso = value; }
    public global::System.Int32 Telef_Perso { get => telef_Perso; set => telef_Perso = value; }
    //virtual public int Method()  
    //{  
    //return 10;  
    //}  
    public void imprimirMensajePerso(){
        Console.WriteLine("Hola soy Persona");
    }
}

public class Program
{
	public static void Main()
	{
		
	}
}
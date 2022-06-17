using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


	class Resoluciones
	{
		private int id_Res;
		private string escr_Res;
		private string date_Res;

        public global::System.Int32 Id_Res { get => id_Res; set => id_Res = value; }
        public global::System.String Escr_Res { get => escr_Res; set => escr_Res = value; }
        public global::System.String Date_Res { get => date_Res; set => date_Res = value; }

		public void imprimirMensajeReso(){
        Console.WriteLine("Hola soy Resolucion");
    }
    }

public class Program
{

	public static void Main()
	{
		
	}
}
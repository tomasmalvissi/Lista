using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMLista.Clases
{
    public class Lista
    {
        #region PROPIEDADES
        private string[] lista = new string[1];
        private string[] nota = new string[1];

        private int ProximaPosicion = 0;
        private int ProxNota = 0;
        #endregion

        #region METODOS
        public bool Agregar(string nombre)
        {
            bool Resp = false;
            try
            {
                if (ProximaPosicion == lista.Length)
                {
                    this.AgregaRegistro(1);
                }

                lista[ProximaPosicion] = nombre;
                ProximaPosicion++;
                Resp = true;
            }
            catch (Exception err)
            {
                throw err;
            }

            return Resp;
        }

        public bool AgregarNota(string notas)
        {
            bool Resp = false;
            try
            {
                if (ProxNota == nota.Length)
                {
                    this.AgregaNotas(1);
                }

                nota[ProxNota] = notas;
                ProxNota++;
                Resp = true;
            }
            catch (Exception error)
            {
                throw error; 
            }

            return Resp;
        }
        public string MostrarLista()
        {
            string Respuesta = "";
            if (ProximaPosicion > 0)
            {
                Respuesta = lista[0];
                for (int i = 1; i < ProximaPosicion; i++)
                {
                    Respuesta = Respuesta + "\r\n" + lista[i];
                }
            }
            return Respuesta;
        }
        public string MostrarNotas()
        {
            string Respuesta = "";
            if (ProxNota > 0)
            {
                Respuesta = nota[0];
                for (int i = 1; i < ProxNota; i++)
                {
                    Respuesta = Respuesta + "\r\n" + nota[i];
                }
            }
            return Respuesta;
        }

        private void AgregaRegistro(int incremento)
        {
            string[] Temp = new string[lista.Length + incremento];
            lista = this.Copiar(lista, Temp);
        }

        private void AgregaNotas(int incremento)
        {
            string[] TempN = new string[nota.Length + incremento];
            nota = this.CopiarNota(nota, TempN);

        }
        private string[] Copiar(string[] Origen, string[] Destino)
        {
            for (int i = 0; i < ProximaPosicion; i++)
            {
                Destino[i] = Origen[i];
            }
            return Destino;
        }
        private string[] CopiarNota(string[] Origen, string[] Destino)
        {
            for (int i = 0; i < ProxNota; i++)
            {
                Destino[i] = Origen[i];
            }
            return Destino;
        }

        public int BuscarPosicion(string Que)
        {
            int Resp = -1;

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i].CompareTo(Que) == 0)
                {
                    Resp = i;
                    break;
                }
            }

            return Resp;
        }

        public string Borrar(string Que)
        {
            string Resp = "";
            int Pos = this.BuscarPosicion(Que);
            if(Pos==-1)
            {
                Resp = Que + " no ha sido encontrado en la lista.";
            }
            else
            {
                for (int i = Pos; i < ProximaPosicion-1; i++)
                {
                    this.lista[i] = this.lista[i + 1];
                }
                this.lista[ProximaPosicion-1] = null;
                ProximaPosicion = ProximaPosicion - 1;
                AgregaRegistro(-1);

                for (int i = Pos; i < ProxNota - 1; i++)
                {
                    this.nota[i] = this.nota[i + 1];
                }
                this.nota[ProxNota - 1] = null;
                ProxNota = ProxNota - 1;
                AgregaNotas(-1);
            }

            return Resp;
        }

        public string OrdenAlfabetico()
        {
            string salida = "";
            string[] copia = new string[lista.Length];
            string[] copiaNotas = new string[nota.Length];
            Copiar(lista, copia);
            Copiar(nota,copiaNotas);
            if (copia.Length > 1)
            {
                for (int j = 0; j < copia.Length; j++)
                {
                    for (int i = 0; i < copia.Length; i++)
                    {
                        try
                        {
                            if (copia[i].CompareTo(copia[i + 1]) == 1)
                            {
                                //El que sigue es mayor
                                string Temp = copia[i];
                                copia[i] = copia[i + 1];
                                copia[i + 1] = Temp;

                                string TempN = copiaNotas[i];
                                copiaNotas[i] = copiaNotas[i + 1];
                                copiaNotas[i + 1] = TempN;

                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("finalizo la revision de la lista");
                        }
                    }

                }
            }
            for (int i = 0; i < copia.Length; i++)
            {
                salida = salida + copia[i] + " " +  copiaNotas[i] + "\r\n";
            }

            return salida;
        }
        #endregion
    }
}

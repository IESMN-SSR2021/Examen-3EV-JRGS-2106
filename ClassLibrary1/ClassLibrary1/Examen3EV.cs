using System.Collections.Generic;
using System;

namespace Examen3EV_SSR2021
{
    /// <summary>
    /// esta clase nos calcula las estadísticas de un conjunto de notas
    /// </summary>
    public class EstadisticasNotasSSR2021  // esta clase nos calcula las estadísticas de un conjunto de notas 
    {
        private int suspensos;  // Suspensos
        private int aprobados;  // Aprobados
        private int notables;  // Notables
        private int sobresalientes;  // Sobresalientes

        private double media; // Nota media

        const int Minimo = 0;
        const int Maximo = 10;


        public int Suspensos 
        { 
            get => suspensos; 
            set
            {
                this.suspensos = value;
            }
        }
        public int Aprobados 
        { 
            get => aprobados;
            set
            {
                this.aprobados = value;
            }
        }
        public int Notables 
        { 
            get => notables;
            set
            {
                this.notables = value;
            }
        }
        public int Sobresalientes 
        { 
            get => sobresalientes;
            set
            {
                this.sobresalientes = value;
            }
        }
        public double Media 
        { 
            get => media;
            set
            {
                this.media = value;
            }
        }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public EstadisticasNotasSSR2021()
        {
            Suspensos = Minimo;
            Aprobados = Minimo;
            Notables = Minimo; 
            Sobresalientes = Minimo;  // inicializamos las variables
            Media = 0.0;
        }

        // Constructor a partir de un array, calcula las estadísticas al crear el objeto
        /// <summary>
        /// Constructor a partir de un array, calcula las estadísticas al crear el objeto
        /// </summary>
        /// <param name="ListaNotasSSR2021"></param>
        public EstadisticasNotasSSR2021(List<int> ListaNotasSSR2021)
        {
            NotasEsperadasSSR2021(ListaNotasSSR2021);
        }

        public void NotasEsperadasSSR2021(List<int> ListaNotasSSR2021)
        {

            for (int i = 0; i < ListaNotasSSR2021.Count; i++)
            {
                if (ListaNotasSSR2021[i] < 5) Suspensos++;              // Por debajo de 5 suspenso
                else if (ListaNotasSSR2021[i] > 5 && ListaNotasSSR2021[i] < 7) Aprobados++;// Nota para aprobar: 5
                else if (ListaNotasSSR2021[i] > 7 && ListaNotasSSR2021[i] < 9) Notables++;// Nota para notable: 7
                else if (ListaNotasSSR2021[i] >= 9) Sobresalientes++;         // Nota para sobresaliente: 9
            }

        }

        public double MediaNotas(List<int> ListaNotasSSR2021)
        {
            Media = 0.0;

            for (int i = 0; i < ListaNotasSSR2021.Count; i++)
            {
                if (ListaNotasSSR2021[i] < 5) Suspensos++;              // Por debajo de 5 suspenso
                else if (ListaNotasSSR2021[i] > 5 && ListaNotasSSR2021[i] < 7) Aprobados++;// Nota para aprobar: 5
                else if (ListaNotasSSR2021[i] > 7 && ListaNotasSSR2021[i] < 9) Notables++;// Nota para notable: 7
                else if (ListaNotasSSR2021[i] >= 9) Sobresalientes++;         // Nota para sobresaliente: 9

                Media = Media + ListaNotasSSR2021[i];
            }

            Media = Media / ListaNotasSSR2021.Count;

            return Media;
        }

        // Para un conjunto de listnot, calculamos las estadísticas
        // calcula la media y el número de suspensos/aprobados/notables/sobresalientes
        //
        // El método devuelve -1 si ha habido algún problema, la media en caso contrario
        /// <summary>
        /// calculamos las estadisticas para un conjunto de listnot
        /// calcula la media y el numero de suspensos/aprobados/notables/sobresalientes
        /// </summary>
        /// <param name="ListaNotasSSR2021"></param>
        /// <returns>devuelve la media</returns>
        public double CalcularEstadisticas(List<int> ListaNotasSSR2021)
        {                                 
            Media = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (ListaNotasSSR2021.Count <= Minimo)  // Si la lista no contiene elementos, devolvemos un error
            {
                throw new ArgumentOutOfRangeException("Fuera de rango");
            }
                

            for (int i = 0; i < Maximo; i++)
            {
                if (ListaNotasSSR2021[i] < Minimo || ListaNotasSSR2021[i] > Maximo)    // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
                {
                    throw new ArgumentOutOfRangeException("Fuera de rango");
                }
                    
            }

            return Media;
        }
    }
}

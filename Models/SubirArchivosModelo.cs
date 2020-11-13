


using System;
using Microsoft.AspNetCore.Http;

namespace red_social_musicos.Models
{
    public class SubirArchivosModelo
    {
        public String confimacion { get; set;}

        public Exception error { get; set; }

        public void SubirArchivo(String ruta, IFormFile archivo)
        {
            try
            {
                //archivo.SaveAs(ruta);
                this.confimacion="Fichero Guardado";
            }
            catch (Exception ex)
            {
                
               this.error = ex;
            }
        }
        
    }
}
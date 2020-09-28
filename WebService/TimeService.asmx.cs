using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class TimeService : System.Web.Services.WebService
    {
        [WebMethod]
        public string CurrentLocalTime()
        {
            var horaActual = DateTime.Now;
            return horaActual.ToString();
        }

        [WebMethod]
        public string CurrentTimeByZone(string destinationTimeZoneId)
        {
            var time = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, destinationTimeZoneId);
            return time.ToString();
        }

        
    }
}

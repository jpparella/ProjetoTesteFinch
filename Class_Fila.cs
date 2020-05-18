using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pFinchFila
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Fila
    {
       
        public Guid Id { get; set; }

      
        public string Cliente { get; set; }

     
        public DateTimeOffset DataAgendamento { get; set; }

      
        public string Observacao { get; set; }

    
        public Tipo Tipo { get; set; }
    }

    public class Tipo
    {
  
        public long Id { get; set; }


        public string Descricao { get; set; }

        public double Valor { get; set; }
    }
}

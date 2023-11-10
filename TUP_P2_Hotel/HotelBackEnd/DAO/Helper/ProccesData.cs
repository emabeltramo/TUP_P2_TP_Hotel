using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.DAO.Helper
{
    public class ProccesData
    {
        public List<AuditorResult> MakeReg(DbDataReader reader)
        {
            var registro = new List<AuditorResult>();
            for (var i = 0; i < reader.FieldCount; i++)
            {
                registro.Add(new AuditorResult()
                {
                    Campo = reader.GetName(i),
                    Valor = reader.IsDBNull(i) ? null : reader.GetValue(i)
                });
            };
            return registro;
        }
        public class AuditorResult
        {
            public string Campo { get; set; }
            public dynamic Valor { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchApiSirene.DataAccess.Models.Dto
{
    public class EstablishmentsDto
    {
        public string Denomination { get; set; }
        public List<string> Adresse { get; set; }
        public int PostalCode { get; set; }
        public string Town { get; set; }
        public string NafCode { get; set; }
    }
}

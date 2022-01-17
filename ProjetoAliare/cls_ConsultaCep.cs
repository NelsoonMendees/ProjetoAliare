using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAliare
{
    public class cls_ConsultaCep
    {

        [JsonProperty(PropertyName = "cep")]
        public string CEP { get; set; }

        [JsonProperty(PropertyName = "logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty(PropertyName = "complemento")]
        public string Complemento { get; set; }

        [JsonProperty(PropertyName = "bairro")]
        public string Bairro { get; set; }

        [JsonProperty(PropertyName = "localidade")]
        public string Localidade { get; set; }

        [JsonProperty(PropertyName = "uf")]
        public string Estado { get; set; }


    }
}

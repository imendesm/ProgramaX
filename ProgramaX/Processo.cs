using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaX
{
         public class Processo
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Endereco
        {
            public string logradouro { get; set; }
            public string numero { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string municipio { get; set; }
            public string estado { get; set; }
            public string cep { get; set; }
        }

        public class Endereco2
        {
            public string logradouro { get; set; }
            public string numero { get; set; }
            public string bairro { get; set; }
            public string municipio { get; set; }
            public string estado { get; set; }
            public string cep { get; set; }
            public string complemento { get; set; }
        }

        public class Papei
        {
            public int id { get; set; }
            public string nome { get; set; }
            public string identificador { get; set; }
        }

        public class Representante
        {
            public int id { get; set; }
            public int idPessoa { get; set; }
            public string nome { get; set; }
            public string login { get; set; }
            public string tipo { get; set; }
            public string documento { get; set; }
            public string tipoDocumento { get; set; }
            public Endereco2 endereco { get; set; }
            public string polo { get; set; }
            public string situacao { get; set; }
            public List<Papei> papeis { get; set; }
            public bool utilizaLoginSenha { get; set; }
        }

        public class PoloAtivo
        {
            public int id { get; set; }
            public int idPessoa { get; set; }
            public string nome { get; set; }
            public string login { get; set; }
            public string tipo { get; set; }
            public string documento { get; set; }
            public string tipoDocumento { get; set; }
            public Endereco endereco { get; set; }
            public string polo { get; set; }
            public string situacao { get; set; }
            public List<Representante> representantes { get; set; }
            public bool utilizaLoginSenha { get; set; }
        }

        public class Endereco3
        {
            public string logradouro { get; set; }
            public string numero { get; set; }
            public string bairro { get; set; }
            public string municipio { get; set; }
            public string estado { get; set; }
            public string cep { get; set; }
        }

        public class Endereco4
        {
            public string logradouro { get; set; }
            public string numero { get; set; }
            public string bairro { get; set; }
            public string municipio { get; set; }
            public string estado { get; set; }
            public string cep { get; set; }
        }

        public class Papei2
        {
            public int id { get; set; }
            public string nome { get; set; }
            public string identificador { get; set; }
        }

        public class Representante2
        {
            public int id { get; set; }
            public int idPessoa { get; set; }
            public string nome { get; set; }
            public string login { get; set; }
            public string tipo { get; set; }
            public string documento { get; set; }
            public string tipoDocumento { get; set; }
            public Endereco4 endereco { get; set; }
            public string polo { get; set; }
            public string situacao { get; set; }
            public List<Papei2> papeis { get; set; }
            public bool utilizaLoginSenha { get; set; }
        }

        public class PoloPassivo
        {
            public int id { get; set; }
            public int idPessoa { get; set; }
            public string nome { get; set; }
            public string login { get; set; }
            public string tipo { get; set; }
            public string documento { get; set; }
            public string tipoDocumento { get; set; }
            public Endereco3 endereco { get; set; }
            public string polo { get; set; }
            public string situacao { get; set; }
            public List<Representante2> representantes { get; set; }
            public bool utilizaLoginSenha { get; set; }
        }

        public class Assunto
        {
            public int id { get; set; }
            public string codigo { get; set; }
            public string descricao { get; set; }
            public bool principal { get; set; }
        }

        public class Root
        {
            public int id { get; set; }
            public string numero { get; set; }
            public string classe { get; set; }
            public string orgaoJulgador { get; set; }
            public bool segredoJustica { get; set; }
            public bool justicaGratuita { get; set; }
            public DateTime autuadoEm { get; set; }
            public int valorDaCausa { get; set; }
            public List<PoloAtivo> poloAtivo { get; set; }
            public List<PoloPassivo> poloPassivo { get; set; }
            public List<Assunto> assuntos { get; set; }
            public List<object> itensProcesso { get; set; }
        }


    }
}

using System;

namespace WSPublica.DTO
{
    public class DadosPublicacao
    {
        public string Titulo { get; set; }
        public string Autores { get; set; }
        public string PalavrasChave { get; set; }
        public DateTime Data { get; set; }
        public string Publicacao { get; set; }
        public string Editor { get; set; }
        public string EnderecoEletronico { get; set; }
    }
}
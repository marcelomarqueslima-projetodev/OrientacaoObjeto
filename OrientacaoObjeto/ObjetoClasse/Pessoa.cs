using System.Reflection.Metadata.Ecma335;

namespace OrientacaoObjeto.ObjetoClasse
{
    public class Pessoa
    {
        public class Objeto
        {
            public Objeto()
            {
                //Definição de Objeto
                var pessoa = new Pessoa
                {
                    Name = "João",
                    Address = "Rua Japão, 25",
                    Phone = "+55 (41) 99999-9999",
                    Age = 38
                };
            }
        }

        //Definição de Classe
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }
}

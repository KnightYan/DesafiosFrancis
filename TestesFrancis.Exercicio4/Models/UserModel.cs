using System;

namespace TestesFrancis.Exercicio4.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Cep { get; set; }

        public UserModel(Guid id, string name, int cep)
        {
            Id = id;
            Name = name;
            Cep = cep;
        }
    }
}

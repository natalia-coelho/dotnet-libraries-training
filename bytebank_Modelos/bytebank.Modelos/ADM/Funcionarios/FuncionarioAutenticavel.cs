﻿using bytebank.Modelos.ADM.SistemaInterno;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;

namespace bytebank.Modelos.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private AutenticacaoUtil autenticacao = new AutenticacaoUtil();

        public string Senha { get; set; }
        
        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return this.autenticacao.ValidarSenha(this.Senha, senha);
        }
    }
}

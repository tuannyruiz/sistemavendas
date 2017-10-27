using System;
using System.IO;

namespace SistemaVendas.classes {
    public class SalvarCliente {
        public string Salvar(Cliente cliente){
            string msg = "";
            StreamWriter arquivo = null;
            try{
                if(cpfValido(cliente.Cpf)){
                    arquivo = new StreamWriter("cadclientes.csv", true);
                    arquivo.WriteLine(cliente.Nome + ";" + cliente.Email + ";" + cliente.Cpf + ";" + cliente.DataCadastro);
                    msg = "Cliente cadastrado com sucesso!";                    
                } else {
                    msg = "CPF inválido";
                }
            } 
            catch(Exception ex) {
                msg = "Erro ao tentar gravar o arquivo. " + ex.Message;
            }
            finally {
                arquivo.Close();
            }
            return msg;
        }

        bool cpfValido(string cpf) {
            int[] v1 = {10, 9, 8, 7, 6, 5, 4, 3, 2}; //Primeiro validador
            int[] v2 = {11, 10, 9, 8, 7, 6, 5, 4, 3, 2}; //Segundo validador
            bool retorno = true;
            string cpfCalculo;
            int r1 = 0; // Variável pra guardar o primeiro número validador
            int r2 = 0; // Variável pra guardar o segundo número validador

            cpfCalculo = cpf.Substring(0, cpf.Length-2); // Cópia do CPF informado pelo usuário sem os últimos dois dígitos
            
            for(int i = 0; i < cpfCalculo.Length; i++) { 
                r1 += Int32.Parse(cpfCalculo[i].ToString())*v1[i];
            }               

            if(r1 % 11 < 2) {
                cpfCalculo += "0";
            } else {
                cpfCalculo += (11 - (r1%11)).ToString();
            }

            for(int i = 0; i < cpfCalculo.Length; i++) {
                r2 += Int32.Parse(cpfCalculo[i].ToString())*v2[i];
            }               

            if(r2 % 11 < 2) {
                cpfCalculo += "0";
            } else {
                cpfCalculo += (11 - (r2%11)).ToString();
            }

            if(cpfCalculo != cpf) {
                retorno = false;
            }

            return retorno;
        } 
    }
}
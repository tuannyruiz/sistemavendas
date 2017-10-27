using System;
using System.IO;

namespace SistemaVendas.classes {
    public class SalvarVenda {
        public string Salvar(Venda venda) {
            string msg = "";
            StreamWriter arquivo = null;
            try {
                arquivo = new StreamWriter("cadvenda.csv", true);
                arquivo.WriteLine(venda.Cpf + ";" + venda.Id + ";" + venda.DataVenda);
                msg = "Venda cadastrada com sucesso!";
            }
            catch(Exception ex) {
                msg = "Erro ao tentar gravar o arquivo. " + ex.Message;
            }
            finally {
                arquivo.Close();
            }
            return msg;
        } 
    }
}
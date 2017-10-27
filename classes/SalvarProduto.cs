using System;
using System.IO;

namespace SistemaVendas.classes {
    public class SalvarProduto {
        public string Salvar(Produto produto){
            string msg = "";
            StreamWriter arquivo = null;
            try {
                arquivo = new StreamWriter("cadproduto.csv", true);
                arquivo.WriteLine(produto.Id + ";" + produto.Nomeproduto + ";" + produto.Descricao + ";" + produto.Preco);
                msg = "Produto cadastrado com sucesso!";
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
using System;

namespace SistemaVendas.classes {
    public class Produto {
        private int id;
        private string nomeproduto;
        private string descricao;
        private double preco;
        public Produto() {

        }
        public Produto(int id, string nomeproduto, string descricao, double preco) {
            this.id = id;
            this.nomeproduto = nomeproduto;
            this.descricao = descricao;
            this.preco = preco;
        }
        public int Id { 
            get{return id;} 
            set{id = value;}
        }
        public string Nomeproduto { 
            get{return nomeproduto;} 
            set{nomeproduto = value;}
        }
        public string Descricao { 
            get{return descricao;} 
            set{descricao = value;}
        }
        public double Preco { 
            get{return preco;} 
            set{preco = value;}
        }
    }
}
﻿using WebApp_DS.Entidades;
namespace WebApp_DS.Models

{
    public class NovoProdutoViewModel : Produtos
    {
        public NovoProdutoViewModel() { 
        
            ListaCategorias = new List<Categoria>();
        }

        public List<Categoria> ListaCategorias { get; set;}
    }
}

using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao = 0; 

        public ListaContasCorrentes(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }

        public void Adiciona(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            validaTamanhoLista(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void validaTamanhoLista(int tamanhoNecessario)
        {
            if(_itens.Length < tamanhoNecessario)
            {
                Console.WriteLine($"Aumentando a capacidade da lista!");

                ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

                for (int i = 0; i < _itens.Length; i++)
                {
                    novoArray[i] = _itens[i];
                }

                _itens = novoArray;
            }
        }

        public void VerificaMaiorSaldo()
        {

        }
    }

}

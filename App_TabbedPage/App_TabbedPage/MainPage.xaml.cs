using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_TabbedPage
{
    //Alteramos a ContentPage para TabbedPage
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnProximo1_Clicked(object sender, EventArgs e)
        {
            //Pra poder movimentar na navegação das abas, preciso alterar o valor
            //da página corrente através da propriedade(Ela determina qual é a página atual):
            CurrentPage = Children[1];
            //Quando altero o valor da CurrentPage ele muda a exibição atual da página
            //Cada aba é uma página filha da TabbedPage
            //Dentro de Children eu especifico o número da aba que eu quero entrar
            //as abas começam a contar da esquerda pra direita apartir de zero.
        }

        private void btnAnterior2_Clicked(object sender, EventArgs e)
        {
            CurrentPage = Children[0];
        }

        private void btnProximo2_Clicked(object sender, EventArgs e)
        {
            CurrentPage = Children[2];
        }

        private void btnAnterior3_Clicked(object sender, EventArgs e)
        {
            CurrentPage = Children[1];
        }
    }
}

using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap11_MultiTask_02_Threads_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método de ação ao evento do botão. Síncrono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDoSyncStuff_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 50000; i++)    
            {
                labelContador.Text = i.ToString();  
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonDoAsyncStuff_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>    // Início da nova Thread
            { 
                for (int i = 0; i <= 50000; i++)
                {
                    labelContador.Text = i.ToString();  // Exceção aceder ao objeto da thread principal
                }
            }); // Fim da nova Thread
        }

        /// <summary>
        /// Método de ação ao evento do botão. Assíncrono
        /// Neste caso é criada uma nova thread a cada iteração do ciclo que devolve para a thread principal uma string
        /// com o valor.
        /// Já na thread principal o valor é colocado na Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonDoAsyncStuffRight_Click(object sender, EventArgs e)
        {
            // Desativa os botões para não interferir com a contagem, porque bloqueia  
            buttonDoSyncStuff.Enabled = false;
            buttonDoAsyncStuff.Enabled = false;
            buttonDoAsyncStuffRight.Enabled = false;

            pictureBoxGif.Visible = true;
            pictureBoxGif.Image = Properties.Resources.Gif;

            for (int i = 0; i <= 50000; i++)
            {
                labelContador.Text = await Task.Run(() =>    // Início da nova Thread
                {
                    Task.Delay(200);            // Pausa na execução da Thread paralela
                    return i.ToString();        // Devolve o valor para o Thread Principal
                }); // Fim da nova Thread
            }

            // Reativa os botões após a conclusão da Thread
            buttonDoSyncStuff.Enabled = true;
            buttonDoAsyncStuff.Enabled = true;
            buttonDoAsyncStuffRight.Enabled = true;
        }
    }
}

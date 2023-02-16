using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Guardian
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            if (File.Exists("configService.txt"))
            {
                string[] config = File.ReadAllLines("configService.txt");

                lbl_nome_executavel.Text = config[0];
                lbl_nome_servico.Text = config[1];
            }
        }

        private void btn_instalar_Click(object sender, EventArgs e)
        {
            if (lbl_nome_servico.Text == "" || lbl_nome_executavel.Text == "Não Selecionado")
            {
                MessageBox.Show("Um dos campos está vazio, por favor preenchar todos os campos",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool exists = VerificaServico(lbl_nome_servico.Text);
                if (exists)
                {
                    MessageBox.Show("Já existe um serviço com este nome, verifique e tente" +
                    " novamente", "Guardian", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    File.WriteAllText("configService.txt", lbl_nome_executavel.Text + "\n" + lbl_nome_servico.Text);
                    MessageBox.Show("Configuração salva com sucesso", "Guardian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /*Process cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.WorkingDirectory = lbl_nome_executavel.Text;
                    cmd.StartInfo.UseShellExecute = false;
                    //cmd.StartInfo.Arguments = lbl_nome_executavel.Text;
                    cmd.StartInfo.Verb = "runas";
                    cmd.Start();*/
                }
            }
        }

        private bool VerificaServico(string servico)
        {
            Process[] processes = Process.GetProcessesByName(servico);
            if (processes.Length > 0)
            {
                return true;
            }
            return false;
        }

        private void Mnu_opcao_importar_Click(object sender, EventArgs e)
        {
            if (Ofd_importar.ShowDialog() == DialogResult.OK)
            {
                lbl_nome_executavel.Text = Ofd_importar.FileName.ToString();
            }
        }
    }
}

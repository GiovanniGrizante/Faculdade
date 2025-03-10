using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Almoxarifado
{
    public partial class Form1 : Form
    {
        Produto[] produto = new Produto[1];
        int contProd = 0, indexProd = 0;
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            inserir.Visible = false;
            deletar.Visible = false;
            

        }

        private void entrada_Click(object sender, EventArgs e)
        {
            label1.Text = "Entrada";
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            label2.Text = "Produto";
            label3.Text = "Fornecedor";
            label4.Text = "Quantidade";
            label5.Text = "Valor Unitário";
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            inserir.Visible = true;
            deletar.Visible = true;
            inserir.Text = "Atualizar";
            aviso.Text = "";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox2.BackColor = System.Drawing.Color.White;
            textBox3.BackColor = System.Drawing.Color.White;
            textBox2.ReadOnly = false;
            textBox2.Enabled = true;
            textBox3.ReadOnly = true;
            textBox3.Enabled = false;

        }

        private void saida_Click(object sender, EventArgs e)
        {
            label1.Text = "Saída";
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            label2.Text = "Produto";
            label3.Text = "Fornecedor";
            label4.Text = "Quantidade";
            label5.Text = "Valor Unitário";
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            inserir.Visible = true;
            deletar.Visible = true;
            inserir.Text = "Atualizar";
            aviso.Text = "";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox2.BackColor = System.Drawing.Color.White;
            textBox3.BackColor = System.Drawing.Color.White;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;

        }

        private void consulta_Click(object sender, EventArgs e)
        {
            label1.Text = "Consulta";
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            label2.Text = "Produto";
            label3.Text = "Fornecedor";
            label4.Text = "Quantidade";
            label5.Text = "Valor Total";
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            inserir.Visible = true;
            deletar.Visible = true;
            inserir.Text = "Consultar";
            aviso.Text = "";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            //textBox2.BackColor = System.Drawing.Color.LightGray;
            //textBox3.BackColor = System.Drawing.Color.LightGray;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            label1.Text = "Adicionar";
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            label2.Text = "Produto";
            label3.Text = "Fornecedor";
            label4.Text = "Quantidade";
            label5.Text = "Valor Unitário";
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            inserir.Visible = true;
            deletar.Visible = true;
            inserir.Text = "Inserir";
            aviso.Text = "";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox2.BackColor = System.Drawing.Color.White;
            textBox3.BackColor = System.Drawing.Color.White;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
        }

        private void deletar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            aviso.Text = "";
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            aviso.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            aviso.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            aviso.Text = "";
        }

        private void inserir_Click(object sender, EventArgs e)
        {
            bool flagExiste = false;
            if (label1.Text == "Adicionar")
            {
                if(comboBox1.Text == "" || comboBox2.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    aviso.ForeColor = System.Drawing.Color.Red;
                    aviso.Text = "Favor preencher todos os campos";
                }
                else
                {
                    for(int i = 0; i < contProd; i++)
                    {
                        if (comboBox1.Text == produto[i].fornecedor && comboBox2.Text == produto[i].nome)
                        {
                            flagExiste = true;
                            aviso.ForeColor = System.Drawing.Color.Red;
                            aviso.Text = "Item existente";
                        }
                    }
                    if (flagExiste==false)
                    {
                        Array.Resize(ref produto, contProd + 1);
                        produto[contProd] = new Produto();
                        produto[contProd].nome = comboBox2.Text;
                        produto[contProd].fornecedor = comboBox1.Text;
                        produto[contProd].quantidade = Convert.ToInt32(textBox2.Text);
                        produto[contProd].valor = float.Parse(textBox3.Text);
                        comboBox1.Items.Add(comboBox1.Text);
                        comboBox2.Items.Add(comboBox2.Text);
                        contProd++;
                        indexProd = contProd;
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        aviso.ForeColor = System.Drawing.Color.Green;
                        aviso.Text = "Inserido com sucesso";
                    }
                }
            }
             
            if (label1.Text == "Consulta")
            {
                if(comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                {
                    aviso.ForeColor = System.Drawing.Color.Red;
                    aviso.Text = "Favor preencher todos os campos";
                }

                else
                {
                    for(int i = 0; i < contProd; i++)
                    {
                        if(comboBox1.SelectedItem.ToString() == (produto[i].fornecedor).ToString() && comboBox2.SelectedItem.ToString() == (produto[i].nome).ToString())
                        {
                            textBox2.Font = new Font(this.Font, FontStyle.Bold);
                            textBox3.Font = new Font(this.Font, FontStyle.Bold);
                            textBox2.Text = (produto[i].quantidade).ToString();
                            textBox3.Text = (produto[i].valor).ToString();
                        }
                    }
                }
            }

            if (label1.Text == "Entrada")
            {
                if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || textBox2.Text == "" || textBox3.Text == "")
                {
                    aviso.ForeColor = System.Drawing.Color.Red;
                    aviso.Text = "Favor preencher todos os campos";
                }

                else
                {
                    for (int i = 0; i < contProd; i++)
                    {
                        if (comboBox1.SelectedItem.ToString() == (produto[i].fornecedor).ToString() && comboBox2.SelectedItem.ToString() == (produto[i].nome).ToString())
                        {
                            produto[contProd] = new Produto();
                            produto[contProd].x = Convert.ToInt32(textBox2.Text);
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NosyrevaUA.Sprint6.TaskReview.V13.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.TaskReview.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        Random rnd = new Random();


        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(textBoxN.Text);
                int M = Convert.ToInt32(textBoxM.Text);
                int C = Convert.ToInt32(textBoxC.Text);
                int n1 = Convert.ToInt32(textBoxn1.Text);
                int n2 = Convert.ToInt32(textBoxn2.Text);
                int K = Convert.ToInt32(textBoxK.Text);
                int L = Convert.ToInt32(textBoxL.Text);

                int[,] matrix = new int[N, M];
                for( int i = 0; i<N; i++)
                {
                    for(int j = 0; j<M; j++)
                    {
                        matrix[i, j] = rnd.Next(n1, n2 + 1);        //вот матрица, заполненная рандомными числами
                    }
                }

                int res = ds.GetMatrix(matrix, C, K, L);
                textBoxAnswer.Text = Convert.ToString(res);           //во ответ

                dataGridViewInput.RowCount = N;
                dataGridViewInput.ColumnCount = M;
                for (int i = 0; i < M; i++)
                {
                    dataGridViewInput.Columns[i].Width = 25;
                }
                for(int i = 0; i<N; i++)
                {
                    for(int j = 0; j<M; j++)
                    {
                        dataGridViewInput.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

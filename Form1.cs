using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper
{
    public partial class Form1 : Form
    {
        public int MAX_S_W = 9, MAX_S_H = 9, MAX_M = 10;
        public int[,] board;
        public int counter = 0;
        public int mine_counter;
        public bool finish_game = false;

        public Form1()
        {
            InitializeComponent();
            start_Game();
            sevenSegment3.DecimalShow = false;
            sevenSegment2.DecimalShow = false;
            sevenSegment1.DecimalShow = false;
            sevenSegment1.ColorBackground = Color.Silver;
            sevenSegment2.ColorBackground = Color.Silver;
            sevenSegment3.ColorBackground = Color.Silver;
            sevenSegment1.ColorDark = Color.DarkGray;
            sevenSegment2.ColorDark = Color.DarkGray;
            sevenSegment3.ColorDark = Color.DarkGray;
        }

        public void start_Game()
        {
            Random rand = new Random();
            int mines = 0, n1, n2;
            counter = 0;
            mine_counter = MAX_M;

            sevenSegment1.Value = (MAX_M % 10).ToString();
            sevenSegment2.Value = (MAX_M / 10).ToString();

            dataGridView1.Height = MAX_S_H * 20 + 3;
            dataGridView1.Width = MAX_S_W * 20 + 3;
            this.Width = MAX_S_W * 20 + 40;
            this.Height = MAX_S_H * 20 + 140;
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            for (int i = 0; i < MAX_S_W; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewDisableButtonColumn());
                dataGridView1.Columns[i].Width = 20;
            }
            dataGridView1.RowCount = MAX_S_H;

            board = new int[MAX_S_W, MAX_S_H];
            while (mines != MAX_M)
            {
                n1 = rand.Next(0, MAX_S_W);
                n2 = rand.Next(0, MAX_S_H);
                if (board[n1, n2] != -1)
                {
                    board[n1, n2] = -1;
                    mines++;
                }
            }
            int count = 0;
            for (int i = 0; i < MAX_S_W; i++)
            {
                for (int j = 0; j < MAX_S_H; j++)
                {
                    count = 0;
                    if (board[i, j] != -1)
                    {
                        if (i != 0)
                        {
                            if (board[i - 1, j] == -1)
                            {
                                count++;
                            }
                            if (j != 0)
                            {
                                if (board[i - 1, j - 1] == -1)
                                {
                                    count++;
                                }
                            }
                            if (j != MAX_S_H - 1)
                            {
                                if (board[i - 1, j + 1] == -1)
                                {
                                    count++;
                                }
                            }
                        }

                        if (j != 0)
                        {
                            if (board[i, j - 1] == -1)
                            {
                                count++;
                            }
                        }

                        if (j != MAX_S_H - 1)
                        {
                            if (board[i, j + 1] == -1)
                            {
                                count++;
                            }
                        }

                        if (i != MAX_S_W - 1)
                        {
                            if (board[i + 1, j] == -1)
                            {
                                count++;
                            }
                            if (j != 0)
                            {
                                if (board[i + 1, j - 1] == -1)
                                {
                                    count++;
                                }
                            }
                            if (j != MAX_S_H - 1)
                            {
                                if (board[i + 1, j + 1] == -1)
                                {
                                    count++;
                                }
                            }
                        }
                        board[i, j] = count;
                    }
                }
            }
        }


        private void btn_Start_Click(object sender, EventArgs e)
        {
            finish_game = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Enabled = true;
            btn_Start.BackgroundImage = Properties.Resources.smiley;
            start_Game();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewDisableButtonCell t = (DataGridViewDisableButtonCell)dataGridView1[e.ColumnIndex, e.RowIndex];
            if (t.Enabled)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = board[e.ColumnIndex, e.RowIndex].ToString();
                t.Enabled = false;
                btn_Click(e.ColumnIndex, e.RowIndex);
            }
        }

        private void mouse_Down(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewDisableButtonCell t = (DataGridViewDisableButtonCell)dataGridView1[e.ColumnIndex, e.RowIndex];
            if (t.Enabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    btn_Start.BackgroundImage = Properties.Resources.shock;
                }
                else
                {
                    t.Enabled = false;
                    t.Value = "X";
                    mine_counter--;
                    change_Led();
                }

            }
            else
            {
                if (e.Button == MouseButtons.Right && t.Value == "X")
                {
                    t.Enabled = true;
                    t.Value = "";
                    mine_counter++;
                    change_Led();
                }
            }
        }

        private void mouse_Up(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!finish_game)
            {
                btn_Start.BackgroundImage = Properties.Resources.smiley;
            }
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAX_S_W = 9;
            MAX_S_H = 9;
            MAX_M = 10;
            btn_Start.PerformClick();
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAX_S_W = 16;
            MAX_S_H = 16;
            MAX_M = 40;
            btn_Start.PerformClick();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAX_S_W = 30;
            MAX_S_H = 16;
            MAX_M = 99;
            btn_Start.PerformClick();
        }

        public void btn_Click(int i, int j)
        {
            counter++;
            if (counter == MAX_S_W * MAX_S_H - MAX_M)
            {
                btn_Start.BackgroundImage = Properties.Resources.win;
                finish_game = true;
            }
            if (board[i, j] == 0)
            {
                dataGridView1[i, j].Value = "";
                if (i != 0)
                {
                    if (dataGridView1[i - 1, j].Value == null)
                    {
                        dataGridView1_CellContentClick(dataGridView1, new DataGridViewCellEventArgs(i - 1, j));
                    }
                    if (j != MAX_S_W - 1 && dataGridView1[i - 1, j + 1].Value == null)
                    {
                        dataGridView1_CellContentClick(dataGridView1, new DataGridViewCellEventArgs(i - 1, j + 1));
                    }
                    if (j != 0 && dataGridView1[i - 1, j - 1].Value == null)
                    {
                        dataGridView1_CellContentClick(dataGridView1, new DataGridViewCellEventArgs(i - 1, j - 1));
                    }
                }
                if (j != MAX_S_W - 1 && dataGridView1[i, j + 1].Value == null)
                {
                    dataGridView1_CellContentClick(dataGridView1, new DataGridViewCellEventArgs(i, j + 1));
                }
                if (j != 0 && dataGridView1[i, j - 1].Value == null)
                {
                    dataGridView1_CellContentClick(dataGridView1, new DataGridViewCellEventArgs(i, j - 1));
                }

                if (i != MAX_S_H - 1)
                {
                    if (dataGridView1[i + 1, j].Value == null)
                    {
                        dataGridView1_CellContentClick(dataGridView1, new DataGridViewCellEventArgs(i + 1, j));
                    }
                    if (j != MAX_S_W - 1 && dataGridView1[i + 1, j + 1].Value == null)
                    {
                        dataGridView1_CellContentClick(dataGridView1, new DataGridViewCellEventArgs(i + 1, j + 1));
                    }
                    if (j != 0 && dataGridView1[i + 1, j - 1].Value == null)
                    {
                        dataGridView1_CellContentClick(dataGridView1, new DataGridViewCellEventArgs(i + 1, j - 1));
                    }
                }
            }
            if (board[i, j] == -1)
            {
                dataGridView1[i, j].Value = "!";
                btn_Start.BackgroundImage = Properties.Resources.loss;
                dataGridView1.Enabled = false;
                finish_game = true;
            }
        }
        public void change_Led()
        {
            if (mine_counter < 0)
            {
                sevenSegment3.Value = "-";
            }

            if (mine_counter == 0)
            {
                sevenSegment3.Value = "";

            }
            sevenSegment2.Value = Math.Abs(mine_counter / 10).ToString();
            sevenSegment1.Value = Math.Abs(mine_counter % 10).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        private Mine[,] MineArray;
        private DateTime gameStartDate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CreateMineSweeper();
        }

        private void CreateMineSweeper()
        {
            this.MineArray = new Mine[20, 20];
            var mineCount = 40;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button btn1 = new Button();

                    btn1.Size = new Size(20, 20);
                    btn1.TabIndex = 0;
                    btn1.Location = new Point(20 * i, 20 * j);
                    btn1.Name = string.Format("btn_{0}_{1}", i, j);
                    btn1.Text = "";
                    
                    btn1.MouseDown += new MouseEventHandler(this.button1_MouseDown);

                    this.Controls.Add(btn1);

                    this.MineArray[i, j] = new Mine();
                    this.MineArray[i, j].MineButton = btn1;
                    if (mineCount >= 0)
                    {
                        var random = new Random((i + 21) * (j) * (DateTime.Now.Second * DateTime.Now.Hour));
                        var randomNumber = random.Next(0, 100);
                        if (randomNumber < 10)
                        {
                            this.MineArray[i, j].IsMine = true;
                            mineCount--;
                        }
                        else
                        {
                            this.MineArray[i, j].IsMine = false;
                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Label lbl1 = new Label();

                    lbl1.BorderStyle = BorderStyle.FixedSingle;
                    lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbl1.Size = new Size(20, 20);
                    lbl1.TabIndex = 0;
                    lbl1.Location = new Point(20 * i, 20 * j);
                    lbl1.Name = string.Format("lbl_{0}_{1}", i, j);
                    lbl1.Text = "";
                    if (this.MineArray[i, j].IsMine == true)
                    {
                        lbl1.Text = "*";
                    }
                    else
                    {
                        var countNighbourMines = CountNighbourMines(i, j);
                        this.MineArray[i, j].CountNighbourMines = countNighbourMines;
                        if (countNighbourMines != 0)
                        {
                            lbl1.Text = countNighbourMines.ToString();
                        }

                    }


                    this.Controls.Add(lbl1);
                    this.MineArray[i, j].MineLabel = lbl1;
                }
            }
            this.gameStartDate = DateTime.Now;
        }

        private int CountNighbourMines(int i, int j)
        {
            //  - - -
            // |+|+|+|    i-1
            //  - - -
            // |+|*|+|    i=5,j=11
            //  - - -
            // |+|+|+|    i+1
            //  - - -



            var counter = 0;

            if (i > 0)
            {
                if (j > 0)
                {
                    counter = counter + ((this.MineArray[i - 1, j - 1].IsMine == true) ? 1 : 0);
                }
                counter = counter + ((this.MineArray[i - 1, j].IsMine == true) ? 1 : 0);
                if (j < 19)
                {
                    counter = counter + ((this.MineArray[i - 1, j + 1].IsMine == true) ? 1 : 0);
                }

            }

            if (j > 0)
            {
                counter = counter + ((this.MineArray[i, j - 1].IsMine == true) ? 1 : 0);
            }
            if (j < 19)
            {
                counter = counter + ((this.MineArray[i, j + 1].IsMine == true) ? 1 : 0);
            }

            if (i < 19)
            {
                if (j > 0)
                {
                    counter = counter + ((this.MineArray[i + 1, j - 1].IsMine == true) ? 1 : 0);
                }
                counter = counter + ((this.MineArray[i + 1, j].IsMine == true) ? 1 : 0);
                if (j < 19)
                {
                    counter = counter + ((this.MineArray[i + 1, j + 1].IsMine == true) ? 1 : 0);
                }
            }


            return counter;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = (Button)sender;
            var nameParts = btn.Name.Split('_');
            var i = Convert.ToInt32(nameParts[1]);
            var j = Convert.ToInt32(nameParts[2]);



            if (e.Button == MouseButtons.Right)
            {
                if (MineArray[i, j].HasFlag == true)
                {
                    btn.BackgroundImage = null;
                    MineArray[i, j].HasFlag = false;
                }
                else
                {
                    btn.BackgroundImage = Image.FromFile(@"C:\Session13\Flag.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;

                    MineArray[i, j].HasFlag = true;

                    if (CheckIfYouWin())
                    {
                        var playTime = DateTime.Now - this.gameStartDate;

                        MessageBox.Show($"You Win!!\nYour play time is: {playTime.Seconds}");
                    }
                }
            }
            else if (e.Button == MouseButtons.Left)
            {            
                if (MineArray[i, j].HasFlag == true)
                {
                    return;
                }
                btn.Visible = false;

                if (this.MineArray[i, j].IsMine == true)
                {
                    this.MineArray[i, j].MineLabel.BackColor = Color.Red;
                    ShowAllMines();
                    MessageBox.Show("شما باختی!!!");
                    return;
                }

                if (this.MineArray[i, j].CountNighbourMines == 0)
                {
                    MakeEmptySpacesVisible(i, j);
                }
            }

        }

        private bool CheckIfYouWin()
        {
            var IsWon = true;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (this.MineArray[i, j].IsMine == true)
                    {
                        if (this.MineArray[i, j].HasFlag==false)
                        {
                            IsWon = false;
                        }
                    }
                }
            }
            return IsWon;
        }

        private void ShowAllMines()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (this.MineArray[i, j].IsMine == true)
                    {
                        this.MineArray[i, j].MineButton.Visible = false;
                    }
                }
            }
        }

        private void MakeEmptySpacesVisible(int i, int j)
        {
            if (i < 0 || j < 0 || i > 19 || j > 19)
            {
                return;
            }
            var mineItem = this.MineArray[i, j];
            mineItem.MineButton.Visible = false;

            if (mineItem.CountNighbourMines != 0)
            {
                return;
            }
            if (mineItem.HasChecked == true)
            {
                return;
            }
            mineItem.HasChecked = true;

            MakeEmptySpacesVisible(i - 1, j - 1);
            MakeEmptySpacesVisible(i - 1, j);
            MakeEmptySpacesVisible(i - 1, j + 1);

            MakeEmptySpacesVisible(i, j - 1);
            MakeEmptySpacesVisible(i, j + 1);

            MakeEmptySpacesVisible(i + 1, j - 1);
            MakeEmptySpacesVisible(i + 1, j);
            MakeEmptySpacesVisible(i + 1, j + 1);
        }
    }
}

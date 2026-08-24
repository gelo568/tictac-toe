using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Button b1, b2, b3, b4, b5, b6, b7, b8, b9;
        private Button[] buttons;
        public Form1()
        {
            InitializeComponent();
            buttons = new[] { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            foreach (var btn in buttons)
                btn.Click += PlayerMove;

            ClearGame();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            int btnSize = 60;
            int padding = 5;
            for (int i = 0; i < 9; i++)
            {
                Button b = new Button();
                b.Name = "b" + (i + 1);
                b.Size = new Size(btnSize, btnSize);
                int row = i / 3;
                int col = i % 3;
                b.Location = new Point(10 + col * (btnSize + padding), 10 + row * (btnSize + padding));
                b.TabIndex = i;
                b.Text = "";
                // assign to the corresponding field
                switch (i)
                {
                    case 0: b1 = b; break;
                    case 1: b2 = b; break;
                    case 2: b3 = b; break;
                    case 3: b4 = b; break;
                    case 4: b5 = b; break;
                    case 5: b6 = b; break;
                    case 6: b7 = b; break;
                    case 7: b8 = b; break;
                    case 8: b9 = b; break;
                }
                this.Controls.Add(b);
            }

            this.ClientSize = new Size(10 + 3 * (btnSize + padding), 10 + 3 * (btnSize + padding));
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
        }

        private void PlayerMove(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            if (btn is Button)
            {
                btn.Text = "X";
                btn.Enabled = false;
            }
        }


        private void ClearGame()
        {
            foreach (var button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }
        }
    }
}
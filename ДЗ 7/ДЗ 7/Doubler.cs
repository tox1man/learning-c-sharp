using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ_7
{
    public partial class Doubler : Form
    {
        static int RandomTarget;
        static int TryNumber = 10;
        static int TryCount;

        Stack<int> HistoryStack = new Stack<int>();

        string PlayMessage = $"С помощью удвоения и инкремента достигните заданного числа за {TryNumber} попыток.";
        string WinMessage = "Вы победили!";
        string LoseMessage = "Вы истратили все попытки";

        public Doubler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Doubler Game";
            this.Width = 294;
            this.Height = 200;
            btnDouble.Text = "x2";
            btnPlusOne.Text = "+1";
            btnPlay.Text = "Play";
        }

        private void CheckWin()
        {
            int current = int.Parse(lblResult.Text);
            if (current == RandomTarget) { ShowMessage(WinMessage); ResetGame(); }
            else {
                if (TryCount == TryNumber - 1) { ShowMessage(LoseMessage); ResetGame(); }
            }
            TryCount++;
        }

        private void ResetGame()
        {
            RandomTarget = 0;
            TryCount = 0;
            lblResult.Text = "1";
            HistoryStack.Clear();
            HistoryStack.Push(int.Parse(lblResult.Text));
            SwitchControlButtons();
        }

        private void SetTarget()
        {
            RandomTarget = new Random().Next(2, 100);
            lblTarget.Text = RandomTarget.ToString();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(lblResult.Text) * 2).ToString();
            HistoryStack.Push(int.Parse(lblResult.Text));
            CheckWin();
        }

        private void btnPlusOne_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(lblResult.Text) + 1).ToString();
            HistoryStack.Push(int.Parse(lblResult.Text));
            CheckWin();
        }
        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (HistoryStack.Count > 1) { 
                HistoryStack.Pop();
                lblResult.Text = HistoryStack.Peek().ToString();
                CheckWin();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ResetGame();
            SetTarget();
            ShowMessage(PlayMessage);
            
        }

        private void SwitchControlButtons()
        {
            btnDouble.Visible = !btnDouble.Visible;
            btnPlusOne.Visible = !btnPlusOne.Visible;
            btnPlay.Visible = !btnPlay.Visible;
            btnReverse.Visible = !btnReverse.Visible;
        }

        private void ShowMessage(string msg)
        {
            MessageBox.Show(msg, "Doubler Game");
        }
    }
}

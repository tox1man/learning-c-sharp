using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задача_2
{
    public partial class Guesser : Form
    {
        int target;
        int guess;
        int maxTryCount = 10;
        int tryCount = 0;

        string winMessage = "Вы победили.";
        string loseMessage = "Вы исчерпали все попытки.";
        string lowGuess = "Попробуйте больше.";
        string highGuess = "Попробуйте меньше.";

        public Guesser()
        {
            InitializeComponent();
            
        }

        private void Guesser_Load(object sender, EventArgs e)
        {
            this.Text = "Guess the number";

            btnPlay.Size = new Size(100, 40);
            btnGuess.Size = new Size(100, 40);

            btnPlay.Location = new Point(this.ClientSize.Width / 2 - btnPlay.Size.Width / 2, this.ClientSize.Height - btnPlay.Size.Height * 2);
            btnGuess.Location = new Point(this.ClientSize.Width / 2 - btnGuess.Size.Width / 2, this.ClientSize.Height - btnGuess.Size.Height * 2);
            lblInfo.Location = new Point(lblInfo.Width / 8, txtBox.Location.Y + txtBox.Height + lblInfo.Height);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            target = new Random().Next(1, 100);
            HideButton(btnPlay);
            ShowButton(btnGuess);
            ShowTextForm();
        }

        private void ShowTextForm()
        {
            txtBox.Visible = true;
            return;
        }
        private void HideTextForm()
        {
            txtBox.Visible = false;
            return;
        }

        private void ShowButton(Button btn)
        {
            btn.Visible = true;
            return;
        }

        private void HideButton(Button btn)
        {
            btn.Visible = false;
            return;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtBox.Text, out guess))
            {
                lblInfo.Text = "Неверный формат числа.";
                txtBox.Text = String.Empty;
                return;
            }
            else
            {
                listBoxHistory.Items[tryCount] += guess.ToString();
                txtBox.Text = String.Empty;
                tryCount++;
                CheckAnswer(guess);
            }
        }

        private void CheckAnswer(int guess)
        {
            if(tryCount < maxTryCount - 1)
            {
                if (guess.CompareTo(target) < 0)
                {
                    lblInfo.Text = lowGuess;
                }
                else if (guess.CompareTo(target) > 0)
                {
                    lblInfo.Text = highGuess;
                }
                else
                {
                    EndGame(true);
                }
            }
            else
            {
                EndGame(false);
            }
        }

        private void EndGame(bool isWin)
        {
            if (isWin)
            {
                MessageBox.Show(winMessage);
                ResetGame();
            }
            else
            {
                MessageBox.Show(loseMessage);
                ResetGame();
            }
        }

        private void ResetGame()
        {
            tryCount = 0;
            HideButton(btnGuess);
            ShowButton(btnPlay);
            HideTextForm();
            txtBox.Text = String.Empty;
            lblInfo.Text = "Введите число от 1 до 100";
            ClearHistory();
        }

        private void ClearHistory()
        {
            for (int i = 0; i < 10; i++)
            {
                listBoxHistory.Items[i] = $"{i+1}. ";
            }
        }
    }
}

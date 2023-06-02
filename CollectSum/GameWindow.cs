using System;
using System.Windows.Forms;

namespace CollectSum
{
    public partial class GameWindow : Form
    {
        private const string LeftArrow = "🠔";
        private const string RightArrow = "🠖";

        private GameHandler _game;
        private bool _isGameOver;

        public GameWindow()
        {
            InitializeComponent();
            ResetGame();
            UpdateData();
        }

        private void UpdateData()
        {
            leftRoundScore.Text = $@"{_game.LeftPlayer.RoundScore}";
            rightRoundScore.Text = $@"{_game.RightPlayer.RoundScore}";

            leftReceivedNumber.Text = $@"+{_game.LeftPlayer.RecivedNumber}";
            rightReceivedNumber.Text = $@"+{_game.RightPlayer.RecivedNumber}";

            leftTotalScore.Text = $@"{_game.LeftPlayer.TotalScore}";
            rightTotalScore.Text = $@"{_game.RightPlayer.TotalScore}";

            turnArrowIndicatorLabel.Text = _game.IsLeftTurn ? LeftArrow : RightArrow;
            turnTextIndicatorLabel.Text = _game.IsLeftTurn ? "Left" : "Right";

            roundCounterLabel.Text = $@"Round  #{_game.CurrentRound + 1}";
        }

        private void ResetGame()
        {
            _game = new GameHandler(3, 2, 31); // Параметры новой игры
            _isGameOver = false;
            maxScoreLabel.Text = $@"Max score:  {_game.MaxScore}";
            takeButton.Cursor = Cursors.Hand;
            passButton.Cursor = Cursors.Hand;
        }

        private void GameOver()
        {
            UpdateData();
            if (_game.LeftPlayer.TotalScore == _game.RightPlayer.TotalScore)
            {
                MessageBox.Show("----------Draw!----------", "Draw");
            }
            else
            {
                Player winner = _game.LeftPlayer.TotalScore > _game.RightPlayer.TotalScore
                    ? _game.LeftPlayer
                    : _game.RightPlayer;
                MessageBox.Show($"-------Game Over!-------\nWinner — {winner.Name}\nTotal Score — {winner.TotalScore}\n-----------------------------", "Game Over");
            }
            _isGameOver = true;
            takeButton.Cursor = Cursors.No;
            passButton.Cursor = Cursors.No;
        }

        private void takeButton_Click(object sender, EventArgs e)
        {
            if (_isGameOver)
            {
                return;
            }

            if (_game.AddNumberToPlayer())
            {
                UpdateData();
            }
            else
            {
                GameOver();
            }
        }

        private void passButton_Click(object sender, EventArgs e)
        {
            if (_isGameOver)
            {
                return;
            }

            if (_game.PassPlayer())
            {
                UpdateData();
            }
            else
            {
                GameOver();
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            ResetGame();
            UpdateData();
            MessageBox.Show(@"Game is restarted!", "Restart");
        }
    }
}
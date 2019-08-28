using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YanivCardGame
{
    public partial class GameSetUpForm : Form
    {
        public GameSetUpForm()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                //when user clicks play button, player object is instantiated and then a game object is. 
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Please enter name");
                    return;
                    //throw new ArgumentException("Please enter a name into name box");
                }

                Player player = new Player(nameTextBox.Text);
                YanivGame game = new YanivGame(player, (int) numComBox.Value, difficultyBox.Text);
                this.Hide();
                GameBoard gameBoard = new GameBoard(game);
                gameBoard.ShowDialog();
            }
            //find more specific argument exception, maybe make own type?
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

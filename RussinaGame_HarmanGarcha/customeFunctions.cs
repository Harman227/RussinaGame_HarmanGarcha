
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussinaGame_HarmanGarcha
{
    public class customeFunctions
    {
        public void ongame(PictureBox tr)
        {
            tr.Image = RussinaGame_HarmanGarcha.Properties.Resources.start_Game;
        }
        public void loadgame(PictureBox tr)
        {
            tr.Image = RussinaGame_HarmanGarcha.Properties.Resources.load_game;
        }
        public void spingame(PictureBox tr)
        {
            tr.Image = RussinaGame_HarmanGarcha.Properties.Resources.spin;
        }
        public void shootgame(PictureBox tr)
        {
            tr.Image = RussinaGame_HarmanGarcha.Properties.Resources.shoot_game;
        }
        public void shootawaygame(PictureBox tr)
        {
            tr.Image = RussinaGame_HarmanGarcha.Properties.Resources.shoot_away;
        }
    }
}

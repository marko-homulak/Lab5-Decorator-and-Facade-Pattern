using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public static class CharacterFacade
    {
        public static void DetermineWinner(Character fighter1, Character fighter2)
        {
            int fighter1HitPoint = fighter1.HPeffect();
            int fighter2HitPoint = fighter2.HPeffect();

            int fighter1AttackPower = fighter1.AttackEffect();
            int fighter2AttackPower = fighter2.AttackEffect();

            int fighter1DefencePoint = fighter1.DefenceEffect();
            int fighter2DefencePoint = fighter2.DefenceEffect();

            int fighter1HitsToWin = (int)Math.Ceiling((double)(fighter2HitPoint + fighter2DefencePoint) / fighter1AttackPower);
            int fighter2HitsToWin = (int)Math.Ceiling((double)(fighter1HitPoint + fighter1DefencePoint) / fighter2AttackPower);

            if (fighter1HitsToWin < fighter2HitsToWin)
            {
                MessageBox.Show($"\"{fighter1.name}\" wins against \"{fighter2.name}\"!");
            }
            else if (fighter2HitsToWin < fighter1HitsToWin)
            {
                MessageBox.Show($"\"{fighter2.name}\" wins against \"{fighter1.name}\"!");
            }
            else
            {
                MessageBox.Show($"It's a draw between \"{fighter1.name}\" and \"{fighter2.name}\"!");
            }
        }
    }
}

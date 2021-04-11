using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gaming_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Player player;
        List<Enemy> enemies = new List<Enemy>();
        public MainWindow()
        {
            InitializeComponent();

            BattleCanvas.Visibility = Visibility.Collapsed;
            StartGameCanvas.Visibility = Visibility.Visible;

        }

        public void reStartGame()
        {
            enemies.Clear();
            player = null;
            BattleCanvas.Visibility = Visibility.Collapsed;
            StartGameCanvas.Visibility = Visibility.Visible;
        }

        private void SetRace_Click(object sender, RoutedEventArgs e)
        {
            player.changeRace(RaceChoiceBox.Text);
        }

        private void SetName_Click(object sender, RoutedEventArgs e)
        {
            player = new Player(NameInput.Text);
        }

        private void SetRole_Click(object sender, RoutedEventArgs e)
        {
            player.changeRole(RoleChoiceBox.Text);
        }

        private void StartCombat_Click(object sender, RoutedEventArgs e)
        {
            PlayerHealthLbl.Content = player.race.stamina;

            Random random = new Random();
            int startup = random.Next(3, 20);
            for(int i = 0; i < startup; i++)
            {
                Enemy enemy = new Enemy(random.Next(5, 120), random.Next(2, 10));
                enemies.Add(enemy);
            }
            AIHealthLbl.Content = enemies[0].getHP();


            BattleCanvas.Visibility = Visibility.Visible;
            StartGameCanvas.Visibility = Visibility.Collapsed;
        }

        private void Attack_Click(object sender, RoutedEventArgs e)
        {
            player.race.role.attack(enemies[0]);
            enemyTurn();
        }

        private void RacialAbilityBtn_Click(object sender, RoutedEventArgs e)
        {
            player.race.racialAbility();
            enemyTurn();
        }

        private void ClassAbilityBtn_Click(object sender, RoutedEventArgs e)
        {
            player.race.role.classAbility();
            enemyTurn();
        }

        public void enemyTurn()
        {
            AIHealthLbl.Content = enemies[0].getHP();

            if (enemies[0].isAlive())
            {
                player.takeDmg(enemies[0].attack());
            }
            else
            {
                enemies.RemoveAt(0);

                if (enemies.Count() <= 0)
                {
                    reStartGame();

                }

                enemyTurn();
            }

            PlayerHealthLbl.Content = player.race.stamina;
            if(player.race.stamina <= 0)
            {
                reStartGame();
            }
        }
    }
}

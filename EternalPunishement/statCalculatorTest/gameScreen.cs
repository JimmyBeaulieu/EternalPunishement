using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace statCalculatorTest
{
    public partial class gameScreen : Form
    {
        Character player = new Character();
        Character enemy = new Character();

        Random random = new Random();


        //TEH NONE ITEM, THE ONE AND ONLY
        Item none = new Item();

        //weapons
        Item fists = new Item("Fists", "\nYour own fists\n\nYou notice how pale your skin became ever since you accepted the Pallidus.\nNot much but better than nothing.\n\nAttack Rating: 5\nScales with all stats","weapon");
        Item sword = new Item("Sword", "\nA short sword.\n\nNot the one you're used to, you seem to have misplaced your new pale blade, Pallidus but this one will do for now\n\nAttack Rating: 20\nScales with:\nStrength, Dexterity, Sharpness, Agility", "weapon");
        Item dagger = new Item("Dagger", "\nA pointy dagger.\n\nA small dagger used by thief for stealth assassinations.\nMore likely to land a critical hit\n\nAttack Rating: 10\nScales with:\nDexterity, Sharpness, Agility", "weapon");
        //Weapon 3
        //Weapon 4
        //Weapon 5

        //trinkets
        Item ringOfRage = new Item("Ring of Rage", "\nA ring that was rumored to have been crafted using the tools of an unkown God\nFills you with an unending rage, upping your attack every turns", "trinket");
        Item patchOfHealing = new Item("Leaf of Lignum Vitae", "\nA leaf from the tree of legend, Lignum Vitae\nStick it on your skin and the inherent magical property will keep it on your skin and will heal a bit every turn", "trinket");
        //trinket 2
        //trinket 3
        //trinket 4
        //trinket 5

        //recovery items
        Item potionMinorHealing = new Item("Potion of minor healing", "\nA potion crafted using the sap of the tree of legend, Lignum Vitae. The process uses very complex method of dilution over many weeks, no man can drink the sap directly.", "recovery");
        Item tonic = new Item("Tonic", "A concoction of a mix of caffeine, sugar, taurine and B12\nWill help you stay focused and make you more accurate", "recovery");
        //recovery 2
        //recovery 3
        //recovery 4
        //recovery 5  

        string timer;
        int seconds = 0;
        int minutes=0;
        int hours=0;
        int textSpeed=2;

        int numberOfKill=0;
        int numberOfUsedItems=0;

        bool okay = false;
        bool inACombat = false;
        int levelUpStored=0;

        public gameScreen()
        {
            InitializeComponent();
        }



        private void gameScreen_Load(object sender, EventArgs e)
        {
            StatButton.Visible = false;
            EnemyStatButton.Visible = false;
            ShowWeaponButton.Visible = false;
            EnemyHealthBar.Visible = false;
            AttackButton.Visible = false;
            UseItemButton.Visible = false;

            textSpeed = 2;


            //load/save shennanigans
            string saveName="?";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveName = openFileDialog.FileName;

            }

            if (saveName == "?")
            {
                Application.Exit();
            }
            else
            {
                foreach (string line in File.ReadAllLines(saveName))
                {
                    string[] data = line.Split('|');
                    player.Name = data[0];
                    player.Level = Convert.ToInt32(data[1]);
                    player.Experience = Convert.ToInt32(data[2]);
                    player.Strength = Convert.ToDouble(data[3]);
                    player.Dexterity = Convert.ToDouble(data[4]);
                    player.Constitution = Convert.ToDouble(data[5]);
                    player.Sharpness = Convert.ToDouble(data[6]);
                    player.Mindfulness = Convert.ToDouble(data[7]);
                    player.Agility = Convert.ToDouble(data[8]);
                    player.MaxHP = Convert.ToDouble(data[9]);
                    player.CurrentHP = Convert.ToDouble(data[10]);
                    player.MaxEquipLoad = Convert.ToDouble(data[11]);
                    player.LightWeaponEfficiency = Convert.ToDouble(data[12]);
                    player.HeavyWeaponEfficiency = Convert.ToDouble(data[13]);
                    player.MagicResistance = Convert.ToDouble(data[14]);
                    player.PhysicalResistance = Convert.ToDouble(data[15]);
                }
            }

            ////items
            ///
            ItemAdder(fists, "weapon");
            ItemAdder(none, "trinket");
            ItemAdder(none, "recovery");
            EquippedWeaponBox.SelectedIndex = 0;
            EquippedTrinketBox.SelectedIndex = 0;
            EquippedRecoveryBox.SelectedIndex = 0;
            ItemAdder(dagger, "weapon");
            ItemAdder(sword, "weapon");
            ItemAdder(ringOfRage, "trinket");
            ItemAdder(patchOfHealing, "trinket");
            ItemAdder(potionMinorHealing, "recovery");
            ItemAdder(tonic, "recovery");
        }

        private void GameTime_Tick(object sender, EventArgs e)
        {
            timer = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
            seconds++;
            if(seconds == 60) { minutes++; };
            if(minutes == 60) { hours++; };

            ////ui element
            //Stats
            if (player.Experience > 99)
            {
                levelUpStored++;
                player.Experience -= 100;
                PopupGenerator("You leveled up! look in your stat tab!", "Level up!");

            }


            NameLabel.Text = player.Name;
            CurrentHPLabel.Text = player.CurrentHP.ToString("");
            MaxHPLabel.Text = player.MaxHP.ToString("");
            StrengthLabel.Text = player.Strength.ToString("");
            DexterityLabel.Text = player.Dexterity.ToString("");
            ConstitutionLabel.Text = player.Constitution.ToString("");
            SharpnessLabel.Text = player.Sharpness.ToString("");
            MindfulnessLabel.Text = player.Mindfulness.ToString("");
            AgilityLabel.Text = player.Agility.ToString("");
            LevelLabel.Text = player.Level.ToString("");
            ExperienceBar.Value = player.Experience;

            MainTextBox.Update();
            
            
            //enemy health bar
            EnemyHealthBar.Maximum = Convert.ToInt32(enemy.MaxHP);
            int enemyPercentage = Convert.ToInt32(enemy.CurrentHP / enemy.MaxHP) * 100;

            EnemyHealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            if (enemy.CurrentHP < 1) { enemy.CurrentHP = 0; }
            if (enemyPercentage < 50) { EnemyHealthBar.ForeColor = Color.Yellow; }
            if (enemyPercentage < 20) { EnemyHealthBar.ForeColor = Color.Red; }
            EnemyHealthBar.Value = Convert.ToInt32(enemy.CurrentHP);


            //Stats+
            MaxEquipLoadLabel.Text = player.MaxEquipLoad.ToString("");
            LightWeaponEfficiencyLabel.Text = player.LightWeaponEfficiency.ToString("");
            HeavyWeaponEfficiencyLabel.Text = player.HeavyWeaponEfficiency.ToString("");
            MagicResistanceLabel.Text = player.MagicResistance.ToString("");
            PhysicalResistanceLabel.Text = player.PhysicalResistance.ToString("");
            //options
            GameTimeLabel.Text = timer;
            KillLabel.Text = numberOfKill.ToString();
            UsedItemLabel.Text = numberOfUsedItems.ToString();
            textSpeed = TextSpeedBar.Value;
            //level

            if (levelUpStored < 1)
            {
                HealthAddButton.Visible = false;
                StrengthAddButton.Visible = false;
                DexterityAddButton.Visible = false;
                ConstitutionAddButton.Visible = false;
                SharpnessAddButton.Visible = false;
                MindfulnessAddButton.Visible = false;
                AgilityAddButton.Visible = false;
            }
            if (levelUpStored > 0)
            {
                HealthAddButton.Visible = true;
                StrengthAddButton.Visible = true;
                DexterityAddButton.Visible = true;
                ConstitutionAddButton.Visible = true;
                SharpnessAddButton.Visible = true;
                MindfulnessAddButton.Visible = true;
                AgilityAddButton.Visible = true;
            }

            if (inACombat==true)
            {
                AttackButton.Visible = true;
                UseItemButton.Visible = true;
                OkayButton.Visible = false;
            }
            if (inACombat==false)
            {
                AttackButton.Visible = false;
                UseItemButton.Visible = false;
                OkayButton.Visible = true;

            }


        }

        /////////////////////////////////////////////////////////////////gameplay
        ///

        private void Combat()
        {
            player.damage = 0;
            enemy.damage = 0;
            player.criticalHit = false;
            double playerSpeed;
            double enemySpeed;

            //speed calculation
            playerSpeed = ((player.Agility * 1.5) + (player.Dexterity * 1.2) + (player.CurrentHP) - (player.Constitution * 0.5));
            enemySpeed = ((enemy.Agility * 1.5) + (enemy.Dexterity * 1.2) + (enemy.CurrentHP) - (enemy.Constitution * 0.5));

            //before combat starts
            if (EquippedTrinketBox.Text == "Ring of Rage")
            {
                player.damage += 5;
            }
            //Combat starts


            //player attacks first
            if (playerSpeed > enemySpeed)
            {
                Chat(player.Name + " attacks first!");
                UsingWeapon(EquippedWeaponBox.Text, player, IntRNG(0, 10));
                if (player.damage == 0)
                {
                    Chat(player.Name + " missed!");
                }
                else
                {
                    player.damage *= (enemy.PhysicalResistance / 10);
                    player.damage *= DoubleRNG(85, 100) / 100;

                    Math.Round(player.damage);
                    if (player.criticalHit == true)
                    {
                        ChatCritical("Critical Hit!!!");

                        Chat(player.Name + " hits with their "+EquippedWeaponBox.Text+"!");
                    }
                    else
                    {
                        Chat(player.Name + " hits with their "+EquippedWeaponBox.Text+"!");
                    }
                    enemy.CurrentHP -= player.damage;
                }
                Chat(enemy.Name + " is attacking!");
                if (IntRNG(0, 10) == 0)
                {
                    Chat(enemy.Name + " misses!");
                    enemy.damage = 0;
                }
                else if (IntRNG(0, 10) == 10)
                {
                    enemy.damage = ((enemy.Strength * 4) + (enemy.Dexterity * 4) + (enemy.Agility * 4)) * player.PhysicalResistance / 100;
                    enemy.damage *= DoubleRNG(85, 100) / 100;
                    Math.Round(enemy.damage);
                    ChatCritical("Critical Hit!!!");
                    Chat(enemy.Name + " hits!");
                }
                else
                {
                    enemy.damage = ((enemy.Strength * 4) + (enemy.Dexterity * 4) + (enemy.Agility * 4)) * player.PhysicalResistance / 100;
                    Math.Round(enemy.damage);
                    Chat(enemy.Name + " hits!");
                }
                player.CurrentHP -= enemy.damage;
            }
            //Enemy attacks first
            if (playerSpeed < enemySpeed)
            {
                Chat(enemy.Name + " is attacking first!");
                enemy.damage = ((enemy.Strength * 4) + (enemy.Dexterity * 4) + (enemy.Agility * 4)) * player.PhysicalResistance / 100;
                enemy.damage *= DoubleRNG(85, 100) / 100;
                Math.Round(enemy.damage);
                if (IntRNG(0, 10) == 0)
                {
                    Chat(enemy.Name + " misses!");
                    enemy.damage = 0;
                }
                else if (IntRNG(0, 10) == 10)
                {
                    ChatCritical("Critical Hit!!!");
                    Chat(enemy.Name + " hits!");
                }
                else
                {
                    Chat(enemy.Name + " hits!");
                }
                player.CurrentHP -= enemy.damage;
                Chat(player.Name + " attacks!");
                UsingWeapon(EquippedWeaponBox.Text, player, IntRNG(0, 10));
                player.damage *= (enemy.PhysicalResistance / 10);
                player.damage *= DoubleRNG(85, 100) / 100;
                if (player.damage == 0)
                {
                    Chat(player.Name + " missed!");
                }
                else
                {
                    if (player.criticalHit == true)
                    {
                        ChatCritical("Critical Hit!!!");

                        Chat(player.Name + " hits with their "+EquippedWeaponBox.Text+"!");
                    }
                    else
                    {
                        Chat(player.Name + " hits with their "+EquippedWeaponBox.Text+"!");
                    }
                    enemy.CurrentHP -= player.damage;

                }
                //After combat
                if (EquippedTrinketBox.Text == "Leaf of Lignum Vitae")
                {
                    player.CurrentHP += 5;
                    Chat(player.Name + "'s Leaf of Lignum Vitae healed them a bit");
                }
            }
                if((enemy.CurrentHP <1)||(player.CurrentHP < 1))
                {
                    inACombat = false;
                }


            void UsingWeapon(string weapon, Character user, int critical)
            {
                if (critical == 0)
                {
                    user.damage = 0;
                }

                    if (weapon == "Fists")
                {
                    if (critical == 10)
                    {
                        user.damage = 10;
                        user.criticalHit = true;
                    }
                    else
                    {
                        user.damage = 5;
                    }
                }
                if (weapon == "Sword")
                {
                    if (critical == 10 )
                    {
                        user.damage = 40;
                        user.criticalHit= true;
                    }
                    else
                    {
                        user.damage = 20;
                    }
                }
                if (weapon == "Dagger")
                {
                    if (critical > 5)
                    {
                        user.damage = 30;
                        user.criticalHit = true;
                    }

                    else
                    {
                        user.damage = 10;
                    }

                }
                else
                {
                    if (critical == 10)
                    {
                        user.damage = 10;
                        user.criticalHit = true;
                    }
                    else
                    {
                        user.damage = 5;
                    }
                }
            }

        }

        private void ItemAdder(Item item, string type)
        {
            if (type == "weapon")
            {
                EquippedWeaponBox.Items.Add(item.Name); ;

            }
            if (type == "trinket")
            {
                EquippedTrinketBox.Items.Add(item.Name);

            }
            if (type == "recovery")
            {
                EquippedRecoveryBox.Items.Add(item.Name);

            }
        }


        private void EnemyGenerator(int playerLevel)
        {
            if (playerLevel < 21)
            {
                enemy.Name = EnemyNameGenerator("a rat","a feral cat", "a huge spider", "a wild boar", "an angry squirrel");
                
                enemy.Level = IntRNG(10, 20);
                EnemyStatParser(enemy.Level - 6);
                enemy.statCalculation();
            }
            EnemyHealthBar.Visible = true;
            if (enemy.Name == "a rat")
            {
                EnemyPictureBox.Image = statCalculatorTest.Properties.Resources.evil_rat1;
            }
            if (enemy.Name == "a feral cat")
            {
                EnemyPictureBox.Image = global::statCalculatorTest.Properties.Resources.evil_cat;
            }
            if (enemy.Name == "a huge spider")
            {
                EnemyPictureBox.Image = global::statCalculatorTest.Properties.Resources.evil_spider;

            }
            if (enemy.Name == "a wild boar")
            {
                EnemyPictureBox.Image = global::statCalculatorTest.Properties.Resources.evil_boar;

            }
            if (enemy.Name == "an angry squirrel")
            {
                EnemyPictureBox.Image = global::statCalculatorTest.Properties.Resources.evil_squirrel;

            }


        }

        private void EnemyStatParser(int range)
        {
            for (int i = 0; i < range; i++)
            {
                switch (IntRNG(0, 5)) {
                    case 0: enemy.Strength++;
                        break;
                    case 1: enemy.Dexterity++;
                        break;
                    case 2: enemy.Constitution++;
                        break;
                    case 3: enemy.Sharpness++;
                        break;
                    case 4: enemy.Mindfulness++;
                        break;
                    case 5: enemy.Agility++;
                        break;
                }

            }

        }
        /////////////////////////////////////////////////////////////////story progression

        public void Story0()
        {
            Chat("You wake up in the middle of a field, you don't remember anything...");
            Chat("...where am I, what happened??", player);
            Chat("All of a sudden, a monster attacks!");
            AutoSave();
            inACombat = true;
            EnemyGenerator(player.Level);
            Combat();
            if(inACombat == false)
            {
                Story1();
            }
        }
        public void Story1()
        {
            Chat("You look around, you can see a cariage tipped over and almost completely destroyed.");
            Chat("There are bodies of what was your escort...");
            Chat("You search around for your weapon but you can't find it anywhere...");
            Chat("You manage to find a dagger!");
            Chat("You can find your equipement under the Items tab on the right handside menu");
            ItemAdder(dagger, "weapon");
            Chat("You don't remember anything but you can see that the road leads to what seems like an inn not too far.");

        }


        /////////////////////////////////////////////////////////////////utility

        private void Chat(string text)
        {
            if (textSpeed == 0)
            {
                System.Threading.Thread.Sleep(2000);
            MainTextBox.AppendText(timer + ":>" + text + "\n");
            }
            if(textSpeed == 1)
            {
                System.Threading.Thread.Sleep(1500);
                MainTextBox.AppendText(timer + ":>" + text + "\n");

            }
            if (textSpeed == 2)
            {
                System.Threading.Thread.Sleep(1000);
                MainTextBox.AppendText(timer + ":>" + text + "\n");

            }
            if (textSpeed == 3)
            {
                System.Threading.Thread.Sleep(500);
                MainTextBox.AppendText(timer + ":>" + text + "\n");

            }
            if (textSpeed == 4)
            {
                MainTextBox.AppendText(timer + ":>" + text + "\n");

            }
            MainTextBox.SelectionStart = MainTextBox.Text.Length;
            MainTextBox.ScrollToCaret();
        }
        private void Chat(string text, Character speaker)
        {
            MainTextBox.AppendText(timer + ":>" + speaker.Name+" says:"+ text + "\n");
            if (textSpeed == 0)
            {
                System.Threading.Thread.Sleep(2000);
            }
            if (textSpeed == 1)
            {
                System.Threading.Thread.Sleep(1500);

            }
            if (textSpeed == 2)
            {
                System.Threading.Thread.Sleep(1000);

            }
            if (textSpeed == 3)
            {
                System.Threading.Thread.Sleep(500);
            }
            if (textSpeed == 4)
            {

            }
            MainTextBox.SelectionStart = MainTextBox.Text.Length;
            MainTextBox.ScrollToCaret();
        }
        private void ChatCritical(string text)
        {
            MainTextBox.AppendText(timer + ":>");
            MainTextBox.SelectionFont = new Font("Sans Serif", 10);
            MainTextBox.SelectionColor = Color.DarkRed;
            MainTextBox.AppendText(" " + text+"\n");
            MainTextBox.SelectionColor = Color.Black;
            MainTextBox.SelectionFont = new Font("Sans Serif", 8);

        }


        private void PopupGenerator(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }

        }
        private double DoubleRNG(double minimum, double maximum)
        {

            return Convert.ToDouble(random.Next(Convert.ToInt32(minimum),Convert.ToInt32(maximum)));
        }
        private int IntRNG(int minimum, int maximum)
        {
            return random.Next(minimum, maximum);
        }
        private string EnemyNameGenerator(string name0, string name1, string name2, string name3, string name4)
        {
            string[] enemyName = { name0, name1, name2, name3, name4 };
            return enemyName[IntRNG(0, 4)];
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if(okay == false)
            {
                Story0();
            }
        }
        private void ShowWeaponButton_Click(object sender, EventArgs e)
        {
            if(EquippedWeaponBox.Text == "Fists")
            {
                PopupGenerator(fists.Name + "\n" + fists.Description, "Fists description");
            }
            if (EquippedWeaponBox.Text == "Sword")
            {
                PopupGenerator(sword.Name +"\n"+ sword.Description, "Sword description");
            }
            if (EquippedWeaponBox.Text == "Dagger")
            {
                PopupGenerator(dagger.Name +"\n"+ dagger.Description, "Dagger description");
            }

        }

        private void ShowTrinketButton_Click(object sender, EventArgs e)
        {
            if(EquippedTrinketBox.Text == "None")
            {
                PopupGenerator("Nothing here", "Nothing here");
            }
            if(EquippedTrinketBox.Text == "Ring of Rage")
            {
                PopupGenerator(ringOfRage.Name + "\n" + ringOfRage.Description, "Ring of rage description");
            }
            if(EquippedTrinketBox.Text == "Leaf of Lignum Vitae")
            {
                PopupGenerator(patchOfHealing.Name + "\n" + patchOfHealing.Description, "Leaf of Lignum Vitae description");
            }
        }

        private void ShowRecoveryButton_Click(object sender, EventArgs e)
        {
            if (EquippedRecoveryBox.Text == "None")
            {
                PopupGenerator("Nothing here", "Nothing here");
            }

            if (EquippedRecoveryBox.Text == "Potion of minor healing")
            {
                PopupGenerator(potionMinorHealing.Name + "\n" + potionMinorHealing.Description, "Potion of minor healing description");
            }
            if(EquippedRecoveryBox.Text == "Tonic")
            {
                PopupGenerator(tonic.Name + "\n" + tonic.Description, "Tonic description");
            }

        }

        private void StatButton_Click(object sender, EventArgs e)
        {
            PopupGenerator(player.StatSheet(), "Your stats!");
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            if (inACombat == true)
            {
                Combat();
                if(player.CurrentHP < 1)
                {
                    PopupGenerator("You died!", "You died!");
                    Application.Exit();
                }
                if(enemy.CurrentHP < 1)
                {
                    PopupGenerator("You killed " + enemy.Name + "!\nYou made " + enemy.Level + "XP!", "You killed " + enemy.Name);
                    player.Experience += enemy.Level;
                    numberOfKill++;
                }

            }
        }

        private void EnemyStatButton_Click(object sender, EventArgs e)
        {
            PopupGenerator(enemy.StatSheet(), enemy.Name + "'s stats");
        }

        private void HealthAddButton_Click(object sender, EventArgs e)
        {
            player.MaxHP++;
            levelUpStored--;
        }

        private void MindfulnessAddButton_Click(object sender, EventArgs e)
        {
            player.Mindfulness++;
            levelUpStored--;
        }

        private void SharpnessAddButton_Click(object sender, EventArgs e)
        {
            player.Sharpness++;
            levelUpStored--;
        }

        private void ConstitutionAddButton_Click(object sender, EventArgs e)
        {
            player.Constitution++;
            levelUpStored--;
        }

        private void DexterityAddButton_Click(object sender, EventArgs e)
        {
            player.Dexterity++;
            levelUpStored--;
        }

        private void StrengthAddButton_Click(object sender, EventArgs e)
        {
            player.Strength++;
            levelUpStored--;
        }

        private void AgilityAddButton_Click(object sender, EventArgs e)
        {
            player.Agility++;
            levelUpStored--;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex != 2)
            {
                ShowWeaponButton.Visible = false;
                ShowRecoveryButton.Visible = false;
                ShowTrinketButton.Visible = false;
            }
            else
            {
                ShowWeaponButton.Visible = true;
                ShowRecoveryButton.Visible = true;
                ShowTrinketButton.Visible = true;
            }
        }

        private void SaveExitButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(player.Name + ".txt")) // If file does not exists
            {
                File.Create(player.Name + ".txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText(player.Name + ".txt"))
                {
                    sw.WriteLine(player.Save()); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                File.WriteAllText(player.Name + ".txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(player.Name + ".txt"))
                {
                    sw.WriteLine(player.Save()); // Write text to .txt file
                }
            }
            PopupGenerator("Character saved, game will close", "Success");
            Application.Exit();
        }

        private void AutoSave()
        {
            if (!File.Exists(player.Name + ".txt")) // If file does not exists
            {
                File.Create(player.Name + ".txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText(player.Name + ".txt"))
                {
                    sw.WriteLine(player.Save()); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                File.WriteAllText(player.Name + ".txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(player.Name + ".txt"))
                {
                    sw.WriteLine(player.Save()); // Write text to .txt file
                }
            }

        }
    }
}

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


//todo:
//make the button inactive when rmaxPoint == 0


namespace statCalculatorTest
{
    public partial class Form1 : Form
    {
        Character player = new Character();
        double maxPoint=0;
        //double strengthPoint = 1;
        //double dexterityPoint = 1;
        //double constitutionPoint = 1;
        //double sharpnessPoint = 1;
        //double mindfulnessPoint = 1;
        //double agilityPoint = 1;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            NameEntryBox.Text = "Pallidus Album";
        }
        //OpenFileDialog openFileDialog = new OpenFileDialog();


    private void GameTick_Tick(object sender, EventArgs e)
        {
            //double pointAfter = (strengthPoint + dexterityPoint + constitutionPoint + sharpnessPoint + mindfulnessPoint + agilityPoint)-6;
            player.statCalculation();
            RemainingPointLabel.Text = (maxPoint - (player.Strength+player.Dexterity+player.Constitution+player.Sharpness+player.Mindfulness+player.Agility)+6).ToString();

            LevelLabel.Text = player.Level.ToString("00");
            StrengthBarLabel.Text = player.Strength.ToString("00");
            DexterityBarLabel.Text = player.Dexterity.ToString("00");
            ConstitutionBarLabel.Text = player.Constitution.ToString("00");
            SharpnessBarLabel.Text = player.Sharpness.ToString("00");
            MindfulnessBarLabel.Text = player.Mindfulness.ToString("00");
            AgilityBarLabel.Text = player.Agility.ToString("00");
            MaxHPLabel.Text = player.MaxHP.ToString("00");
            CurrentHPLabel.Text = player.MaxHP.ToString("00");

            ////temporary
            //player.Strength = strengthPoint;
            //player.Dexterity = dexterityPoint;
            //player.Sharpness = sharpnessPoint;
            //player.Constitution = constitutionPoint;
            //player.Mindfulness = mindfulnessPoint;
            //player.Agility = agilityPoint;
            
            MaxEquipLoadLabel.Text = player.MaxEquipLoad.ToString("00");
            LightWeaponEfficiencyLabel.Text = player.LightWeaponEfficiency.ToString("00");
            HeavyWeaponEfficiencyLabel.Text = player.HeavyWeaponEfficiency.ToString("00");
            MagicResistanceLabel.Text = player.MagicResistance.ToString("00");
            PhysicalResistanceLabel.Text = player.PhysicalResistance.ToString("00");

            MaxHPChange.Text = ((Convert.ToDouble(MaxHPLabel.Text))-((1 * 1.2) + (1 * 1.5) + (1 * 1.1) + (1 * 1.2))).ToString("+(00)");
            MaxEquipLoadChange.Text = (Convert.ToDouble(MaxEquipLoadLabel.Text)-((1 * 1.7) + (1 * 1.3))).ToString("+(00)");
            LightWeaponEfficiencyChange.Text = (Convert.ToDouble(LightWeaponEfficiencyLabel.Text)-((1 * 1.1) + (1 * 1.5) + (1 * 1.4))).ToString("+(00)");
            HeavyWeaponEfficiencyChange.Text = (Convert.ToDouble(HeavyWeaponEfficiencyLabel.Text)-((1 * 1.5) + (1 * 1.1) + (1 * 1.4))).ToString("+(00)");
            MagicResistanceChange.Text = (Convert.ToDouble(MagicResistanceLabel.Text)-((1 * 1.1) + (1 * 1.4) + (1 * 1.4) + (1 * 1.1))).ToString("+(00)");
            PhysicalResistanceChange.Text = (Convert.ToDouble(PhysicalResistanceLabel.Text)-((1 * 1.5) + (1 * 1.2) + (1 * 1.1) + (1 * 1.2))).ToString("+(00)");

        }



        //button actions
        private void button1_Click(object sender, EventArgs e)
        {
            player.statCalculation();
            if (RemainingPointLabel.Text != "0")
            {
                string message = "Either too many, not enough point spent or no name entered! Make sure your remaining points are at 0 and you typed in a name!";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Close();
                }
            }
            if(RemainingPointLabel.Text == "0")
            {
                //player.Name = NameEntryBox.Text;
                //player.Strength = strengthPoint;
                //player.Constitution = constitutionPoint;
                //player.Sharpness = sharpnessPoint;
                //player.Mindfulness = mindfulnessPoint;
                //player.Agility = agilityPoint;
                //player.Dexterity = dexterityPoint;
                //player.statCalculation();

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
                string message = "Character saved! You can now press 'Start Game' and load your character there!";
                string caption = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Close();
                }


            }

        }
        private void EasyButton_Click(object sender, EventArgs e)
        {
            maxPoint = 15;
        }

        private void NormalButton_Click(object sender, EventArgs e)
        {
            maxPoint = 10;
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            maxPoint = 7;
        }

        private void VeryHardButton_Click(object sender, EventArgs e)
        {
            maxPoint = 5;
        }

        private void StrengthMinus_Click(object sender, EventArgs e)
        {
            if (player.Strength == 1){}
            else{player.Strength--;}
        }

        private void MindfulnessPlus_Click(object sender, EventArgs e)
        {
            if (maxPoint == 0) { }
            else { player.Mindfulness++; }

        }

        private void SharpnessPlus_Click(object sender, EventArgs e)
        {
            if (maxPoint == 0) { };
            if (player.Sharpness == 10) { }

            else if(player.Sharpness<10) { player.Sharpness++; }

        }

        private void ConstitutionPlus_Click(object sender, EventArgs e)
        {
            if (maxPoint == 0) { };
            if (player.Constitution == 10) { }

            else { player.Constitution++; }

        }

        private void DexterityPlus_Click(object sender, EventArgs e)
        {
            if (maxPoint == 0) { };
            if (player.Dexterity == 10) { }

            else { player.Dexterity++; }

        }

        private void StrengthPlus_Click(object sender, EventArgs e)
        {
            if (maxPoint == 0) { };
            if (player.Strength == 10) { }

            else { player.Strength++; }

        }

        private void AgilityMinus_Click(object sender, EventArgs e)
        {
            if (player.Agility == 1) { }
            else {player.Agility--; }

        }

        private void MindfulnessMinus_Click(object sender, EventArgs e)
        {
            if (player.Mindfulness == 1) { }
            else {player.Mindfulness--; }

        }

        private void SharpnessMinus_Click(object sender, EventArgs e)
        {
            if (player.Sharpness == 1) { }
            else { player.Sharpness--; }

        }

        private void ConstitutionMinus_Click(object sender, EventArgs e)
        {
            if (player.Constitution == 1) { }
            else { player.Constitution--; }

        }

        private void DexterityMinus_Click(object sender, EventArgs e)
        {
            if (player.Dexterity == 1) { }
            else { player.Dexterity--; }

        }

        private void AgilityPlus_Click(object sender, EventArgs e)
        {
            if (maxPoint <1) {  };
            if (player.Agility == 10) { }

            else { player.Agility++; }

        }


        private void button1_Click_1(object sender, EventArgs e) { GameStart(); }
        private void GameStart()
        {
            GameTick.Enabled = false;
            var frm = new gameScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = player.CurrentHP.ToString() + " / " + player.MaxHP.ToString() ;
            string caption = "Success";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }

        }


        private void NormalRadio_CheckedChanged(object sender, EventArgs e)
        {
            maxPoint = 10;
        }

        private void HardRadio_CheckedChanged(object sender, EventArgs e)
        {
            maxPoint = 7;
        }

        private void VeryHardRadio_CheckedChanged(object sender, EventArgs e)
        {
            maxPoint = 5;
        }

        private void EasyRadio_CheckedChanged(object sender, EventArgs e)
        {
            maxPoint = 15;
        }
    }
}

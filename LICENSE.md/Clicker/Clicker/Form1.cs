using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Clicker : Form
    {

        #region Variables

        float money;
        float limitedmoney;
      
        float minmoney = 0f;

        bool normalclick = true;

        float perclick;
        float limitedperclick;
        
        float perseconds;
        float limitedperseconds;


        float totalperclick;
        float totalpersecond;

        bool clicker;
        bool boughtclicker;

        bool miner;
        bool boughtminer;

        bool autoclicker;
        bool boughtautoclicker;

        bool autominer;
        bool boughtautominer;

        float clickeramount = 0;
        float mineramount = 0;
        float autoclickeramount = 0;
        float automineramount = 0;

        float clickerprice;
        float minerprice;
        float autoclickerprice;
        float autominerprice;

        string clickeramounttext;
        string mineramounttext;
        string autoclickeramounttext;
        string automineramounttext;

        #endregion

        public Clicker()
        {
            InitializeComponent();

            clickerprice = 0;
            minerprice = 1000;
            autoclickerprice = 10000;
            autominerprice = 100000;


            this.Size = new System.Drawing.Size(617, 300);

            updateUI();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (normalclick)
            {
                perclick = 1f;
            }

            Timer.Enabled = true;
            moneyTimer.Enabled = true;

            money += perclick;

            updateUI();
        }

        private void coinImage_DoubleClick(object sender, EventArgs e)
        {
            
            if (normalclick)
            {
              perclick = 1f;
            }
            
            moneyTimer.Enabled = true;

            money += perclick;

            updateUI();
            
        }

        private void shopButton_1_Click(object sender, EventArgs e)
        {
            try
            {
                money -= clickerprice;
                clickerprice += 25;
                boughtclicker = true;
                clickeramount++;
                perclick += 1;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            #region shopButton_1
            if (money >= clickerprice)
            {
                clicker = true;
                if (clicker)
                {
                    shopButton_1.Visible = true;
                }
            }
            else if (money < clickerprice)
            {
                shopButton_1.Visible = false;
            }

            

            if (boughtclicker)
            {
                normalclick = false;
                shopButton_1CheckBox.Visible = true;
                shopButton_1CheckBox.Checked = true;
            }

            #endregion

            #region shopButton_2

            if(money >= minerprice)
            {
                miner = true;
                if (miner)
                {
                    shopButton_2.Visible = true;
                }
            }

            else if (money < minerprice)
            {
                shopButton_2.Visible = false;
            }

            if (boughtminer)
            {
                normalclick = false;
                shopButton_2CheckBox.Visible = true;
                shopButton_2CheckBox.Checked = true;
            }
            #endregion

            #region shopButton_3

            if (money >= autoclickerprice)
            {
                autoclicker = true;
                if (autoclicker)
                {
                    shopButton_3.Visible = true;
                }
            }

            else if (money < autoclickerprice)
            {
                shopButton_3.Visible = false;
            }

            if (boughtautoclicker)
            {
                normalclick = false;
                shopButton_3CheckBox.Visible = true;
                shopButton_3CheckBox.Checked = true;
            }
            #endregion

            #region shopButton_4

            if (money >= autominerprice)
            {
                autominer = true;
                if (autominer)
                {
                    shopButton_4.Visible = true;
                }
            }

            else if (money < autominerprice)
            {
                shopButton_4.Visible = false;
            }

            if (boughtautominer)
            {
                normalclick = false;
                shopButton_4CheckBox.Visible = true;
                shopButton_4CheckBox.Checked = true;
            }

            #endregion

            updateUI();


            if (money < minmoney)
                money = minmoney;

            
        }

        private void shopButton_2_Click(object sender, EventArgs e)
        {
            try
            {
                money -= minerprice;
                minerprice += 125;
                boughtminer = true;
                mineramount++;
                perclick += 5;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void shopButton_3_Click(object sender, EventArgs e)
        {
            try
            {
                money -= autoclickerprice;
                autoclickerprice += 2750;
                boughtautoclicker = true;
                perseconds += 2f;
                autoclickeramount++;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }


        private void moneyTimer_Tick(object sender, EventArgs e)
        {
            money += perseconds;
        }


        void updateUI()
        {
            moneySystemBox.Text = money.ToString();

            clickeramounttext = clickeramount.ToString();
            mineramounttext = mineramount.ToString();
            autoclickeramounttext = autoclickeramount.ToString();
            automineramounttext = automineramount.ToString();

            persecondamountLabel.Text = perseconds.ToString();


            limitedmoney = money;

            if (limitedmoney >= 999)
            {
                limitedmoney = 999;
            }

            limitedperclick = perclick;

            if (limitedperclick >= 99)
            {
                limitedperclick = 99;
            }


            limitedperseconds = perseconds;

            if (limitedperseconds >= 99)
            {
                limitedperseconds = 99;
            }



            moneySystemBox.Text = "Total clicks: " + limitedmoney.ToString() + " | Per click: " + limitedperclick.ToString() + " | Per second: " + limitedperseconds.ToString(); ;
            moneyamountLabel.Text = money.ToString();
            

            perclickamountLabel.Text = perclick.ToString();

            totalperclick = perclick;
            perclick = totalperclick;

            totalpersecond = perseconds;
            perseconds = totalpersecond;

        }

        private void shopButton_4_Click(object sender, EventArgs e)
        {
           try
            {
             money -= autominerprice;
             autominerprice += 17500;
             boughtautominer = true;
             perseconds += 5f;
             automineramount++;
            }
           catch
            {
             MessageBox.Show("Error");
            }
        }

        private void shopButton_1CheckBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amount of Clickers: " + clickeramounttext + '\n' + "Cost: " + clickerprice.ToString(), "Information"); ;
        }

        private void shopButton_2CheckBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amount of Miners: " + mineramounttext + '\n' + "Cost: " + minerprice.ToString(), "Information");
        }

        private void shopButton_3CheckBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amount of Autoclickers: " + autoclickeramounttext + '\n' + autoclickerprice.ToString(), "Information");
        }

        private void shopButton_4CheckBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amount of Autominers: " +   automineramounttext + '\n' + autominerprice.ToString(), "Information");
        }

        private void Clicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Properties.Settings.Default.Money = money;
            Properties.Settings.Default.PerClick = perclick;
            Properties.Settings.Default.PerSeconds = perseconds;
            Properties.Settings.Default.clicker = clicker;
            Properties.Settings.Default.boughtclicker = boughtclicker;
            Properties.Settings.Default.miner = miner;
            Properties.Settings.Default.boughtminer = boughtminer;
            Properties.Settings.Default.autoclicker = autoclicker;
            Properties.Settings.Default.boughtautoclicker = boughtautoclicker;
            Properties.Settings.Default.autominer = autominer;
            Properties.Settings.Default.boughtautominer = boughtautominer;
            Properties.Settings.Default.clickeramount = clickeramount;
            Properties.Settings.Default.mineramount = mineramount;
            Properties.Settings.Default.autoclickeramount = autoclickeramount;
            Properties.Settings.Default.automineramount = automineramount;
            Properties.Settings.Default.totalperclick = totalperclick;
            Properties.Settings.Default.totalpersecond = totalpersecond;
            Properties.Settings.Default.clickerprice = clickerprice;

            Properties.Settings.Default.Save();
        }

        private void Clicker_Load(object sender, EventArgs e)
        {
            clickerprice = Properties.Settings.Default.clickerprice;
            totalpersecond = Properties.Settings.Default.totalpersecond;
            totalperclick = Properties.Settings.Default.totalperclick;
            money = Properties.Settings.Default.Money;
            perclick = Properties.Settings.Default.PerClick;
            perseconds = Properties.Settings.Default.PerSeconds;
            clicker = Properties.Settings.Default.clicker;
            boughtclicker = Properties.Settings.Default.boughtclicker;
            miner = Properties.Settings.Default.miner;
            boughtminer = Properties.Settings.Default.boughtminer;
            autoclicker = Properties.Settings.Default.autoclicker;
            boughtautoclicker = Properties.Settings.Default.boughtautoclicker;
            autominer = Properties.Settings.Default.autominer;
            boughtautominer = Properties.Settings.Default.boughtautominer;
            clickeramount = Properties.Settings.Default.clickeramount;
            mineramount = Properties.Settings.Default.mineramount;
            autoclickeramount = Properties.Settings.Default.autoclickeramount;
            automineramount = Properties.Settings.Default.automineramount;
            Timer.Enabled = true;
            updateUI();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.Money = money;
            Properties.Settings.Default.PerClick = perclick;
            Properties.Settings.Default.PerSeconds = perseconds;
            Properties.Settings.Default.clicker = clicker;
            Properties.Settings.Default.boughtclicker = boughtclicker;
            Properties.Settings.Default.miner = miner;
            Properties.Settings.Default.boughtminer = boughtminer;
            Properties.Settings.Default.autoclicker = autoclicker;
            Properties.Settings.Default.boughtautoclicker = boughtautoclicker;
            Properties.Settings.Default.autominer = autominer;
            Properties.Settings.Default.boughtautominer = boughtautominer;
            Properties.Settings.Default.clickeramount = clickeramount;
            Properties.Settings.Default.mineramount = mineramount;
            Properties.Settings.Default.autoclickeramount = autoclickeramount;
            Properties.Settings.Default.automineramount = automineramount;
            Properties.Settings.Default.totalperclick = totalperclick;
            Properties.Settings.Default.totalpersecond = totalpersecond;
            Properties.Settings.Default.clickerprice = clickerprice;

            Properties.Settings.Default.Save();

            MessageBox.Show("Saved!");
        }

        private void moreinfoButton_Click(object sender, EventArgs e)
        {
            if (moreinfoButton.Text == "More info")
            {
                this.Size = new System.Drawing.Size(617, 430);
                moreinfoButton.Text = "Close info";
            }

            else if (moreinfoButton.Text == "Close info")
            {
                this.Size = new System.Drawing.Size(617, 300);
                moreinfoButton.Text = "More info";
            }

        }

        private void saveandcloseButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Money = money;
            Properties.Settings.Default.PerClick = perclick;
            Properties.Settings.Default.PerSeconds = perseconds;
            Properties.Settings.Default.clicker = clicker;
            Properties.Settings.Default.boughtclicker = boughtclicker;
            Properties.Settings.Default.miner = miner;
            Properties.Settings.Default.boughtminer = boughtminer;
            Properties.Settings.Default.autoclicker = autoclicker;
            Properties.Settings.Default.boughtautoclicker = boughtautoclicker;
            Properties.Settings.Default.autominer = autominer;
            Properties.Settings.Default.boughtautominer = boughtautominer;
            Properties.Settings.Default.clickeramount = clickeramount;
            Properties.Settings.Default.mineramount = mineramount;
            Properties.Settings.Default.autoclickeramount = autoclickeramount;
            Properties.Settings.Default.automineramount = automineramount;
            Properties.Settings.Default.totalperclick = totalperclick;
            Properties.Settings.Default.totalpersecond = totalpersecond;
            Properties.Settings.Default.clickerprice = clickerprice;

            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}

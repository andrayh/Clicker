namespace Clicker
{
    partial class Clicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.coinImage = new System.Windows.Forms.PictureBox();
            this.moneySystemBox = new System.Windows.Forms.GroupBox();
            this.shopButton_4 = new System.Windows.Forms.Button();
            this.shopButton_3 = new System.Windows.Forms.Button();
            this.shopButton_2 = new System.Windows.Forms.Button();
            this.shopButton_1 = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.shopButton_1CheckBox = new System.Windows.Forms.CheckBox();
            this.ownedItemsBox = new System.Windows.Forms.GroupBox();
            this.shopButton_4CheckBox = new System.Windows.Forms.CheckBox();
            this.shopButton_3CheckBox = new System.Windows.Forms.CheckBox();
            this.shopButton_2CheckBox = new System.Windows.Forms.CheckBox();
            this.persecondLabel = new System.Windows.Forms.Label();
            this.persecondamountLabel = new System.Windows.Forms.Label();
            this.moneyTimer = new System.Windows.Forms.Timer(this.components);
            this.perclickLabel = new System.Windows.Forms.Label();
            this.perclickamountLabel = new System.Windows.Forms.Label();
            this.newgameButton = new System.Windows.Forms.Button();
            this.saveandcloseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.iconBox = new System.Windows.Forms.GroupBox();
            this.moreinfoButton = new System.Windows.Forms.Button();
            this.informationBox = new System.Windows.Forms.GroupBox();
            this.moneyamountLabel = new System.Windows.Forms.Label();
            this.clicksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coinImage)).BeginInit();
            this.moneySystemBox.SuspendLayout();
            this.ownedItemsBox.SuspendLayout();
            this.iconBox.SuspendLayout();
            this.informationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // coinImage
            // 
            this.coinImage.BackColor = System.Drawing.SystemColors.Control;
            this.coinImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coinImage.Image = global::Clicker.Properties.Resources.ClickerImage;
            this.coinImage.Location = new System.Drawing.Point(6, 24);
            this.coinImage.Name = "coinImage";
            this.coinImage.Size = new System.Drawing.Size(112, 118);
            this.coinImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coinImage.TabIndex = 1;
            this.coinImage.TabStop = false;
            this.coinImage.Click += new System.EventHandler(this.pictureBox1_Click);
            this.coinImage.DoubleClick += new System.EventHandler(this.coinImage_DoubleClick);
            // 
            // moneySystemBox
            // 
            this.moneySystemBox.Controls.Add(this.shopButton_4);
            this.moneySystemBox.Controls.Add(this.shopButton_3);
            this.moneySystemBox.Controls.Add(this.shopButton_2);
            this.moneySystemBox.Controls.Add(this.shopButton_1);
            this.moneySystemBox.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneySystemBox.Location = new System.Drawing.Point(148, 12);
            this.moneySystemBox.Name = "moneySystemBox";
            this.moneySystemBox.Size = new System.Drawing.Size(441, 153);
            this.moneySystemBox.TabIndex = 2;
            this.moneySystemBox.TabStop = false;
            this.moneySystemBox.Text = "Empty";
            // 
            // shopButton_4
            // 
            this.shopButton_4.Location = new System.Drawing.Point(343, 49);
            this.shopButton_4.Name = "shopButton_4";
            this.shopButton_4.Size = new System.Drawing.Size(82, 35);
            this.shopButton_4.TabIndex = 3;
            this.shopButton_4.Text = "AutoMiner";
            this.shopButton_4.UseVisualStyleBackColor = true;
            this.shopButton_4.Visible = false;
            this.shopButton_4.Click += new System.EventHandler(this.shopButton_4_Click);
            // 
            // shopButton_3
            // 
            this.shopButton_3.Location = new System.Drawing.Point(232, 49);
            this.shopButton_3.Name = "shopButton_3";
            this.shopButton_3.Size = new System.Drawing.Size(82, 35);
            this.shopButton_3.TabIndex = 2;
            this.shopButton_3.Text = "AutoClicker";
            this.shopButton_3.UseVisualStyleBackColor = true;
            this.shopButton_3.Visible = false;
            this.shopButton_3.Click += new System.EventHandler(this.shopButton_3_Click);
            // 
            // shopButton_2
            // 
            this.shopButton_2.Location = new System.Drawing.Point(125, 49);
            this.shopButton_2.Name = "shopButton_2";
            this.shopButton_2.Size = new System.Drawing.Size(82, 35);
            this.shopButton_2.TabIndex = 1;
            this.shopButton_2.Text = "Miner";
            this.shopButton_2.UseVisualStyleBackColor = true;
            this.shopButton_2.Visible = false;
            this.shopButton_2.Click += new System.EventHandler(this.shopButton_2_Click);
            // 
            // shopButton_1
            // 
            this.shopButton_1.Location = new System.Drawing.Point(21, 49);
            this.shopButton_1.Name = "shopButton_1";
            this.shopButton_1.Size = new System.Drawing.Size(82, 35);
            this.shopButton_1.TabIndex = 0;
            this.shopButton_1.Text = "Clicker";
            this.shopButton_1.UseVisualStyleBackColor = true;
            this.shopButton_1.Visible = false;
            this.shopButton_1.Click += new System.EventHandler(this.shopButton_1_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // shopButton_1CheckBox
            // 
            this.shopButton_1CheckBox.AutoCheck = false;
            this.shopButton_1CheckBox.AutoSize = true;
            this.shopButton_1CheckBox.Location = new System.Drawing.Point(25, 19);
            this.shopButton_1CheckBox.Name = "shopButton_1CheckBox";
            this.shopButton_1CheckBox.Size = new System.Drawing.Size(60, 17);
            this.shopButton_1CheckBox.TabIndex = 13;
            this.shopButton_1CheckBox.Text = "Clicker";
            this.shopButton_1CheckBox.UseVisualStyleBackColor = true;
            this.shopButton_1CheckBox.Visible = false;
            this.shopButton_1CheckBox.Click += new System.EventHandler(this.shopButton_1CheckBox_Click);
            // 
            // ownedItemsBox
            // 
            this.ownedItemsBox.Controls.Add(this.shopButton_4CheckBox);
            this.ownedItemsBox.Controls.Add(this.shopButton_3CheckBox);
            this.ownedItemsBox.Controls.Add(this.shopButton_2CheckBox);
            this.ownedItemsBox.Controls.Add(this.shopButton_1CheckBox);
            this.ownedItemsBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownedItemsBox.Location = new System.Drawing.Point(12, 171);
            this.ownedItemsBox.Name = "ownedItemsBox";
            this.ownedItemsBox.Size = new System.Drawing.Size(577, 44);
            this.ownedItemsBox.TabIndex = 3;
            this.ownedItemsBox.TabStop = false;
            this.ownedItemsBox.Text = "Owned Items - Press on Item for information";
            // 
            // shopButton_4CheckBox
            // 
            this.shopButton_4CheckBox.AutoCheck = false;
            this.shopButton_4CheckBox.AutoSize = true;
            this.shopButton_4CheckBox.Location = new System.Drawing.Point(471, 19);
            this.shopButton_4CheckBox.Name = "shopButton_4CheckBox";
            this.shopButton_4CheckBox.Size = new System.Drawing.Size(79, 17);
            this.shopButton_4CheckBox.TabIndex = 16;
            this.shopButton_4CheckBox.Text = "AutoMiner";
            this.shopButton_4CheckBox.UseVisualStyleBackColor = true;
            this.shopButton_4CheckBox.Visible = false;
            this.shopButton_4CheckBox.Click += new System.EventHandler(this.shopButton_4CheckBox_Click);
            // 
            // shopButton_3CheckBox
            // 
            this.shopButton_3CheckBox.AutoCheck = false;
            this.shopButton_3CheckBox.AutoSize = true;
            this.shopButton_3CheckBox.Location = new System.Drawing.Point(318, 19);
            this.shopButton_3CheckBox.Name = "shopButton_3CheckBox";
            this.shopButton_3CheckBox.Size = new System.Drawing.Size(84, 17);
            this.shopButton_3CheckBox.TabIndex = 15;
            this.shopButton_3CheckBox.Text = "AutoClicker";
            this.shopButton_3CheckBox.UseVisualStyleBackColor = true;
            this.shopButton_3CheckBox.Visible = false;
            this.shopButton_3CheckBox.Click += new System.EventHandler(this.shopButton_3CheckBox_Click);
            // 
            // shopButton_2CheckBox
            // 
            this.shopButton_2CheckBox.AutoCheck = false;
            this.shopButton_2CheckBox.AutoSize = true;
            this.shopButton_2CheckBox.Location = new System.Drawing.Point(173, 19);
            this.shopButton_2CheckBox.Name = "shopButton_2CheckBox";
            this.shopButton_2CheckBox.Size = new System.Drawing.Size(55, 17);
            this.shopButton_2CheckBox.TabIndex = 14;
            this.shopButton_2CheckBox.Text = "Miner";
            this.shopButton_2CheckBox.UseVisualStyleBackColor = true;
            this.shopButton_2CheckBox.Visible = false;
            this.shopButton_2CheckBox.Click += new System.EventHandler(this.shopButton_2CheckBox_Click);
            // 
            // persecondLabel
            // 
            this.persecondLabel.AutoSize = true;
            this.persecondLabel.Location = new System.Drawing.Point(6, 60);
            this.persecondLabel.Name = "persecondLabel";
            this.persecondLabel.Size = new System.Drawing.Size(77, 17);
            this.persecondLabel.TabIndex = 12;
            this.persecondLabel.Text = "Per Second:";
            // 
            // persecondamountLabel
            // 
            this.persecondamountLabel.AutoSize = true;
            this.persecondamountLabel.Location = new System.Drawing.Point(85, 60);
            this.persecondamountLabel.Name = "persecondamountLabel";
            this.persecondamountLabel.Size = new System.Drawing.Size(15, 17);
            this.persecondamountLabel.TabIndex = 13;
            this.persecondamountLabel.Text = "0";
            // 
            // moneyTimer
            // 
            this.moneyTimer.Interval = 1000;
            this.moneyTimer.Tick += new System.EventHandler(this.moneyTimer_Tick);
            // 
            // perclickLabel
            // 
            this.perclickLabel.AutoSize = true;
            this.perclickLabel.Location = new System.Drawing.Point(6, 43);
            this.perclickLabel.Name = "perclickLabel";
            this.perclickLabel.Size = new System.Drawing.Size(60, 17);
            this.perclickLabel.TabIndex = 14;
            this.perclickLabel.Text = "Per Click:";
            // 
            // perclickamountLabel
            // 
            this.perclickamountLabel.AutoSize = true;
            this.perclickamountLabel.Location = new System.Drawing.Point(85, 43);
            this.perclickamountLabel.Name = "perclickamountLabel";
            this.perclickamountLabel.Size = new System.Drawing.Size(15, 17);
            this.perclickamountLabel.TabIndex = 15;
            this.perclickamountLabel.Text = "1";
            // 
            // newgameButton
            // 
            this.newgameButton.Location = new System.Drawing.Point(309, 393);
            this.newgameButton.Name = "newgameButton";
            this.newgameButton.Size = new System.Drawing.Size(90, 30);
            this.newgameButton.TabIndex = 16;
            this.newgameButton.Text = "New game";
            this.newgameButton.UseVisualStyleBackColor = true;
            // 
            // saveandcloseButton
            // 
            this.saveandcloseButton.Location = new System.Drawing.Point(501, 393);
            this.saveandcloseButton.Name = "saveandcloseButton";
            this.saveandcloseButton.Size = new System.Drawing.Size(90, 30);
            this.saveandcloseButton.TabIndex = 17;
            this.saveandcloseButton.Text = "Save && Close";
            this.saveandcloseButton.UseVisualStyleBackColor = true;
            this.saveandcloseButton.Click += new System.EventHandler(this.saveandcloseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(405, 393);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 30);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // iconBox
            // 
            this.iconBox.Controls.Add(this.coinImage);
            this.iconBox.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBox.Location = new System.Drawing.Point(10, 12);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(123, 153);
            this.iconBox.TabIndex = 19;
            this.iconBox.TabStop = false;
            // 
            // moreinfoButton
            // 
            this.moreinfoButton.Location = new System.Drawing.Point(501, 221);
            this.moreinfoButton.Name = "moreinfoButton";
            this.moreinfoButton.Size = new System.Drawing.Size(90, 30);
            this.moreinfoButton.TabIndex = 20;
            this.moreinfoButton.Text = "More info";
            this.moreinfoButton.UseVisualStyleBackColor = true;
            this.moreinfoButton.Click += new System.EventHandler(this.moreinfoButton_Click);
            // 
            // informationBox
            // 
            this.informationBox.Controls.Add(this.moneyamountLabel);
            this.informationBox.Controls.Add(this.clicksLabel);
            this.informationBox.Controls.Add(this.perclickLabel);
            this.informationBox.Controls.Add(this.persecondLabel);
            this.informationBox.Controls.Add(this.persecondamountLabel);
            this.informationBox.Controls.Add(this.perclickamountLabel);
            this.informationBox.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationBox.Location = new System.Drawing.Point(8, 297);
            this.informationBox.Name = "informationBox";
            this.informationBox.Size = new System.Drawing.Size(581, 90);
            this.informationBox.TabIndex = 22;
            this.informationBox.TabStop = false;
            this.informationBox.Text = "Information";
            // 
            // moneyamountLabel
            // 
            this.moneyamountLabel.AutoSize = true;
            this.moneyamountLabel.Location = new System.Drawing.Point(85, 26);
            this.moneyamountLabel.Name = "moneyamountLabel";
            this.moneyamountLabel.Size = new System.Drawing.Size(15, 17);
            this.moneyamountLabel.TabIndex = 17;
            this.moneyamountLabel.Text = "0";
            // 
            // clicksLabel
            // 
            this.clicksLabel.AutoSize = true;
            this.clicksLabel.Location = new System.Drawing.Point(6, 26);
            this.clicksLabel.Name = "clicksLabel";
            this.clicksLabel.Size = new System.Drawing.Size(43, 17);
            this.clicksLabel.TabIndex = 16;
            this.clicksLabel.Text = "Clicks:";
            // 
            // Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 435);
            this.Controls.Add(this.informationBox);
            this.Controls.Add(this.moreinfoButton);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.saveandcloseButton);
            this.Controls.Add(this.newgameButton);
            this.Controls.Add(this.ownedItemsBox);
            this.Controls.Add(this.moneySystemBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clicker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clicker_FormClosing);
            this.Load += new System.EventHandler(this.Clicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coinImage)).EndInit();
            this.moneySystemBox.ResumeLayout(false);
            this.ownedItemsBox.ResumeLayout(false);
            this.ownedItemsBox.PerformLayout();
            this.iconBox.ResumeLayout(false);
            this.informationBox.ResumeLayout(false);
            this.informationBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox coinImage;
        private System.Windows.Forms.GroupBox moneySystemBox;
        private System.Windows.Forms.Button shopButton_4;
        private System.Windows.Forms.Button shopButton_3;
        private System.Windows.Forms.Button shopButton_2;
        private System.Windows.Forms.Button shopButton_1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox shopButton_1CheckBox;
        private System.Windows.Forms.GroupBox ownedItemsBox;
        private System.Windows.Forms.CheckBox shopButton_4CheckBox;
        private System.Windows.Forms.CheckBox shopButton_3CheckBox;
        private System.Windows.Forms.CheckBox shopButton_2CheckBox;
        private System.Windows.Forms.Label persecondLabel;
        private System.Windows.Forms.Label persecondamountLabel;
        private System.Windows.Forms.Timer moneyTimer;
        private System.Windows.Forms.Label perclickLabel;
        private System.Windows.Forms.Label perclickamountLabel;
        private System.Windows.Forms.Button newgameButton;
        private System.Windows.Forms.Button saveandcloseButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox iconBox;
        private System.Windows.Forms.Button moreinfoButton;
        private System.Windows.Forms.GroupBox informationBox;
        private System.Windows.Forms.Label moneyamountLabel;
        private System.Windows.Forms.Label clicksLabel;
    }
}


namespace StarWarsForPoor
{
    partial class ArmouryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArmouryForm));
            this.MyShip = new System.Windows.Forms.Label();
            this.ShipPreview = new System.Windows.Forms.PictureBox();
            this.HullSelect = new System.Windows.Forms.Label();
            this.WeaponSelect = new System.Windows.Forms.Label();
            this.Hull = new System.Windows.Forms.Button();
            this.Hull1 = new System.Windows.Forms.Button();
            this.Hull2 = new System.Windows.Forms.Button();
            this.Weapon1 = new System.Windows.Forms.Button();
            this.Weapon2 = new System.Windows.Forms.Button();
            this.Weapon3 = new System.Windows.Forms.Button();
            this.Weapon4 = new System.Windows.Forms.Button();
            this.Weapon5 = new System.Windows.Forms.Button();
            this.BulletShow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StartGame = new System.Windows.Forms.Button();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.StartGameLabel = new System.Windows.Forms.Label();
            this.BuyWeapon2 = new System.Windows.Forms.Button();
            this.BuyWeapon3 = new System.Windows.Forms.Button();
            this.BuyWeapon4 = new System.Windows.Forms.Button();
            this.BuyWeapon5 = new System.Windows.Forms.Button();
            this.BuyHull2 = new System.Windows.Forms.Button();
            this.BuyHull3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShipPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // MyShip
            // 
            this.MyShip.AutoSize = true;
            this.MyShip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MyShip.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyShip.Location = new System.Drawing.Point(9, 7);
            this.MyShip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MyShip.Name = "MyShip";
            this.MyShip.Size = new System.Drawing.Size(254, 40);
            this.MyShip.TabIndex = 0;
            this.MyShip.Text = "YOUR SHIP:";
            // 
            // ShipPreview
            // 
            this.ShipPreview.Location = new System.Drawing.Point(16, 52);
            this.ShipPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShipPreview.Name = "ShipPreview";
            this.ShipPreview.Size = new System.Drawing.Size(225, 122);
            this.ShipPreview.TabIndex = 1;
            this.ShipPreview.TabStop = false;
            // 
            // HullSelect
            // 
            this.HullSelect.AutoSize = true;
            this.HullSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HullSelect.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HullSelect.Location = new System.Drawing.Point(75, 176);
            this.HullSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HullSelect.Name = "HullSelect";
            this.HullSelect.Size = new System.Drawing.Size(115, 19);
            this.HullSelect.TabIndex = 2;
            this.HullSelect.Text = "Select Hull:";
            // 
            // WeaponSelect
            // 
            this.WeaponSelect.AutoSize = true;
            this.WeaponSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WeaponSelect.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponSelect.Location = new System.Drawing.Point(511, 27);
            this.WeaponSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeaponSelect.Name = "WeaponSelect";
            this.WeaponSelect.Size = new System.Drawing.Size(151, 19);
            this.WeaponSelect.TabIndex = 3;
            this.WeaponSelect.Text = "Select Weapon:";
            // 
            // Hull
            // 
            this.Hull.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hull.BackgroundImage")));
            this.Hull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Hull.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hull.Image = ((System.Drawing.Image)(resources.GetObject("Hull.Image")));
            this.Hull.Location = new System.Drawing.Point(89, 197);
            this.Hull.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hull.Name = "Hull";
            this.Hull.Size = new System.Drawing.Size(125, 61);
            this.Hull.TabIndex = 4;
            this.Hull.UseVisualStyleBackColor = true;
            this.Hull.Click += new System.EventHandler(this.Hull_Click);
            // 
            // Hull1
            // 
            this.Hull1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hull1.BackgroundImage")));
            this.Hull1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Hull1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hull1.Enabled = false;
            this.Hull1.Image = ((System.Drawing.Image)(resources.GetObject("Hull1.Image")));
            this.Hull1.Location = new System.Drawing.Point(89, 262);
            this.Hull1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hull1.Name = "Hull1";
            this.Hull1.Size = new System.Drawing.Size(125, 61);
            this.Hull1.TabIndex = 4;
            this.Hull1.UseVisualStyleBackColor = true;
            this.Hull1.Click += new System.EventHandler(this.Hull1_Click);
            // 
            // Hull2
            // 
            this.Hull2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hull2.BackgroundImage")));
            this.Hull2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Hull2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hull2.Enabled = false;
            this.Hull2.Image = ((System.Drawing.Image)(resources.GetObject("Hull2.Image")));
            this.Hull2.Location = new System.Drawing.Point(89, 329);
            this.Hull2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hull2.Name = "Hull2";
            this.Hull2.Size = new System.Drawing.Size(125, 61);
            this.Hull2.TabIndex = 4;
            this.Hull2.UseVisualStyleBackColor = true;
            this.Hull2.Click += new System.EventHandler(this.Hull2_Click);
            // 
            // Weapon1
            // 
            this.Weapon1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Weapon1.BackgroundImage")));
            this.Weapon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Weapon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weapon1.Image = ((System.Drawing.Image)(resources.GetObject("Weapon1.Image")));
            this.Weapon1.Location = new System.Drawing.Point(502, 65);
            this.Weapon1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Weapon1.Name = "Weapon1";
            this.Weapon1.Size = new System.Drawing.Size(150, 61);
            this.Weapon1.TabIndex = 4;
            this.Weapon1.UseVisualStyleBackColor = true;
            this.Weapon1.Click += new System.EventHandler(this.Weapon1_Click);
            // 
            // Weapon2
            // 
            this.Weapon2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Weapon2.BackgroundImage")));
            this.Weapon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Weapon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weapon2.Enabled = false;
            this.Weapon2.Image = ((System.Drawing.Image)(resources.GetObject("Weapon2.Image")));
            this.Weapon2.Location = new System.Drawing.Point(502, 131);
            this.Weapon2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Weapon2.Name = "Weapon2";
            this.Weapon2.Size = new System.Drawing.Size(150, 61);
            this.Weapon2.TabIndex = 4;
            this.Weapon2.UseVisualStyleBackColor = true;
            this.Weapon2.Click += new System.EventHandler(this.Weapon2_Click);
            // 
            // Weapon3
            // 
            this.Weapon3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Weapon3.BackgroundImage")));
            this.Weapon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Weapon3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weapon3.Enabled = false;
            this.Weapon3.Image = ((System.Drawing.Image)(resources.GetObject("Weapon3.Image")));
            this.Weapon3.Location = new System.Drawing.Point(502, 197);
            this.Weapon3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Weapon3.Name = "Weapon3";
            this.Weapon3.Size = new System.Drawing.Size(150, 61);
            this.Weapon3.TabIndex = 4;
            this.Weapon3.UseVisualStyleBackColor = true;
            this.Weapon3.Click += new System.EventHandler(this.Weapon3_Click);
            // 
            // Weapon4
            // 
            this.Weapon4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Weapon4.BackgroundImage")));
            this.Weapon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Weapon4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weapon4.Enabled = false;
            this.Weapon4.Image = ((System.Drawing.Image)(resources.GetObject("Weapon4.Image")));
            this.Weapon4.Location = new System.Drawing.Point(502, 262);
            this.Weapon4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Weapon4.Name = "Weapon4";
            this.Weapon4.Size = new System.Drawing.Size(150, 61);
            this.Weapon4.TabIndex = 4;
            this.Weapon4.UseVisualStyleBackColor = true;
            this.Weapon4.Click += new System.EventHandler(this.Weapon4_Click);
            // 
            // Weapon5
            // 
            this.Weapon5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Weapon5.BackgroundImage")));
            this.Weapon5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Weapon5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weapon5.Enabled = false;
            this.Weapon5.Image = ((System.Drawing.Image)(resources.GetObject("Weapon5.Image")));
            this.Weapon5.Location = new System.Drawing.Point(502, 328);
            this.Weapon5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Weapon5.Name = "Weapon5";
            this.Weapon5.Size = new System.Drawing.Size(150, 61);
            this.Weapon5.TabIndex = 4;
            this.Weapon5.UseVisualStyleBackColor = true;
            this.Weapon5.Click += new System.EventHandler(this.Weapon5_Click);
            // 
            // BulletShow
            // 
            this.BulletShow.AutoSize = true;
            this.BulletShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BulletShow.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulletShow.Location = new System.Drawing.Point(356, 27);
            this.BulletShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BulletShow.Name = "BulletShow";
            this.BulletShow.Size = new System.Drawing.Size(147, 19);
            this.BulletShow.TabIndex = 3;
            this.BulletShow.Text = "Built-in bullet:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(418, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(418, 141);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 41);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(418, 207);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 41);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(418, 272);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 41);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(418, 339);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 41);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blaster gun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zeus gun";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Winter gun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Volcano\r\ncannon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 339);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ice-cream\r\ngun";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Alien ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 36);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ocean\r\ndestroyer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 349);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Armaggedon";
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.SystemColors.HighlightText;
            this.StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGame.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.Location = new System.Drawing.Point(658, 399);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(150, 64);
            this.StartGame.TabIndex = 6;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoneyLabel.Location = new System.Drawing.Point(678, 23);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(86, 22);
            this.MoneyLabel.TabIndex = 8;
            this.MoneyLabel.Text = "Money:";
            // 
            // StartGameLabel
            // 
            this.StartGameLabel.AutoSize = true;
            this.StartGameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartGameLabel.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartGameLabel.Location = new System.Drawing.Point(280, 422);
            this.StartGameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartGameLabel.Name = "StartGameLabel";
            this.StartGameLabel.Size = new System.Drawing.Size(364, 19);
            this.StartGameLabel.TabIndex = 9;
            this.StartGameLabel.Text = "Press this button to start -->";
            // 
            // BuyWeapon2
            // 
            this.BuyWeapon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyWeapon2.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyWeapon2.Location = new System.Drawing.Point(664, 131);
            this.BuyWeapon2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuyWeapon2.Name = "BuyWeapon2";
            this.BuyWeapon2.Size = new System.Drawing.Size(144, 53);
            this.BuyWeapon2.TabIndex = 10;
            this.BuyWeapon2.Text = "Purschase Weapon 25";
            this.BuyWeapon2.UseVisualStyleBackColor = true;
            this.BuyWeapon2.Click += new System.EventHandler(this.PurschaseWeapon1_Click);
            // 
            // BuyWeapon3
            // 
            this.BuyWeapon3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyWeapon3.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyWeapon3.Location = new System.Drawing.Point(664, 197);
            this.BuyWeapon3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuyWeapon3.Name = "BuyWeapon3";
            this.BuyWeapon3.Size = new System.Drawing.Size(144, 51);
            this.BuyWeapon3.TabIndex = 10;
            this.BuyWeapon3.Text = "Purschase Weapon 50";
            this.BuyWeapon3.UseVisualStyleBackColor = true;
            this.BuyWeapon3.Click += new System.EventHandler(this.PurschaseWeapon2_Click);
            // 
            // BuyWeapon4
            // 
            this.BuyWeapon4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyWeapon4.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyWeapon4.Location = new System.Drawing.Point(664, 262);
            this.BuyWeapon4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuyWeapon4.Name = "BuyWeapon4";
            this.BuyWeapon4.Size = new System.Drawing.Size(144, 53);
            this.BuyWeapon4.TabIndex = 10;
            this.BuyWeapon4.Text = "Purschase Weapon 100";
            this.BuyWeapon4.UseVisualStyleBackColor = true;
            this.BuyWeapon4.Click += new System.EventHandler(this.PurschaseWeapon3_Click);
            // 
            // BuyWeapon5
            // 
            this.BuyWeapon5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyWeapon5.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyWeapon5.Location = new System.Drawing.Point(664, 328);
            this.BuyWeapon5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuyWeapon5.Name = "BuyWeapon5";
            this.BuyWeapon5.Size = new System.Drawing.Size(144, 51);
            this.BuyWeapon5.TabIndex = 10;
            this.BuyWeapon5.Text = "Purschase Weapon 250";
            this.BuyWeapon5.UseVisualStyleBackColor = true;
            this.BuyWeapon5.Click += new System.EventHandler(this.PurschaseWeapon4_Click);
            // 
            // BuyHull2
            // 
            this.BuyHull2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyHull2.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyHull2.Location = new System.Drawing.Point(219, 262);
            this.BuyHull2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuyHull2.Name = "BuyHull2";
            this.BuyHull2.Size = new System.Drawing.Size(124, 50);
            this.BuyHull2.TabIndex = 10;
            this.BuyHull2.Text = "Purschase\r\nHull 250";
            this.BuyHull2.UseVisualStyleBackColor = true;
            this.BuyHull2.Click += new System.EventHandler(this.PurschaseHull2_Click);
            // 
            // BuyHull3
            // 
            this.BuyHull3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyHull3.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyHull3.Location = new System.Drawing.Point(219, 329);
            this.BuyHull3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuyHull3.Name = "BuyHull3";
            this.BuyHull3.Size = new System.Drawing.Size(124, 53);
            this.BuyHull3.TabIndex = 10;
            this.BuyHull3.Text = "Purschase\r\nHull 500";
            this.BuyHull3.UseVisualStyleBackColor = true;
            this.BuyHull3.Click += new System.EventHandler(this.PurschaseHull3_Click);
            // 
            // ArmouryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(818, 474);
            this.Controls.Add(this.BuyHull3);
            this.Controls.Add(this.BuyHull2);
            this.Controls.Add(this.BuyWeapon5);
            this.Controls.Add(this.BuyWeapon4);
            this.Controls.Add(this.BuyWeapon3);
            this.Controls.Add(this.BuyWeapon2);
            this.Controls.Add(this.StartGameLabel);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hull2);
            this.Controls.Add(this.Hull1);
            this.Controls.Add(this.Weapon5);
            this.Controls.Add(this.Weapon4);
            this.Controls.Add(this.Weapon3);
            this.Controls.Add(this.Weapon2);
            this.Controls.Add(this.Weapon1);
            this.Controls.Add(this.Hull);
            this.Controls.Add(this.BulletShow);
            this.Controls.Add(this.WeaponSelect);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HullSelect);
            this.Controls.Add(this.ShipPreview);
            this.Controls.Add(this.MyShip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ArmouryForm";
            this.Text = "Armoury";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HangarForm_FormClosing);
            this.Load += new System.EventHandler(this.HangarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShipPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyShip;
        public System.Windows.Forms.PictureBox ShipPreview;
        private System.Windows.Forms.Label HullSelect;
        private System.Windows.Forms.Label WeaponSelect;
        private System.Windows.Forms.Button Hull;
        private System.Windows.Forms.Button Hull1;
        private System.Windows.Forms.Button Hull2;
        private System.Windows.Forms.Button Weapon1;
        private System.Windows.Forms.Button Weapon2;
        private System.Windows.Forms.Button Weapon3;
        private System.Windows.Forms.Button Weapon4;
        private System.Windows.Forms.Button Weapon5;
        private System.Windows.Forms.Label BulletShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label StartGameLabel;
        private System.Windows.Forms.Button BuyWeapon2;
        private System.Windows.Forms.Button BuyWeapon3;
        private System.Windows.Forms.Button BuyWeapon4;
        private System.Windows.Forms.Button BuyWeapon5;
        private System.Windows.Forms.Button BuyHull2;
        private System.Windows.Forms.Button BuyHull3;
    }
}
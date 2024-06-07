namespace PokemonTypes
{
    partial class MainWindow
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
            this.type1 = new System.Windows.Forms.Label();
            this.type2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.normalButton = new System.Windows.Forms.Button();
            this.fightingButton = new System.Windows.Forms.Button();
            this.poisonButton = new System.Windows.Forms.Button();
            this.flyingButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.groundButton = new System.Windows.Forms.Button();
            this.grassButton = new System.Windows.Forms.Button();
            this.waterButton = new System.Windows.Forms.Button();
            this.fireButton = new System.Windows.Forms.Button();
            this.steelButton = new System.Windows.Forms.Button();
            this.ghostButton = new System.Windows.Forms.Button();
            this.bugButton = new System.Windows.Forms.Button();
            this.fairyButton = new System.Windows.Forms.Button();
            this.darkButton = new System.Windows.Forms.Button();
            this.dragonButton = new System.Windows.Forms.Button();
            this.iceButton = new System.Windows.Forms.Button();
            this.psychicButton = new System.Windows.Forms.Button();
            this.electricButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fourX = new System.Windows.Forms.ListView();
            this.twoX = new System.Windows.Forms.ListView();
            this.halfX = new System.Windows.Forms.ListView();
            this.oneX = new System.Windows.Forms.ListView();
            this.fourthX = new System.Windows.Forms.ListView();
            this.zeroX = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // type1
            // 
            this.type1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.type1.AutoSize = true;
            this.type1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type1.Location = new System.Drawing.Point(451, 23);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(0, 25);
            this.type1.TabIndex = 0;
            // 
            // type2
            // 
            this.type2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.type2.AutoSize = true;
            this.type2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type2.Location = new System.Drawing.Point(732, 23);
            this.type2.Name = "type2";
            this.type2.Size = new System.Drawing.Size(0, 25);
            this.type2.TabIndex = 1;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(578, 74);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(123, 54);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // normalButton
            // 
            this.normalButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.normalButton.BackColor = System.Drawing.Color.Silver;
            this.normalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalButton.Location = new System.Drawing.Point(363, 134);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(97, 40);
            this.normalButton.TabIndex = 3;
            this.normalButton.Text = "Normal";
            this.normalButton.UseVisualStyleBackColor = false;
            this.normalButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // fightingButton
            // 
            this.fightingButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fightingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.fightingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fightingButton.Location = new System.Drawing.Point(453, 134);
            this.fightingButton.Name = "fightingButton";
            this.fightingButton.Size = new System.Drawing.Size(97, 40);
            this.fightingButton.TabIndex = 4;
            this.fightingButton.Text = "Fighting";
            this.fightingButton.UseVisualStyleBackColor = false;
            this.fightingButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // poisonButton
            // 
            this.poisonButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poisonButton.BackColor = System.Drawing.Color.Indigo;
            this.poisonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poisonButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.poisonButton.Location = new System.Drawing.Point(636, 134);
            this.poisonButton.Name = "poisonButton";
            this.poisonButton.Size = new System.Drawing.Size(97, 40);
            this.poisonButton.TabIndex = 6;
            this.poisonButton.Text = "Poison";
            this.poisonButton.UseVisualStyleBackColor = false;
            this.poisonButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // flyingButton
            // 
            this.flyingButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flyingButton.BackColor = System.Drawing.Color.SkyBlue;
            this.flyingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flyingButton.Location = new System.Drawing.Point(546, 134);
            this.flyingButton.Name = "flyingButton";
            this.flyingButton.Size = new System.Drawing.Size(97, 40);
            this.flyingButton.TabIndex = 5;
            this.flyingButton.Text = "Flying";
            this.flyingButton.UseVisualStyleBackColor = false;
            this.flyingButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rockButton.BackColor = System.Drawing.Color.Tan;
            this.rockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockButton.Location = new System.Drawing.Point(821, 134);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(97, 40);
            this.rockButton.TabIndex = 8;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = false;
            this.rockButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // groundButton
            // 
            this.groundButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groundButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.groundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groundButton.ForeColor = System.Drawing.SystemColors.Control;
            this.groundButton.Location = new System.Drawing.Point(731, 134);
            this.groundButton.Name = "groundButton";
            this.groundButton.Size = new System.Drawing.Size(97, 40);
            this.groundButton.TabIndex = 7;
            this.groundButton.Text = "Ground";
            this.groundButton.UseVisualStyleBackColor = false;
            this.groundButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // grassButton
            // 
            this.grassButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grassButton.BackColor = System.Drawing.Color.Green;
            this.grassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grassButton.ForeColor = System.Drawing.SystemColors.Control;
            this.grassButton.Location = new System.Drawing.Point(821, 167);
            this.grassButton.Name = "grassButton";
            this.grassButton.Size = new System.Drawing.Size(97, 40);
            this.grassButton.TabIndex = 14;
            this.grassButton.Text = "Grass";
            this.grassButton.UseVisualStyleBackColor = false;
            this.grassButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // waterButton
            // 
            this.waterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.waterButton.BackColor = System.Drawing.Color.Blue;
            this.waterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterButton.ForeColor = System.Drawing.SystemColors.Control;
            this.waterButton.Location = new System.Drawing.Point(731, 167);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(97, 40);
            this.waterButton.TabIndex = 13;
            this.waterButton.Text = "Water";
            this.waterButton.UseVisualStyleBackColor = false;
            this.waterButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // fireButton
            // 
            this.fireButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fireButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireButton.ForeColor = System.Drawing.SystemColors.Control;
            this.fireButton.Location = new System.Drawing.Point(636, 167);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(97, 40);
            this.fireButton.TabIndex = 12;
            this.fireButton.Text = "Fire";
            this.fireButton.UseVisualStyleBackColor = false;
            this.fireButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // steelButton
            // 
            this.steelButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.steelButton.BackColor = System.Drawing.Color.CadetBlue;
            this.steelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.steelButton.Location = new System.Drawing.Point(546, 167);
            this.steelButton.Name = "steelButton";
            this.steelButton.Size = new System.Drawing.Size(97, 40);
            this.steelButton.TabIndex = 11;
            this.steelButton.Text = "Steel";
            this.steelButton.UseVisualStyleBackColor = false;
            this.steelButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // ghostButton
            // 
            this.ghostButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ghostButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ghostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghostButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ghostButton.Location = new System.Drawing.Point(453, 167);
            this.ghostButton.Name = "ghostButton";
            this.ghostButton.Size = new System.Drawing.Size(97, 40);
            this.ghostButton.TabIndex = 10;
            this.ghostButton.Text = "Ghost";
            this.ghostButton.UseVisualStyleBackColor = false;
            this.ghostButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // bugButton
            // 
            this.bugButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bugButton.BackColor = System.Drawing.Color.YellowGreen;
            this.bugButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugButton.Location = new System.Drawing.Point(363, 167);
            this.bugButton.Name = "bugButton";
            this.bugButton.Size = new System.Drawing.Size(97, 40);
            this.bugButton.TabIndex = 9;
            this.bugButton.Text = "Bug";
            this.bugButton.UseVisualStyleBackColor = false;
            this.bugButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // fairyButton
            // 
            this.fairyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fairyButton.BackColor = System.Drawing.Color.HotPink;
            this.fairyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fairyButton.Location = new System.Drawing.Point(821, 205);
            this.fairyButton.Name = "fairyButton";
            this.fairyButton.Size = new System.Drawing.Size(97, 40);
            this.fairyButton.TabIndex = 20;
            this.fairyButton.Text = "Fairy";
            this.fairyButton.UseVisualStyleBackColor = false;
            this.fairyButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // darkButton
            // 
            this.darkButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.darkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkButton.ForeColor = System.Drawing.SystemColors.Control;
            this.darkButton.Location = new System.Drawing.Point(731, 205);
            this.darkButton.Name = "darkButton";
            this.darkButton.Size = new System.Drawing.Size(97, 40);
            this.darkButton.TabIndex = 19;
            this.darkButton.Text = "Dark";
            this.darkButton.UseVisualStyleBackColor = false;
            this.darkButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // dragonButton
            // 
            this.dragonButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dragonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dragonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragonButton.ForeColor = System.Drawing.SystemColors.Control;
            this.dragonButton.Location = new System.Drawing.Point(636, 205);
            this.dragonButton.Name = "dragonButton";
            this.dragonButton.Size = new System.Drawing.Size(97, 40);
            this.dragonButton.TabIndex = 18;
            this.dragonButton.Text = "Dragon";
            this.dragonButton.UseVisualStyleBackColor = false;
            this.dragonButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // iceButton
            // 
            this.iceButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iceButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iceButton.Location = new System.Drawing.Point(546, 205);
            this.iceButton.Name = "iceButton";
            this.iceButton.Size = new System.Drawing.Size(97, 40);
            this.iceButton.TabIndex = 17;
            this.iceButton.Text = "Ice";
            this.iceButton.UseVisualStyleBackColor = false;
            this.iceButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // psychicButton
            // 
            this.psychicButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.psychicButton.BackColor = System.Drawing.Color.Orchid;
            this.psychicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psychicButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.psychicButton.Location = new System.Drawing.Point(453, 205);
            this.psychicButton.Name = "psychicButton";
            this.psychicButton.Size = new System.Drawing.Size(97, 40);
            this.psychicButton.TabIndex = 16;
            this.psychicButton.Text = "Psychic";
            this.psychicButton.UseVisualStyleBackColor = false;
            this.psychicButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // electricButton
            // 
            this.electricButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.electricButton.BackColor = System.Drawing.Color.Yellow;
            this.electricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electricButton.Location = new System.Drawing.Point(363, 205);
            this.electricButton.Name = "electricButton";
            this.electricButton.Size = new System.Drawing.Size(97, 40);
            this.electricButton.TabIndex = 15;
            this.electricButton.Text = "Electric";
            this.electricButton.UseVisualStyleBackColor = false;
            this.electricButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "4x";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "2x";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "1x";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(787, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "1/2x";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(955, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "1/4x";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(621, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "0x";
            // 
            // fourX
            // 
            this.fourX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fourX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourX.HideSelection = false;
            this.fourX.Location = new System.Drawing.Point(239, 294);
            this.fourX.Margin = new System.Windows.Forms.Padding(0);
            this.fourX.Name = "fourX";
            this.fourX.Size = new System.Drawing.Size(123, 317);
            this.fourX.TabIndex = 28;
            this.fourX.UseCompatibleStateImageBehavior = false;
            this.fourX.View = System.Windows.Forms.View.List;
            // 
            // twoX
            // 
            this.twoX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.twoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoX.HideSelection = false;
            this.twoX.Location = new System.Drawing.Point(406, 294);
            this.twoX.Name = "twoX";
            this.twoX.Size = new System.Drawing.Size(123, 317);
            this.twoX.TabIndex = 29;
            this.twoX.UseCompatibleStateImageBehavior = false;
            this.twoX.View = System.Windows.Forms.View.List;
            // 
            // halfX
            // 
            this.halfX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.halfX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfX.HideSelection = false;
            this.halfX.Location = new System.Drawing.Point(753, 294);
            this.halfX.Name = "halfX";
            this.halfX.Size = new System.Drawing.Size(123, 317);
            this.halfX.TabIndex = 30;
            this.halfX.UseCompatibleStateImageBehavior = false;
            this.halfX.View = System.Windows.Forms.View.List;
            // 
            // oneX
            // 
            this.oneX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.oneX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneX.HideSelection = false;
            this.oneX.Location = new System.Drawing.Point(578, 294);
            this.oneX.Name = "oneX";
            this.oneX.Size = new System.Drawing.Size(123, 317);
            this.oneX.TabIndex = 31;
            this.oneX.UseCompatibleStateImageBehavior = false;
            this.oneX.View = System.Windows.Forms.View.List;
            // 
            // fourthX
            // 
            this.fourthX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fourthX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthX.HideSelection = false;
            this.fourthX.Location = new System.Drawing.Point(916, 294);
            this.fourthX.Name = "fourthX";
            this.fourthX.Size = new System.Drawing.Size(123, 317);
            this.fourthX.TabIndex = 32;
            this.fourthX.UseCompatibleStateImageBehavior = false;
            this.fourthX.View = System.Windows.Forms.View.List;
            // 
            // zeroX
            // 
            this.zeroX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.zeroX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroX.HideSelection = false;
            this.zeroX.Location = new System.Drawing.Point(531, 661);
            this.zeroX.Name = "zeroX";
            this.zeroX.Size = new System.Drawing.Size(212, 94);
            this.zeroX.TabIndex = 33;
            this.zeroX.UseCompatibleStateImageBehavior = false;
            this.zeroX.View = System.Windows.Forms.View.List;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 775);
            this.Controls.Add(this.zeroX);
            this.Controls.Add(this.fourthX);
            this.Controls.Add(this.oneX);
            this.Controls.Add(this.halfX);
            this.Controls.Add(this.twoX);
            this.Controls.Add(this.fourX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fairyButton);
            this.Controls.Add(this.darkButton);
            this.Controls.Add(this.dragonButton);
            this.Controls.Add(this.iceButton);
            this.Controls.Add(this.psychicButton);
            this.Controls.Add(this.electricButton);
            this.Controls.Add(this.grassButton);
            this.Controls.Add(this.waterButton);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.steelButton);
            this.Controls.Add(this.ghostButton);
            this.Controls.Add(this.bugButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.groundButton);
            this.Controls.Add(this.poisonButton);
            this.Controls.Add(this.flyingButton);
            this.Controls.Add(this.fightingButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.type2);
            this.Controls.Add(this.type1);
            this.Name = "MainWindow";
            this.Text = "Pokemon Type Weaknesses";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label type1;
        private System.Windows.Forms.Label type2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button normalButton;
        private System.Windows.Forms.Button fightingButton;
        private System.Windows.Forms.Button poisonButton;
        private System.Windows.Forms.Button flyingButton;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button groundButton;
        private System.Windows.Forms.Button grassButton;
        private System.Windows.Forms.Button waterButton;
        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Button steelButton;
        private System.Windows.Forms.Button ghostButton;
        private System.Windows.Forms.Button bugButton;
        private System.Windows.Forms.Button fairyButton;
        private System.Windows.Forms.Button darkButton;
        private System.Windows.Forms.Button dragonButton;
        private System.Windows.Forms.Button iceButton;
        private System.Windows.Forms.Button psychicButton;
        private System.Windows.Forms.Button electricButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView fourX;
        private System.Windows.Forms.ListView twoX;
        private System.Windows.Forms.ListView halfX;
        private System.Windows.Forms.ListView oneX;
        private System.Windows.Forms.ListView fourthX;
        private System.Windows.Forms.ListView zeroX;
    }
}


namespace Sugoroku {
    partial class SettingForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnStart = new System.Windows.Forms.Button();
            this.gbPlayerNumber = new System.Windows.Forms.GroupBox();
            this.radioPlayerNumber4 = new System.Windows.Forms.RadioButton();
            this.radioPlayerNumber3 = new System.Windows.Forms.RadioButton();
            this.radioPlayerNumber2 = new System.Windows.Forms.RadioButton();
            this.radioPlayerNumber1 = new System.Windows.Forms.RadioButton();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.gbStage = new System.Windows.Forms.GroupBox();
            this.radioStage4 = new System.Windows.Forms.RadioButton();
            this.radioStage3 = new System.Windows.Forms.RadioButton();
            this.radioStage2 = new System.Windows.Forms.RadioButton();
            this.radioStage1 = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbPlayerNumber.SuspendLayout();
            this.gbStage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStart.Location = new System.Drawing.Point(521, 408);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(237, 60);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "ゲーム開始！！";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbPlayerNumber
            // 
            this.gbPlayerNumber.Controls.Add(this.radioPlayerNumber4);
            this.gbPlayerNumber.Controls.Add(this.radioPlayerNumber3);
            this.gbPlayerNumber.Controls.Add(this.radioPlayerNumber2);
            this.gbPlayerNumber.Controls.Add(this.radioPlayerNumber1);
            this.gbPlayerNumber.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbPlayerNumber.Location = new System.Drawing.Point(33, 96);
            this.gbPlayerNumber.Name = "gbPlayerNumber";
            this.gbPlayerNumber.Size = new System.Drawing.Size(721, 100);
            this.gbPlayerNumber.TabIndex = 13;
            this.gbPlayerNumber.TabStop = false;
            this.gbPlayerNumber.Text = "プレイヤー人数を選択";
            // 
            // radioPlayerNumber4
            // 
            this.radioPlayerNumber4.AutoSize = true;
            this.radioPlayerNumber4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioPlayerNumber4.Location = new System.Drawing.Point(394, 46);
            this.radioPlayerNumber4.Name = "radioPlayerNumber4";
            this.radioPlayerNumber4.Size = new System.Drawing.Size(75, 28);
            this.radioPlayerNumber4.TabIndex = 16;
            this.radioPlayerNumber4.Text = "４人";
            this.radioPlayerNumber4.UseVisualStyleBackColor = true;
            // 
            // radioPlayerNumber3
            // 
            this.radioPlayerNumber3.AutoSize = true;
            this.radioPlayerNumber3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioPlayerNumber3.Location = new System.Drawing.Point(275, 46);
            this.radioPlayerNumber3.Name = "radioPlayerNumber3";
            this.radioPlayerNumber3.Size = new System.Drawing.Size(75, 28);
            this.radioPlayerNumber3.TabIndex = 15;
            this.radioPlayerNumber3.Text = "３人";
            this.radioPlayerNumber3.UseVisualStyleBackColor = true;
            // 
            // radioPlayerNumber2
            // 
            this.radioPlayerNumber2.AutoSize = true;
            this.radioPlayerNumber2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioPlayerNumber2.Location = new System.Drawing.Point(160, 46);
            this.radioPlayerNumber2.Name = "radioPlayerNumber2";
            this.radioPlayerNumber2.Size = new System.Drawing.Size(75, 28);
            this.radioPlayerNumber2.TabIndex = 14;
            this.radioPlayerNumber2.Text = "２人";
            this.radioPlayerNumber2.UseVisualStyleBackColor = true;
            // 
            // radioPlayerNumber1
            // 
            this.radioPlayerNumber1.AutoSize = true;
            this.radioPlayerNumber1.Checked = true;
            this.radioPlayerNumber1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioPlayerNumber1.Location = new System.Drawing.Point(39, 46);
            this.radioPlayerNumber1.Name = "radioPlayerNumber1";
            this.radioPlayerNumber1.Size = new System.Drawing.Size(75, 28);
            this.radioPlayerNumber1.TabIndex = 13;
            this.radioPlayerNumber1.TabStop = true;
            this.radioPlayerNumber1.Text = "１人";
            this.radioPlayerNumber1.UseVisualStyleBackColor = true;
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.BackColor = System.Drawing.Color.Silver;
            this.btnBackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackMenu.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBackMenu.Location = new System.Drawing.Point(37, 408);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(237, 60);
            this.btnBackMenu.TabIndex = 14;
            this.btnBackMenu.Text = "メニューに戻る";
            this.btnBackMenu.UseVisualStyleBackColor = false;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // gbStage
            // 
            this.gbStage.Controls.Add(this.radioStage4);
            this.gbStage.Controls.Add(this.radioStage3);
            this.gbStage.Controls.Add(this.radioStage2);
            this.gbStage.Controls.Add(this.radioStage1);
            this.gbStage.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbStage.Location = new System.Drawing.Point(33, 255);
            this.gbStage.Name = "gbStage";
            this.gbStage.Size = new System.Drawing.Size(721, 100);
            this.gbStage.TabIndex = 17;
            this.gbStage.TabStop = false;
            this.gbStage.Text = "ステージを選択";
            // 
            // radioStage4
            // 
            this.radioStage4.AutoSize = true;
            this.radioStage4.Enabled = false;
            this.radioStage4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioStage4.Location = new System.Drawing.Point(518, 46);
            this.radioStage4.Name = "radioStage4";
            this.radioStage4.Size = new System.Drawing.Size(127, 28);
            this.radioStage4.TabIndex = 16;
            this.radioStage4.Text = "ステージ４";
            this.radioStage4.UseVisualStyleBackColor = true;
            // 
            // radioStage3
            // 
            this.radioStage3.AutoSize = true;
            this.radioStage3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioStage3.Location = new System.Drawing.Point(359, 46);
            this.radioStage3.Name = "radioStage3";
            this.radioStage3.Size = new System.Drawing.Size(127, 28);
            this.radioStage3.TabIndex = 15;
            this.radioStage3.Text = "ステージ３";
            this.radioStage3.UseVisualStyleBackColor = true;
            // 
            // radioStage2
            // 
            this.radioStage2.AutoSize = true;
            this.radioStage2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioStage2.Location = new System.Drawing.Point(197, 46);
            this.radioStage2.Name = "radioStage2";
            this.radioStage2.Size = new System.Drawing.Size(127, 28);
            this.radioStage2.TabIndex = 14;
            this.radioStage2.Text = "ステージ２";
            this.radioStage2.UseVisualStyleBackColor = true;
            // 
            // radioStage1
            // 
            this.radioStage1.AutoSize = true;
            this.radioStage1.Checked = true;
            this.radioStage1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioStage1.Location = new System.Drawing.Point(39, 46);
            this.radioStage1.Name = "radioStage1";
            this.radioStage1.Size = new System.Drawing.Size(127, 28);
            this.radioStage1.TabIndex = 13;
            this.radioStage1.TabStop = true;
            this.radioStage1.Text = "ステージ１";
            this.radioStage1.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-R", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(32, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(389, 46);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "ゲーム開始前の設定";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 543);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbStage);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.gbPlayerNumber);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ゲーム開始前の設定";
            this.gbPlayerNumber.ResumeLayout(false);
            this.gbPlayerNumber.PerformLayout();
            this.gbStage.ResumeLayout(false);
            this.gbStage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbPlayerNumber;
        private System.Windows.Forms.RadioButton radioPlayerNumber4;
        private System.Windows.Forms.RadioButton radioPlayerNumber3;
        private System.Windows.Forms.RadioButton radioPlayerNumber2;
        private System.Windows.Forms.RadioButton radioPlayerNumber1;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.GroupBox gbStage;
        private System.Windows.Forms.RadioButton radioStage4;
        private System.Windows.Forms.RadioButton radioStage3;
        private System.Windows.Forms.RadioButton radioStage2;
        private System.Windows.Forms.RadioButton radioStage1;
        private System.Windows.Forms.Label lblTitle;
    }
}
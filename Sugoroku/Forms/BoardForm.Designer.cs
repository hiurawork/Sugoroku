namespace Sugoroku {
    partial class BoardForm {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.btnBackSetting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDice = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.lblCurrentPlayer);
            this.panel2.Controls.Add(this.btnBackSetting);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnRollDice);
            this.panel2.Location = new System.Drawing.Point(850, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 703);
            this.panel2.TabIndex = 4;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-R", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCurrentPlayer.Location = new System.Drawing.Point(48, 31);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(242, 25);
            this.lblCurrentPlayer.TabIndex = 19;
            this.lblCurrentPlayer.Text = "プレイヤー１の番です";
            // 
            // btnBackSetting
            // 
            this.btnBackSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBackSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackSetting.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBackSetting.Location = new System.Drawing.Point(27, 587);
            this.btnBackSetting.Name = "btnBackSetting";
            this.btnBackSetting.Size = new System.Drawing.Size(260, 60);
            this.btnBackSetting.TabIndex = 6;
            this.btnBackSetting.Text = "設定に戻る";
            this.btnBackSetting.UseVisualStyleBackColor = false;
            this.btnBackSetting.Click += new System.EventHandler(this.btnBackSetting_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDice);
            this.panel1.Location = new System.Drawing.Point(27, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 314);
            this.panel1.TabIndex = 5;
            // 
            // lblDice
            // 
            this.lblDice.AutoSize = true;
            this.lblDice.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDice.Location = new System.Drawing.Point(24, 91);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(205, 144);
            this.lblDice.TabIndex = 0;
            this.lblDice.Text = "一";
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRollDice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRollDice.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRollDice.Location = new System.Drawing.Point(27, 423);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(260, 60);
            this.btnRollDice.TabIndex = 4;
            this.btnRollDice.Text = "さいころをふる";
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnHelp.Location = new System.Drawing.Point(27, 517);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(260, 60);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.Text = "ヘルプ";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ボード画面";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDice;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Button btnBackSetting;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Button btnHelp;
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sugoroku {
    /// <summary>
    /// ゲーム前の設定を表示するフォームです。
    /// </summary>
    public partial class SettingForm : Form {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SettingForm() {
            InitializeComponent();
        }

        /// <summary>
        /// ゲーム開始ボタンクリック時の動作です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e) {
            int playerNumber = GetPlayerNumber();
            int stage = GetStage();
            this.Close();
            BoardForm boardForm = new BoardForm(playerNumber, stage);
            boardForm.Show();
        }

        /// <summary>
        /// プレイヤー人数を取得します。
        /// </summary>
        /// <returns>プレイヤー人数を返します。</returns>
        private int GetPlayerNumber() {
            int number = 1;
            Dictionary<int, bool> radioButtons = new Dictionary<int, bool>() {
                { 1, radioPlayerNumber1.Checked },
                { 2, radioPlayerNumber2.Checked },
                { 3, radioPlayerNumber3.Checked },
                { 4, radioPlayerNumber4.Checked }
            };
            foreach (var radioButton in radioButtons) {
                if (radioButton.Value == true) {
                    number = radioButton.Key;
                }
            }

            return number;
        }

        /// <summary>
        /// ステージを取得します。
        /// </summary>
        /// <returns>ステージを返します。</returns>
        private int GetStage() {
            int stage = 1;
            Dictionary<int, bool> radioStages = new Dictionary<int, bool>() {
                { 1, radioStage1.Checked },
                { 2, radioStage2.Checked },
                { 3, radioStage3.Checked },
                { 4, radioStage4.Checked }
            };
            foreach (var radioStage in radioStages) {
                if (radioStage.Value == true) {
                    stage = radioStage.Key;
                }
            }

            return stage;
        }

        /// <summary>
        /// メニューに戻るボタンクリック時の動作です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackMenu_Click(object sender, EventArgs e) {
            this.Close();
            Menu form = new Menu();
            form.Show();
        }
    }
}

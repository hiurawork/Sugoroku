using System;
using System.Windows.Forms;

namespace Sugoroku {
    /// <summary>
    /// メインメニューのフォームです。
    /// </summary>
    public partial class Menu : Form {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Menu() {
            InitializeComponent();
        }

        /// <summary>
        /// 開始ボタンをクリックした時の動作です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e) {
            this.Hide();
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }

        /// <summary>
        /// 終了ボタンをクリックした時の動作です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}

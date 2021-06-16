using System;
using System.Windows.Forms;

namespace Sugoroku {
    /// <summary>
    /// 勝利した際に表示するフォームです。
    /// </summary>
    public partial class CongratulationForm : Form {
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="winner">勝利プレイヤー</param>
        public CongratulationForm(int winner) {
            InitializeComponent();
            lblTitle.Text = "プレイヤー" + winner + "の勝利です！！";
        }

        /// <summary>
        /// 再戦ボタンをクリックした時の動作です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestart_Click(object sender, EventArgs e) {
            this.Close();
            SettingForm form = new SettingForm();
            form.Show();
        }
    }
}

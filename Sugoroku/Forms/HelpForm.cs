using System;
using System.Windows.Forms;

namespace Sugoroku {
    /// <summary>
    /// ヘルプ情報を表示するフォームです。
    /// </summary>
    public partial class HelpForm : Form {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HelpForm() {
            InitializeComponent();
        }

        /// <summary>
        /// 閉じるボタンをクリックした時の動作です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

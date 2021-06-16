using System.Windows.Forms;

namespace Sugoroku {
    /// <summary>
    /// 各ボードの抽象基底クラスです。
    /// </summary>
    public partial class BoardBase : UserControl {
        /// <summary>
        /// ボードを管理するクラスのインスタンス
        /// </summary>
        protected BoardManager boardManager;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BoardBase() {
            InitializeComponent();
        }

        /// <summary>
        /// プレイヤーと出た目を元に、コマを移動させます。
        /// </summary>
        /// <param name="player">プレイヤー番号を指定します。</param>
        /// <param name="count">移動する数を指定します。</param>
        public void Play(int player, int count) {
            this.boardManager.Play(player, count);
        }

        /// <summary>
        /// ゴールしているプレイヤー番号を取得します。
        /// </summary>
        /// <returns>ゴールしているプレイヤーの番号を返します。ゴールしていなかったら99を返します。</returns>
        public int GetGoalPlayerNumber() {
            return this.boardManager.GetGoalPlayerNumber();
        }
    }
}

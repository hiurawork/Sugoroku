using System.Windows.Forms;

namespace Sgoroku {
    public class Board : UserControl {
        /// <summary>
        /// プレイヤーと出た目を元に、コマを移動させます。
        /// </summary>
        /// <param name="player">プレイヤー番号を指定します。</param>
        /// <param name="count">移動する数を指定します。</param>
        public virtual void Play(int player, int count) {}

        /// <summary>
        /// ゴールしているかどうかチェックします。
        /// </summary>
        /// <returns>ゴールしているプレイヤーの番号を返します。していなかったら99を返します。</returns>
        public virtual int CheckGoal() {
            return 1;
        }
    }
}

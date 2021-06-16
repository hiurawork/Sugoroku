using System.Windows.Forms;

namespace Sugoroku {
    /// <summary>
    /// タイプ２のボードクラスです。
    /// </summary>
    public partial class BoardType2 : BoardBase {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="playerNumber">プレイヤー人数を指定します。</param>
        public BoardType2(int playerNumber) {
            InitializeComponent();
            MasuType[] boardInfo = GetBoardInfo();
            this.boardManager = new BoardManager(boardInfo, playerNumber, this);
        }

        /// <summary>
        /// ボードの情報を取得します。
        /// 0はスタート、1はゴール、2は1マス進む、3は1マス戻る, 99は何もなし
        /// </summary>
        /// <returns>ボードの情報を返します。</returns>
        private MasuType[] GetBoardInfo() {
            MasuType[] boardInfo = {
                MasuType.Start,
                MasuType.GoOneMasu,
                MasuType.Default,
                MasuType.Default,
                MasuType.Default,
                MasuType.BackOneMasu,
                MasuType.Default,
                MasuType.Goal
            };

            return boardInfo;
        }
    }
}

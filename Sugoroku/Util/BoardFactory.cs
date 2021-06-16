using System.Collections.Generic;

namespace Sugoroku {
    /// <summary>
    /// ボードを生成するファクトリクラスです。
    /// </summary>
    static class BoardFactory {
        /// <summary>
        /// ボードのインスタンスを生成します。
        /// </summary>
        /// <param name="playerNumber">プレイヤーの人数を指定します。</param>
        /// <param name="stage">ステージを指定します。</param>
        /// <returns>作成されたボードのインスタンスを返します。</returns>
        public static BoardBase Create(int playerNumber, int stage) {
            Dictionary<int, BoardBase> stages = new Dictionary<int, BoardBase> {
                { 1, new BoardType1(playerNumber) },
                { 2, new BoardType2(playerNumber) },
                { 3, new BoardType3(playerNumber) },
            };
            BoardBase targetBoard = stages[stage];

            return targetBoard;
        }
    }
}

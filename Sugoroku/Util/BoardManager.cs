using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Sugoroku {
    /// <summary>
    /// ボードを管理するクラスです。
    /// </summary>
    public class BoardManager {
        /// <summary>
        /// プレイヤーごとの現在のマス
        /// </summary>
        private Dictionary<int, int> currentMasus = new Dictionary<int, int> {
            { 1, 0 },
            { 2, 0 },
            { 3, 0 },
            { 4, 0 }
        };

        /// <summary>
        /// ボード情報
        /// </summary>
        private MasuType[] boardInfo;

        /// <summary>
        /// 管理するボードのコントロール情報
        /// </summary>
        private UserControl boardControl;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="boardInfo">ボード情報を指定します。</param>
        /// <param name="playerNumber">始めのプレイヤー番号を指定します。</param>
        /// <param name="boardControl">管理するボードのコントロールを指定します。</param>
        public BoardManager(MasuType[] boardInfo, int playerNumber, UserControl boardControl) {
            this.boardInfo = boardInfo;
            this.boardControl = boardControl;
            this.InitPlayer(playerNumber);
        }

        /// <summary>
        /// プレイヤーと出た目を元に、コマを移動させます。
        /// </summary>
        /// <param name="player">プレイヤー番号を指定します。</param>
        /// <param name="count">移動する数を指定します。</param>
        public void Play(int player, int count) {
            int currentMasu = currentMasus[player];
            PictureBox targetPiece = GetTargetPiece(player);
            int movedMasu = currentMasu + count;
            if (movedMasu < boardInfo.Length) {
                MovePiece(targetPiece, count, currentMasu + 1);
                int newMasu = StopSpecialMasu(targetPiece, movedMasu);
                currentMasus[player] = newMasu;
            }
        }

        /// <summary>
        /// ゴールしているプレイヤー番号を取得します。
        /// </summary>
        /// <returns>ゴールしているプレイヤーの番号を返します。ゴールしていなかったら99を返します。</returns>
        public int GetGoalPlayerNumber() {
            int playerNumber = 99;
            int goal = boardInfo.Length - 1;
            foreach (var currentMasu in currentMasus) {
                if (currentMasu.Value == goal) {
                    playerNumber = currentMasu.Key;
                }
            }

            return playerNumber;
        }

        /// <summary>
        /// プレイヤーを初期化します。
        /// </summary>
        /// <param name="playerNumber">プレイヤー人数を指定します。</param>
        protected void InitPlayer(int playerNumber) {
            for (int i = 1; i <= playerNumber; i++) {
                string controlName = "pbPlayer" + i;
                Control[] cs = boardControl.Controls.Find(controlName, true);
                PictureBox pb = (PictureBox)cs[0];
                pb.Visible = true;
            }
        }

        /// <summary>
        /// コマを取得します。
        /// </summary>
        /// <param name="player">プレイヤー番号を指定します。</param>
        /// <returns>プレイヤー番号に一致したコマのコントロールを返します。</returns>
        private PictureBox GetTargetPiece(int player) {
            string controlName = "pbPlayer" + player;
            Control[] pieceControl = boardControl.Controls.Find(controlName, true);

            return (PictureBox)pieceControl[0];
        }

        /// <summary>
        /// 特殊マスに止まったときの動作です。
        /// </summary>
        /// <param name="targetPiece">コマのコントロールを指定します。</param>
        /// <param name="currentMasu">現在止まっているマスの番号を指定します。</param>
        /// <returns>新しいマスの番号を返します。</returns>
        private int StopSpecialMasu(PictureBox targetPiece, int currentMasu) {
            int goal = boardInfo.Length - 1;
            int newMasu = currentMasu;
            switch (boardInfo[currentMasu]) {
                case MasuType.Goal:
                    newMasu = goal;
                    MovePiece(targetPiece, 1, goal);
                    break;
                case MasuType.GoOneMasu:
                    newMasu++;
                    MovePiece(targetPiece, 1, newMasu);
                    break;
                case MasuType.BackOneMasu:
                    newMasu--;
                    MovePiece(targetPiece, 1, newMasu);
                    break;
                default:
                    break;
            }

            return newMasu;
        }


        /// <summary>
        /// コマを移動させます。
        /// </summary>
        /// <param name="pieceControl">コマのコントロールを指定します。</param>
        /// <param name="masuNumber">移動するカウントを指定します。</param>
        /// <param name="masuNumber">移動するマスの番号を指定します。</param>
        private void MovePiece(PictureBox pieceControl, int count, int masuNumber) {
            Thread.Sleep(1000);
            int nextMasu = masuNumber;
            for (int i = 0; i < count; i++) {
                string controlName = "pnlMasu" + nextMasu;
                Control[] masuControl = boardControl.Controls.Find(controlName, true);
                if (masuControl.Length != 0) {
                    Panel pb = (Panel)masuControl[0];
                    pb.Controls.Add(pieceControl);
                }
                boardControl.Refresh();
                Thread.Sleep(1000);
                nextMasu++;
            }
        }
    }
}

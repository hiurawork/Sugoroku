using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Sugoroku
{
    /// <summary>
    /// ボードのメインフォームです。
    /// </summary>
    public partial class BoardForm : Form
    {
        /// <summary>
        /// プレイヤー人数
        /// </summary>
        private int playerNumber;

        /// <summary>
        /// ステージ
        /// </summary>
        private int stage;

        /// <summary>
        /// 現在のプレイヤー
        /// </summary>
        private int currentPlayer = 1;

        /// <summary>
        /// サイコロの目
        /// </summary>
        private readonly Dictionary<int, string> DICES = new Dictionary<int, string>
        {
            { 1, "一" },
            { 2, "二" },
            { 3, "三" },
            { 4, "四" },
            { 5, "五" },
            { 6, "六" }
        };

        /// <summary>
        /// サイコロを振る回数
        /// </summary>
        private readonly int ROLL_COUNT = 20;

        /// <summary>
        /// ボードコントロール
        /// </summary>
        private BoardBase boardControl;

        /// <summary>
        /// 設定画面に戻るポップアップのタイトル
        /// </summary>
        private readonly string TITLE_CONFIRM_BACK_SETTING = "確認";

        /// <summary>
        /// 設定画面に戻るポップアップのメッセージ
        /// </summary>
        private readonly string MSG_CONFIRM_BACK_SETTING = "設定画面に戻りますか？";

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="playerNumber">プレイヤー人数を指定します。</param>
        /// <param name="stage">ステージを指定します。</param>
        public BoardForm(int playerNumber, int stage)
        {
            this.playerNumber = playerNumber;
            this.stage = stage;
            InitializeComponent();
            AddBordControl();
            InitPlayer();
        }

        /// <summary>
        /// ボードのコントロールを追加します。
        /// </summary>
        private void AddBordControl()
        {
            boardControl = BoardFactory.Create(playerNumber, stage);
            boardControl.Location = new Point(0, 0);
            boardControl.Size = new Size(800, 800);
            this.Controls.Add(boardControl);
        }

        /// <summary>
        /// プレイヤを初期化します。
        /// </summary>
        private void InitPlayer()
        {
            Random random = new System.Random();
            int player = random.Next(1, this.playerNumber);
            currentPlayer = player;
            ShowPlayerTurn(currentPlayer);
        }

        /// <summary>
        /// さいころをふるボタンをクリックした時の動作です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            btnRollDice.Enabled = false;

            int diceNumber = RollDice();
            boardControl.Play(currentPlayer, diceNumber);
            ProcessAfterPlay();

            btnRollDice.Enabled = true;
        }

        /// <summary>
        /// サイコロを振ります。
        /// </summary>
        /// <returns>出た目を返します。</returns>
        private int RollDice()
        {
            int diceNumber = 1;
            for (int i = 0; i < ROLL_COUNT; i++)
            {
                Random random = new System.Random();
                diceNumber = random.Next(1, 6);
                lblDice.Text = DICES[diceNumber];
                Thread.Sleep(10);
                this.Refresh();
            }

            return diceNumber;
        }

        /// <summary>
        /// プレイ後の処理を行います。
        /// </summary>
        private void ProcessAfterPlay()
        {
            int goalPlayerNumber = boardControl.GetGoalPlayerNumber();
            if (goalPlayerNumber == 99)
            {
                ChangeCurrentPlayer();
            }
            else
            {
                ShowCongratulationForm();
            }
        }

        /// <summary>
        /// 現在のプレイヤーを変更します。
        /// </summary>
        private void ChangeCurrentPlayer()
        {
            if (currentPlayer == playerNumber)
            {
                currentPlayer = 1;
            }
            else
            {
                currentPlayer++;
            }
            ShowPlayerTurn(currentPlayer);
        }

        /// <summary>
        /// プレイヤーの手番を表示します。
        /// </summary>
        /// <param name="playerNumber">表示するプレイヤーの番号を指定します。</param>
        private void ShowPlayerTurn(int playerNumber)
        {
            lblCurrentPlayer.Text = $"プレイヤー{playerNumber}の番";
        }

        /// <summary>
        /// 勝利画面を表示します。
        /// </summary>
        private void ShowCongratulationForm()
        {
            this.Close();
            CongratulationForm congratulationForm = new CongratulationForm(currentPlayer);
            congratulationForm.Show();
        }

        /// <summary>
        /// ヘルプボタンクリック時の動作です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.Show();
        }


        /// <summary>
        /// 設定に戻るボタンクリック時の動作です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackSetting_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                MSG_CONFIRM_BACK_SETTING,
                TITLE_CONFIRM_BACK_SETTING,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
                SettingForm form = new SettingForm();
                form.Show();
            }
        }
    }
}

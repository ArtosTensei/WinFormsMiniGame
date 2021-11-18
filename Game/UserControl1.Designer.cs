
namespace Game
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.playGame = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(202, 202);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Стоп";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00:00:000:0";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.tmrClock1_Tick);
            // 
            // playGame
            // 
            this.playGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playGame.Location = new System.Drawing.Point(202, 36);
            this.playGame.Name = "playGame";
            this.playGame.Size = new System.Drawing.Size(75, 23);
            this.playGame.TabIndex = 2;
            this.playGame.Text = "Start";
            this.playGame.UseVisualStyleBackColor = true;
            this.playGame.Click += new System.EventHandler(this.playGame_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.tmrClock2_Tick);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(471, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button playGame;
        private System.Windows.Forms.Timer timer3;
    }
}

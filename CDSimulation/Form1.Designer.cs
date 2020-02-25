namespace CDSimulation
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.discCapacity = new CircularProgressBar.CircularProgressBar();
            this.fileTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // discCapacity
            // 
            this.discCapacity.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.discCapacity.AnimationSpeed = 500;
            this.discCapacity.BackColor = System.Drawing.Color.Transparent;
            this.discCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.discCapacity.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.discCapacity.InnerMargin = 2;
            this.discCapacity.InnerWidth = -1;
            this.discCapacity.Location = new System.Drawing.Point(611, 79);
            this.discCapacity.MarqueeAnimationSpeed = 2000;
            this.discCapacity.Name = "discCapacity";
            this.discCapacity.OuterColor = System.Drawing.Color.MediumSeaGreen;
            this.discCapacity.OuterMargin = -25;
            this.discCapacity.OuterWidth = 26;
            this.discCapacity.ProgressColor = System.Drawing.Color.DarkRed;
            this.discCapacity.ProgressWidth = 25;
            this.discCapacity.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discCapacity.Size = new System.Drawing.Size(276, 276);
            this.discCapacity.StartAngle = 270;
            this.discCapacity.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.discCapacity.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.discCapacity.SubscriptText = "";
            this.discCapacity.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.discCapacity.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.discCapacity.SuperscriptText = "";
            this.discCapacity.TabIndex = 0;
            this.discCapacity.Text = "Disc";
            this.discCapacity.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.discCapacity.Value = 8;
            // 
            // fileTableLayoutPanel
            // 
            this.fileTableLayoutPanel.ColumnCount = 2;
            this.fileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.fileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.fileTableLayoutPanel.Location = new System.Drawing.Point(81, 47);
            this.fileTableLayoutPanel.Name = "fileTableLayoutPanel";
            this.fileTableLayoutPanel.RowCount = 3;
            this.fileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fileTableLayoutPanel.Size = new System.Drawing.Size(200, 125);
            this.fileTableLayoutPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(990, 598);
            this.Controls.Add(this.fileTableLayoutPanel);
            this.Controls.Add(this.discCapacity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar discCapacity;
        private System.Windows.Forms.TableLayoutPanel fileTableLayoutPanel;
    }
}


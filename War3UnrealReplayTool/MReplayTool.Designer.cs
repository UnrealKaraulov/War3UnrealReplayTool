namespace War3UnrealReplayTool
{
    partial class MainReplayForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.OpenW3Gbtn = new System.Windows.Forms.Button();
            this.ReplayFilePath = new System.Windows.Forms.TextBox();
            this.off_verlabel = new System.Windows.Forms.Label();
            this.w3gversion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.off_icclabel = new System.Windows.Forms.Label();
            this.IsIccupW3G = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpenW3Gbtn
            // 
            this.OpenW3Gbtn.Location = new System.Drawing.Point(280, 10);
            this.OpenW3Gbtn.Name = "OpenW3Gbtn";
            this.OpenW3Gbtn.Size = new System.Drawing.Size(75, 23);
            this.OpenW3Gbtn.TabIndex = 0;
            this.OpenW3Gbtn.Text = "Open .w3g";
            this.OpenW3Gbtn.UseVisualStyleBackColor = true;
            this.OpenW3Gbtn.Click += new System.EventHandler(this.OpenW3Gbtn_Click);
            // 
            // ReplayFilePath
            // 
            this.ReplayFilePath.Enabled = false;
            this.ReplayFilePath.Location = new System.Drawing.Point(12, 12);
            this.ReplayFilePath.Name = "ReplayFilePath";
            this.ReplayFilePath.Size = new System.Drawing.Size(262, 20);
            this.ReplayFilePath.TabIndex = 1;
            // 
            // off_verlabel
            // 
            this.off_verlabel.AutoSize = true;
            this.off_verlabel.Location = new System.Drawing.Point(46, 51);
            this.off_verlabel.Name = "off_verlabel";
            this.off_verlabel.Size = new System.Drawing.Size(80, 13);
            this.off_verlabel.TabIndex = 2;
            this.off_verlabel.Text = "Replay version:";
            // 
            // w3gversion
            // 
            this.w3gversion.Location = new System.Drawing.Point(144, 44);
            this.w3gversion.Name = "w3gversion";
            this.w3gversion.Size = new System.Drawing.Size(100, 20);
            this.w3gversion.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save .w3g";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // off_icclabel
            // 
            this.off_icclabel.AutoSize = true;
            this.off_icclabel.Location = new System.Drawing.Point(46, 76);
            this.off_icclabel.Name = "off_icclabel";
            this.off_icclabel.Size = new System.Drawing.Size(69, 13);
            this.off_icclabel.TabIndex = 2;
            this.off_icclabel.Text = "iCCup replay:";
            // 
            // IsIccupW3G
            // 
            this.IsIccupW3G.Location = new System.Drawing.Point(144, 70);
            this.IsIccupW3G.Name = "IsIccupW3G";
            this.IsIccupW3G.Size = new System.Drawing.Size(100, 20);
            this.IsIccupW3G.TabIndex = 3;
            // 
            // MainReplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 221);
            this.Controls.Add(this.IsIccupW3G);
            this.Controls.Add(this.w3gversion);
            this.Controls.Add(this.off_icclabel);
            this.Controls.Add(this.off_verlabel);
            this.Controls.Add(this.ReplayFilePath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpenW3Gbtn);
            this.Name = "MainReplayForm";
            this.Text = "Unreal Replay Tool v0.1a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenW3Gbtn;
        private System.Windows.Forms.TextBox ReplayFilePath;
        private System.Windows.Forms.Label off_verlabel;
        private System.Windows.Forms.TextBox w3gversion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label off_icclabel;
        private System.Windows.Forms.TextBox IsIccupW3G;
    }
}


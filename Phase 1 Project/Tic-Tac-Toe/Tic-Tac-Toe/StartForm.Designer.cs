
namespace Tic_Tac_Toe
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.markPanel = new System.Windows.Forms.Panel();
            this.radioButtonO = new System.Windows.Forms.RadioButton();
            this.radioButtonX = new System.Windows.Forms.RadioButton();
            this.listBoxRecords = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.markPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // markPanel
            // 
            this.markPanel.Controls.Add(this.radioButtonO);
            this.markPanel.Controls.Add(this.radioButtonX);
            this.markPanel.Location = new System.Drawing.Point(126, 335);
            this.markPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.markPanel.Name = "markPanel";
            this.markPanel.Size = new System.Drawing.Size(150, 69);
            this.markPanel.TabIndex = 1;
            // 
            // radioButtonO
            // 
            this.radioButtonO.AutoSize = true;
            this.radioButtonO.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonO.Location = new System.Drawing.Point(76, 11);
            this.radioButtonO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonO.Name = "radioButtonO";
            this.radioButtonO.Size = new System.Drawing.Size(46, 31);
            this.radioButtonO.TabIndex = 1;
            this.radioButtonO.TabStop = true;
            this.radioButtonO.Text = "O";
            this.radioButtonO.UseVisualStyleBackColor = true;
            // 
            // radioButtonX
            // 
            this.radioButtonX.AutoSize = true;
            this.radioButtonX.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonX.Location = new System.Drawing.Point(4, 11);
            this.radioButtonX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonX.Name = "radioButtonX";
            this.radioButtonX.Size = new System.Drawing.Size(42, 31);
            this.radioButtonX.TabIndex = 0;
            this.radioButtonX.TabStop = true;
            this.radioButtonX.Text = "X";
            this.radioButtonX.UseVisualStyleBackColor = true;
            // 
            // listBoxRecords
            // 
            this.listBoxRecords.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecords.FormattingEnabled = true;
            this.listBoxRecords.ItemHeight = 27;
            this.listBoxRecords.Location = new System.Drawing.Point(18, 482);
            this.listBoxRecords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxRecords.Name = "listBoxRecords";
            this.listBoxRecords.Size = new System.Drawing.Size(688, 166);
            this.listBoxRecords.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(18, 455);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 8);
            this.panel3.TabIndex = 5;
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewName.Location = new System.Drawing.Point(18, 226);
            this.textBoxNewName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(688, 45);
            this.textBoxNewName.TabIndex = 6;
            this.textBoxNewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome to Tic-Tac-Toe!";
            // 
            // startGameBtn
            // 
            this.startGameBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameBtn.Location = new System.Drawing.Point(357, 335);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(262, 69);
            this.startGameBtn.TabIndex = 8;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(726, 709);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listBoxRecords);
            this.Controls.Add(this.markPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-tac-Toe";
            this.markPanel.ResumeLayout(false);
            this.markPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel markPanel;
        private System.Windows.Forms.ListBox listBoxRecords;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonX;
        private System.Windows.Forms.RadioButton radioButtonO;
        private System.Windows.Forms.Button startGameBtn;
    }
}


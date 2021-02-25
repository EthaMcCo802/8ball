
namespace _8ball
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.eightBallButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eightBallButton
            // 
            this.eightBallButton.BackColor = System.Drawing.Color.Transparent;
            this.eightBallButton.FlatAppearance.BorderSize = 0;
            this.eightBallButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eightBallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eightBallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightBallButton.Location = new System.Drawing.Point(171, 97);
            this.eightBallButton.Name = "eightBallButton";
            this.eightBallButton.Size = new System.Drawing.Size(526, 497);
            this.eightBallButton.TabIndex = 0;
            this.eightBallButton.UseVisualStyleBackColor = false;
            this.eightBallButton.Click += new System.EventHandler(this.eightBallButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(168, 638);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(529, 52);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(263, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(340, 44);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Think of a question";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_8ball.Properties.Resources.clickBall;
            this.ClientSize = new System.Drawing.Size(854, 699);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.eightBallButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "8Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eightBallButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}



namespace lab8_immod
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.buttonGetAnswer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGetAnswerOrb = new System.Windows.Forms.Button();
            this.labelAnswerOrb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(138, 190);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(46, 20);
            this.labelAnswer.TabIndex = 1;
            this.labelAnswer.Text = "And..";
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Location = new System.Drawing.Point(200, 221);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(0, 20);
            this.labelNo.TabIndex = 2;
            // 
            // buttonGetAnswer
            // 
            this.buttonGetAnswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGetAnswer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetAnswer.Location = new System.Drawing.Point(78, 116);
            this.buttonGetAnswer.Name = "buttonGetAnswer";
            this.buttonGetAnswer.Size = new System.Drawing.Size(173, 53);
            this.buttonGetAnswer.TabIndex = 3;
            this.buttonGetAnswer.Text = "Get answer";
            this.buttonGetAnswer.UseVisualStyleBackColor = false;
            this.buttonGetAnswer.Click += new System.EventHandler(this.buttonGetAnswer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(77, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "YES or NO?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Orb of predictions";
            // 
            // buttonGetAnswerOrb
            // 
            this.buttonGetAnswerOrb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGetAnswerOrb.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetAnswerOrb.Location = new System.Drawing.Point(486, 116);
            this.buttonGetAnswerOrb.Name = "buttonGetAnswerOrb";
            this.buttonGetAnswerOrb.Size = new System.Drawing.Size(173, 53);
            this.buttonGetAnswerOrb.TabIndex = 6;
            this.buttonGetAnswerOrb.Text = "Get answer";
            this.buttonGetAnswerOrb.UseVisualStyleBackColor = false;
            this.buttonGetAnswerOrb.Click += new System.EventHandler(this.buttonGetAnswerOrb_Click);
            // 
            // labelAnswerOrb
            // 
            this.labelAnswerOrb.AutoSize = true;
            this.labelAnswerOrb.Location = new System.Drawing.Point(546, 190);
            this.labelAnswerOrb.Name = "labelAnswerOrb";
            this.labelAnswerOrb.Size = new System.Drawing.Size(46, 20);
            this.labelAnswerOrb.TabIndex = 7;
            this.labelAnswerOrb.Text = "And..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAnswerOrb);
            this.Controls.Add(this.buttonGetAnswerOrb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGetAnswer);
            this.Controls.Add(this.labelNo);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Button buttonGetAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGetAnswerOrb;
        private System.Windows.Forms.Label labelAnswerOrb;
    }
}


namespace formMessenger1
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
            this.myUserTxt = new System.Windows.Forms.TextBox();
            this.myIPTxt = new System.Windows.Forms.TextBox();
            this.peerIPTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.peerUserTxt = new System.Windows.Forms.TextBox();
            this.messegeWindowTxt = new System.Windows.Forms.RichTextBox();
            this.messegeToSendTxt = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.connBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myUserTxt
            // 
            this.myUserTxt.Location = new System.Drawing.Point(109, 44);
            this.myUserTxt.Name = "myUserTxt";
            this.myUserTxt.Size = new System.Drawing.Size(100, 22);
            this.myUserTxt.TabIndex = 0;
            this.myUserTxt.Text = "User1";
            // 
            // myIPTxt
            // 
            this.myIPTxt.Location = new System.Drawing.Point(259, 44);
            this.myIPTxt.Name = "myIPTxt";
            this.myIPTxt.Size = new System.Drawing.Size(197, 22);
            this.myIPTxt.TabIndex = 1;
            this.myIPTxt.Text = "127.0.0.1";
            // 
            // peerIPTxt
            // 
            this.peerIPTxt.Location = new System.Drawing.Point(875, 41);
            this.peerIPTxt.Name = "peerIPTxt";
            this.peerIPTxt.Size = new System.Drawing.Size(169, 22);
            this.peerIPTxt.TabIndex = 2;
            this.peerIPTxt.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(818, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Peer IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Peer Username";
            // 
            // peerUserTxt
            // 
            this.peerUserTxt.Location = new System.Drawing.Point(692, 44);
            this.peerUserTxt.Name = "peerUserTxt";
            this.peerUserTxt.Size = new System.Drawing.Size(100, 22);
            this.peerUserTxt.TabIndex = 6;
            this.peerUserTxt.Text = "User2";
            // 
            // messegeWindowTxt
            // 
            this.messegeWindowTxt.Location = new System.Drawing.Point(15, 105);
            this.messegeWindowTxt.Name = "messegeWindowTxt";
            this.messegeWindowTxt.Size = new System.Drawing.Size(1029, 337);
            this.messegeWindowTxt.TabIndex = 8;
            this.messegeWindowTxt.Text = "";
            // 
            // messegeToSendTxt
            // 
            this.messegeToSendTxt.Location = new System.Drawing.Point(15, 488);
            this.messegeToSendTxt.Name = "messegeToSendTxt";
            this.messegeToSendTxt.Size = new System.Drawing.Size(892, 22);
            this.messegeToSendTxt.TabIndex = 9;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(944, 488);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 10;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // connBtn
            // 
            this.connBtn.Location = new System.Drawing.Point(969, 76);
            this.connBtn.Name = "connBtn";
            this.connBtn.Size = new System.Drawing.Size(75, 23);
            this.connBtn.TabIndex = 11;
            this.connBtn.Text = "Connect";
            this.connBtn.UseVisualStyleBackColor = true;
            this.connBtn.Click += new System.EventHandler(this.connBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 531);
            this.Controls.Add(this.connBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.messegeToSendTxt);
            this.Controls.Add(this.messegeWindowTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.peerUserTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peerIPTxt);
            this.Controls.Add(this.myIPTxt);
            this.Controls.Add(this.myUserTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myUserTxt;
        private System.Windows.Forms.TextBox myIPTxt;
        private System.Windows.Forms.TextBox peerIPTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox peerUserTxt;
        private System.Windows.Forms.RichTextBox messegeWindowTxt;
        private System.Windows.Forms.TextBox messegeToSendTxt;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button connBtn;
    }
}


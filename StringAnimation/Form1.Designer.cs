
namespace StringAnimation
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.fpsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 16F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "time(s)";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(17, 102);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(100, 25);
            this.timeBox.TabIndex = 1;
            this.timeBox.TextChanged += new System.EventHandler(this.timeBox_TextChanged);
            // 
            // fpsBox
            // 
            this.fpsBox.Location = new System.Drawing.Point(17, 230);
            this.fpsBox.Name = "fpsBox";
            this.fpsBox.Size = new System.Drawing.Size(100, 25);
            this.fpsBox.TabIndex = 2;
            this.fpsBox.TextChanged += new System.EventHandler(this.fpsBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 16F);
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "FPS";
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("新細明體", 16F);
            this.CreateButton.Location = new System.Drawing.Point(424, 12);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 48);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("新細明體", 16F);
            this.playButton.Location = new System.Drawing.Point(240, 12);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 48);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("新細明體", 16F);
            this.DeleteButton.Location = new System.Drawing.Point(607, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 48);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 16F);
            this.label3.Location = new System.Drawing.Point(12, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Drag your file";
            // 
            // information
            // 
            this.information.Font = new System.Drawing.Font("新細明體", 16F);
            this.information.Location = new System.Drawing.Point(253, 122);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(418, 152);
            this.information.TabIndex = 9;
            // 
            // inputBox
            // 
            this.inputBox.AllowDrop = true;
            this.inputBox.Location = new System.Drawing.Point(17, 413);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(761, 25);
            this.inputBox.TabIndex = 10;
            this.inputBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputBox_DragDrop);
            this.inputBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.inputBox_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.information);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fpsBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox fpsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.TextBox inputBox;
    }
}


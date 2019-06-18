namespace Package4CS
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Location = new System.Drawing.Point(413, 0);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox1.Size = new System.Drawing.Size(546, 422);
            this.TextBox1.TabIndex = 1;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.TextBox1);
            this.Panel2.Controls.Add(this.splitter1);
            this.Panel2.Controls.Add(this.panel4);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 156);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(959, 422);
            this.Panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPackageId);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 422);
            this.panel4.TabIndex = 2;
            // 
            // txtPackageId
            // 
            this.txtPackageId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPackageId.Location = new System.Drawing.Point(0, 0);
            this.txtPackageId.Multiline = true;
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPackageId.Size = new System.Drawing.Size(406, 422);
            this.txtPackageId.TabIndex = 1;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btnCreate);
            this.Panel1.Controls.Add(this.panel5);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.txtDest);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.txtSource);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(959, 90);
            this.Panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 76);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.panel5.Size = new System.Drawing.Size(959, 14);
            this.panel5.TabIndex = 7;
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button2.Location = new System.Drawing.Point(719, 47);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(73, 23);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Select";
            this.Button2.UseCompatibleTextRendering = true;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button1.Location = new System.Drawing.Point(720, 7);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(73, 23);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Select";
            this.Button1.UseCompatibleTextRendering = true;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(145, 48);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(568, 22);
            this.txtDest.TabIndex = 3;
            this.txtDest.Text = "C:\\Box_Workspace\\04.成果物\\adb";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 51);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(123, 17);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Destination Folder";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(145, 7);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(568, 22);
            this.txtSource.TabIndex = 1;
            this.txtSource.Text = "C:\\RTC_workspace\\";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(97, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Source Folder";
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.panel6);
            this.Panel3.Controls.Add(this.ProgressBar1);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel3.Location = new System.Drawing.Point(0, 90);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(959, 66);
            this.Panel3.TabIndex = 5;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar1.Location = new System.Drawing.Point(0, 41);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(959, 25);
            this.ProgressBar1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitter1.Location = new System.Drawing.Point(406, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(7, 422);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(810, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(77, 70);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radioButton2);
            this.panel6.Controls.Add(this.radioButton1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(959, 41);
            this.panel6.TabIndex = 5;
            // 
            // radioButton2
            // 
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(181, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(170, 30);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PackageID";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(5, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(170, 30);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "FileList";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 578);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Name = "Form1";
            this.Text = "Package";
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtDest;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtSource;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Splitter splitter1;
        internal System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}


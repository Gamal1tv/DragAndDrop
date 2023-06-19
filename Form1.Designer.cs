namespace DragAndDrop
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cboxPbChange = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.White;
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Image = global::DragAndDrop.Properties.Resources.Cheetos;
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 100);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.White;
            this.pb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb3.Image = global::DragAndDrop.Properties.Resources.images;
            this.pb3.Location = new System.Drawing.Point(256, 12);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(100, 100);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 1;
            this.pb3.TabStop = false;
            this.pb3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            // 
            // pb2
            // 
            this.pb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb2.Image = global::DragAndDrop.Properties.Resources.hubbabubba;
            this.pb2.Location = new System.Drawing.Point(134, 12);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(100, 100);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            this.pb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            // 
            // pb6
            // 
            this.pb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb6.Image = global::DragAndDrop.Properties.Resources.pringles;
            this.pb6.Location = new System.Drawing.Point(256, 127);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(100, 100);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 5;
            this.pb6.TabStop = false;
            this.pb6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            // 
            // pb5
            // 
            this.pb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb5.Image = global::DragAndDrop.Properties.Resources.MilkyWay;
            this.pb5.Location = new System.Drawing.Point(134, 127);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(100, 100);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            this.pb5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            // 
            // pb4
            // 
            this.pb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb4.Image = global::DragAndDrop.Properties.Resources.kitkat;
            this.pb4.Location = new System.Drawing.Point(12, 127);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(100, 100);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            this.pb4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.White;
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Location = new System.Drawing.Point(420, 12);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(215, 215);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 6;
            this.pbMain.TabStop = false;
            this.pbMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbMain_DragDrop);
            this.pbMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbMain_DragEnter);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(387, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 215);
            this.label1.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cboxPbChange
            // 
            this.cboxPbChange.FormattingEnabled = true;
            this.cboxPbChange.Items.AddRange(new object[] {
            "Picture Box 1",
            "Picture Box 2",
            "Picture Box 3",
            "Picture Box 4",
            "Picture Box 5",
            "Picture Box 6"});
            this.cboxPbChange.Location = new System.Drawing.Point(420, 244);
            this.cboxPbChange.Name = "cboxPbChange";
            this.cboxPbChange.Size = new System.Drawing.Size(121, 21);
            this.cboxPbChange.TabIndex = 8;
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(550, 244);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 21);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 277);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cboxPbChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cboxPbChange;
        private System.Windows.Forms.Button btnSelect;
    }
}


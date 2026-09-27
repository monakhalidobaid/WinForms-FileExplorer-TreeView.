namespace playAround
{
    partial class TreeView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("this Pc");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeView));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.rbImage = new System.Windows.Forms.RadioButton();
            this.rbMusic = new System.Windows.Forms.RadioButton();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbWord = new System.Windows.Forms.RadioButton();
            this.rbPdf = new System.Windows.Forms.RadioButton();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.rbFloder = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImageKey = "pc.png";
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 98);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageKey = "pc.png";
            treeNode1.Name = "Node0";
            treeNode1.Tag = "pc";
            treeNode1.Text = "this Pc";
            treeNode1.ToolTipText = "this Pc";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.SelectedImageIndex = 8;
            this.treeView1.Size = new System.Drawing.Size(374, 571);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "excel.png");
            this.imageList1.Images.SetKeyName(1, "word.png");
            this.imageList1.Images.SetKeyName(2, "pdf.png");
            this.imageList1.Images.SetKeyName(3, "file.png");
            this.imageList1.Images.SetKeyName(4, "music.png");
            this.imageList1.Images.SetKeyName(5, "video.png");
            this.imageList1.Images.SetKeyName(6, "image.png");
            this.imageList1.Images.SetKeyName(7, "folder.png");
            this.imageList1.Images.SetKeyName(8, "pc.png");
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(463, 453);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 46);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(3, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(54, 23);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Path: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbExcel);
            this.panel1.Controls.Add(this.rbImage);
            this.panel1.Controls.Add(this.rbMusic);
            this.panel1.Controls.Add(this.rbVideo);
            this.panel1.Controls.Add(this.rbWord);
            this.panel1.Controls.Add(this.rbPdf);
            this.panel1.Controls.Add(this.rbFile);
            this.panel1.Controls.Add(this.rbFloder);
            this.panel1.Location = new System.Drawing.Point(422, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 239);
            this.panel1.TabIndex = 3;
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Location = new System.Drawing.Point(246, 34);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(101, 24);
            this.rbExcel.TabIndex = 7;
            this.rbExcel.TabStop = true;
            this.rbExcel.Tag = "excel";
            this.rbExcel.Text = "Excel File";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // rbImage
            // 
            this.rbImage.AutoSize = true;
            this.rbImage.Location = new System.Drawing.Point(246, 132);
            this.rbImage.Name = "rbImage";
            this.rbImage.Size = new System.Drawing.Size(79, 24);
            this.rbImage.TabIndex = 6;
            this.rbImage.TabStop = true;
            this.rbImage.Tag = "image";
            this.rbImage.Text = "Image";
            this.rbImage.UseVisualStyleBackColor = true;
            // 
            // rbMusic
            // 
            this.rbMusic.AutoSize = true;
            this.rbMusic.Location = new System.Drawing.Point(246, 83);
            this.rbMusic.Name = "rbMusic";
            this.rbMusic.Size = new System.Drawing.Size(75, 24);
            this.rbMusic.TabIndex = 5;
            this.rbMusic.TabStop = true;
            this.rbMusic.Tag = "music";
            this.rbMusic.Text = "Music";
            this.rbMusic.UseVisualStyleBackColor = true;
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(246, 181);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(75, 24);
            this.rbVideo.TabIndex = 4;
            this.rbVideo.TabStop = true;
            this.rbVideo.Tag = "video";
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = true;
            // 
            // rbWord
            // 
            this.rbWord.AutoSize = true;
            this.rbWord.Location = new System.Drawing.Point(38, 181);
            this.rbWord.Name = "rbWord";
            this.rbWord.Size = new System.Drawing.Size(101, 24);
            this.rbWord.TabIndex = 3;
            this.rbWord.TabStop = true;
            this.rbWord.Tag = "word";
            this.rbWord.Text = "Word File";
            this.rbWord.UseVisualStyleBackColor = true;
            // 
            // rbPdf
            // 
            this.rbPdf.AutoSize = true;
            this.rbPdf.Location = new System.Drawing.Point(38, 132);
            this.rbPdf.Name = "rbPdf";
            this.rbPdf.Size = new System.Drawing.Size(87, 24);
            this.rbPdf.TabIndex = 2;
            this.rbPdf.TabStop = true;
            this.rbPdf.Tag = "pdf";
            this.rbPdf.Text = "Pdf File";
            this.rbPdf.UseVisualStyleBackColor = true;
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Location = new System.Drawing.Point(38, 83);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(59, 24);
            this.rbFile.TabIndex = 1;
            this.rbFile.TabStop = true;
            this.rbFile.Tag = "file";
            this.rbFile.Text = "File";
            this.rbFile.UseVisualStyleBackColor = true;
            // 
            // rbFloder
            // 
            this.rbFloder.AutoSize = true;
            this.rbFloder.Location = new System.Drawing.Point(38, 34);
            this.rbFloder.Name = "rbFloder";
            this.rbFloder.Size = new System.Drawing.Size(79, 24);
            this.rbFloder.TabIndex = 0;
            this.rbFloder.TabStop = true;
            this.rbFloder.Tag = "folder";
            this.rbFloder.Text = "Folder";
            this.rbFloder.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(689, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add to Selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(463, 525);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Expand All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(689, 525);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 46);
            this.button4.TabIndex = 6;
            this.button4.Text = "Collaps All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(581, 605);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 46);
            this.button5.TabIndex = 7;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPath);
            this.panel2.Location = new System.Drawing.Point(12, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 41);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(941, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "🔍";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(603, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(436, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(515, 120);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(386, 41);
            this.tbName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 712);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.treeView1);
            this.Name = "TreeView";
            this.Text = "TreeView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbFloder;
        private System.Windows.Forms.RadioButton rbExcel;
        private System.Windows.Forms.RadioButton rbImage;
        private System.Windows.Forms.RadioButton rbMusic;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.RadioButton rbWord;
        private System.Windows.Forms.RadioButton rbPdf;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
    }
}
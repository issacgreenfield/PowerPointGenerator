namespace PowerPointGenerator
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtSlide = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.pctb1 = new System.Windows.Forms.PictureBox();
            this.lblVerifySelection = new System.Windows.Forms.Label();
            this.pctb2 = new System.Windows.Forms.PictureBox();
            this.pctb3 = new System.Windows.Forms.PictureBox();
            this.pctb4 = new System.Windows.Forms.PictureBox();
            this.pctb5 = new System.Windows.Forms.PictureBox();
            this.pctb10 = new System.Windows.Forms.PictureBox();
            this.pctb9 = new System.Windows.Forms.PictureBox();
            this.pctb8 = new System.Windows.Forms.PictureBox();
            this.pctb7 = new System.Windows.Forms.PictureBox();
            this.pctb6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slide Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slide Text";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 97);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(402, 31);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtSlide
            // 
            this.txtSlide.Location = new System.Drawing.Point(13, 183);
            this.txtSlide.Multiline = true;
            this.txtSlide.Name = "txtSlide";
            this.txtSlide.Size = new System.Drawing.Size(886, 200);
            this.txtSlide.TabIndex = 3;
            this.txtSlide.TextChanged += new System.EventHandler(this.txtSlide_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(970, 323);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(191, 60);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search Images";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Aqua;
            this.btnCreate.Location = new System.Drawing.Point(1021, 757);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(191, 60);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create Slide";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.875F);
            this.label3.Location = new System.Drawing.Point(347, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(619, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "PowerPoint Slide Generator";
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Location = new System.Drawing.Point(936, 183);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(87, 29);
            this.cbBold.TabIndex = 8;
            this.cbBold.Text = "Bold";
            this.cbBold.UseVisualStyleBackColor = true;
            // 
            // pctb1
            // 
            this.pctb1.Location = new System.Drawing.Point(17, 404);
            this.pctb1.Name = "pctb1";
            this.pctb1.Size = new System.Drawing.Size(225, 155);
            this.pctb1.TabIndex = 9;
            this.pctb1.TabStop = false;
            this.pctb1.Click += new System.EventHandler(this.pctb1_Click);
            // 
            // lblVerifySelection
            // 
            this.lblVerifySelection.AutoSize = true;
            this.lblVerifySelection.Location = new System.Drawing.Point(24, 775);
            this.lblVerifySelection.Name = "lblVerifySelection";
            this.lblVerifySelection.Size = new System.Drawing.Size(0, 25);
            this.lblVerifySelection.TabIndex = 12;
            // 
            // pctb2
            // 
            this.pctb2.Location = new System.Drawing.Point(260, 404);
            this.pctb2.Name = "pctb2";
            this.pctb2.Size = new System.Drawing.Size(225, 155);
            this.pctb2.TabIndex = 13;
            this.pctb2.TabStop = false;
            this.pctb2.Click += new System.EventHandler(this.pctb2_Click);
            // 
            // pctb3
            // 
            this.pctb3.Location = new System.Drawing.Point(502, 404);
            this.pctb3.Name = "pctb3";
            this.pctb3.Size = new System.Drawing.Size(225, 155);
            this.pctb3.TabIndex = 14;
            this.pctb3.TabStop = false;
            this.pctb3.Click += new System.EventHandler(this.pctb3_Click);
            // 
            // pctb4
            // 
            this.pctb4.Location = new System.Drawing.Point(746, 404);
            this.pctb4.Name = "pctb4";
            this.pctb4.Size = new System.Drawing.Size(225, 155);
            this.pctb4.TabIndex = 15;
            this.pctb4.TabStop = false;
            this.pctb4.Click += new System.EventHandler(this.pctb4_Click);
            // 
            // pctb5
            // 
            this.pctb5.Location = new System.Drawing.Point(987, 404);
            this.pctb5.Name = "pctb5";
            this.pctb5.Size = new System.Drawing.Size(225, 155);
            this.pctb5.TabIndex = 16;
            this.pctb5.TabStop = false;
            this.pctb5.Click += new System.EventHandler(this.pctb5_Click);
            // 
            // pctb10
            // 
            this.pctb10.Location = new System.Drawing.Point(987, 579);
            this.pctb10.Name = "pctb10";
            this.pctb10.Size = new System.Drawing.Size(225, 155);
            this.pctb10.TabIndex = 21;
            this.pctb10.TabStop = false;
            this.pctb10.Click += new System.EventHandler(this.pctb10_Click);
            // 
            // pctb9
            // 
            this.pctb9.Location = new System.Drawing.Point(746, 578);
            this.pctb9.Name = "pctb9";
            this.pctb9.Size = new System.Drawing.Size(225, 155);
            this.pctb9.TabIndex = 20;
            this.pctb9.TabStop = false;
            this.pctb9.Click += new System.EventHandler(this.pctb9_Click);
            // 
            // pctb8
            // 
            this.pctb8.Location = new System.Drawing.Point(502, 578);
            this.pctb8.Name = "pctb8";
            this.pctb8.Size = new System.Drawing.Size(225, 155);
            this.pctb8.TabIndex = 19;
            this.pctb8.TabStop = false;
            this.pctb8.Click += new System.EventHandler(this.pctb8_Click);
            // 
            // pctb7
            // 
            this.pctb7.Location = new System.Drawing.Point(260, 578);
            this.pctb7.Name = "pctb7";
            this.pctb7.Size = new System.Drawing.Size(225, 155);
            this.pctb7.TabIndex = 18;
            this.pctb7.TabStop = false;
            this.pctb7.Click += new System.EventHandler(this.pctb7_Click);
            // 
            // pctb6
            // 
            this.pctb6.Location = new System.Drawing.Point(17, 578);
            this.pctb6.Name = "pctb6";
            this.pctb6.Size = new System.Drawing.Size(225, 155);
            this.pctb6.TabIndex = 17;
            this.pctb6.TabStop = false;
            this.pctb6.Click += new System.EventHandler(this.pctb6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 881);
            this.Controls.Add(this.pctb10);
            this.Controls.Add(this.pctb9);
            this.Controls.Add(this.pctb8);
            this.Controls.Add(this.pctb7);
            this.Controls.Add(this.pctb6);
            this.Controls.Add(this.pctb5);
            this.Controls.Add(this.pctb4);
            this.Controls.Add(this.pctb3);
            this.Controls.Add(this.pctb2);
            this.Controls.Add(this.lblVerifySelection);
            this.Controls.Add(this.pctb1);
            this.Controls.Add(this.cbBold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSlide);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtSlide;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbBold;
        private System.Windows.Forms.PictureBox pctb1;
        private System.Windows.Forms.Label lblVerifySelection;
        private System.Windows.Forms.PictureBox pctb2;
        private System.Windows.Forms.PictureBox pctb3;
        private System.Windows.Forms.PictureBox pctb4;
        private System.Windows.Forms.PictureBox pctb5;
        private System.Windows.Forms.PictureBox pctb10;
        private System.Windows.Forms.PictureBox pctb9;
        private System.Windows.Forms.PictureBox pctb8;
        private System.Windows.Forms.PictureBox pctb7;
        private System.Windows.Forms.PictureBox pctb6;
    }
}


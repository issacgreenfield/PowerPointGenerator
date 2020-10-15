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
            this.pctb2 = new System.Windows.Forms.PictureBox();
            this.pctb3 = new System.Windows.Forms.PictureBox();
            this.lblVerifySelection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb3)).BeginInit();
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
            this.txtSlide.Size = new System.Drawing.Size(886, 273);
            this.txtSlide.TabIndex = 3;
            this.txtSlide.TextChanged += new System.EventHandler(this.txtSlide_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(936, 396);
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
            this.btnCreate.Location = new System.Drawing.Point(936, 810);
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
            this.pctb1.Location = new System.Drawing.Point(12, 508);
            this.pctb1.Name = "pctb1";
            this.pctb1.Size = new System.Drawing.Size(373, 250);
            this.pctb1.TabIndex = 9;
            this.pctb1.TabStop = false;
            // 
            // pctb2
            // 
            this.pctb2.Location = new System.Drawing.Point(391, 508);
            this.pctb2.Name = "pctb2";
            this.pctb2.Size = new System.Drawing.Size(370, 250);
            this.pctb2.TabIndex = 10;
            this.pctb2.TabStop = false;
            // 
            // pctb3
            // 
            this.pctb3.Location = new System.Drawing.Point(767, 508);
            this.pctb3.Name = "pctb3";
            this.pctb3.Size = new System.Drawing.Size(373, 250);
            this.pctb3.TabIndex = 11;
            this.pctb3.TabStop = false;
            // 
            // lblVerifySelection
            // 
            this.lblVerifySelection.AutoSize = true;
            this.lblVerifySelection.Location = new System.Drawing.Point(7, 771);
            this.lblVerifySelection.Name = "lblVerifySelection";
            this.lblVerifySelection.Size = new System.Drawing.Size(0, 25);
            this.lblVerifySelection.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 882);
            this.Controls.Add(this.lblVerifySelection);
            this.Controls.Add(this.pctb3);
            this.Controls.Add(this.pctb2);
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
        private System.Windows.Forms.PictureBox pctb2;
        private System.Windows.Forms.PictureBox pctb3;
        private System.Windows.Forms.Label lblVerifySelection;
    }
}


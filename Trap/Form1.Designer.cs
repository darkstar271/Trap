namespace Trap
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
            this.btPlay = new System.Windows.Forms.Button();
            this.btNewGame = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.txtBlock = new System.Windows.Forms.TextBox();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(954, 416);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 46);
            this.btPlay.TabIndex = 1;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btNewGame
            // 
            this.btNewGame.Location = new System.Drawing.Point(954, 468);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(75, 46);
            this.btNewGame.TabIndex = 2;
            this.btNewGame.Text = "NewGame";
            this.btNewGame.UseVisualStyleBackColor = true;
            this.btNewGame.Click += new System.EventHandler(this.btNewGame_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(954, 520);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 46);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Fire";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(954, 572);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 46);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // txtBlock
            // 
            this.txtBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlock.Location = new System.Drawing.Point(908, 577);
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(40, 31);
            this.txtBlock.TabIndex = 6;
            this.txtBlock.TextChanged += new System.EventHandler(this.txtBlock_TextChanged);
            // 
            // txtOpen
            // 
            this.txtOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpen.Location = new System.Drawing.Point(908, 525);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(40, 31);
            this.txtOpen.TabIndex = 7;
            this.txtOpen.TextChanged += new System.EventHandler(this.txtOpen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(860, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Spins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(853, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Blocks";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trap.Properties.Resources.Model_629left;
            this.pictureBox1.Location = new System.Drawing.Point(204, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pic3
            // 
            this.pic3.Image = global::Trap.Properties.Resources.Model_629;
            this.pic3.Location = new System.Drawing.Point(204, 0);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(335, 179);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 8;
            this.pic3.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::Trap.Properties.Resources.Head;
            this.pic2.Location = new System.Drawing.Point(775, 0);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(275, 179);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 5;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic1.Image = global::Trap.Properties.Resources.dirtyHurry;
            this.pic1.Location = new System.Drawing.Point(0, 0);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(1050, 675);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.txtOpen);
            this.Controls.Add(this.txtBlock);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btNewGame);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.pic1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btNewGame;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.TextBox txtBlock;
        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


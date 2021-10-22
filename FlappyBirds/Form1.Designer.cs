
namespace FlappyBirds
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
            this.components = new System.ComponentModel.Container();
            this.pbPipe1 = new System.Windows.Forms.PictureBox();
            this.pbPipe2 = new System.Windows.Forms.PictureBox();
            this.pbBirds = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbPipe4 = new System.Windows.Forms.PictureBox();
            this.pbPipe3 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBirds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPipe1
            // 
            this.pbPipe1.Image = global::FlappyBirds.Properties.Resources.pipe;
            this.pbPipe1.Location = new System.Drawing.Point(402, 379);
            this.pbPipe1.Name = "pbPipe1";
            this.pbPipe1.Size = new System.Drawing.Size(100, 204);
            this.pbPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe1.TabIndex = 0;
            this.pbPipe1.TabStop = false;
            // 
            // pbPipe2
            // 
            this.pbPipe2.Image = global::FlappyBirds.Properties.Resources.pipedown;
            this.pbPipe2.Location = new System.Drawing.Point(568, 1);
            this.pbPipe2.Name = "pbPipe2";
            this.pbPipe2.Size = new System.Drawing.Size(100, 167);
            this.pbPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe2.TabIndex = 1;
            this.pbPipe2.TabStop = false;
            // 
            // pbBirds
            // 
            this.pbBirds.Image = global::FlappyBirds.Properties.Resources.birdnew;
            this.pbBirds.Location = new System.Drawing.Point(12, 186);
            this.pbBirds.Name = "pbBirds";
            this.pbBirds.Size = new System.Drawing.Size(100, 80);
            this.pbBirds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBirds.TabIndex = 2;
            this.pbBirds.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGround.Image = global::FlappyBirds.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(-3, 575);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(1071, 60);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 3;
            this.pbGround.TabStop = false;
            // 
            // pbPipe4
            // 
            this.pbPipe4.Image = global::FlappyBirds.Properties.Resources.pipedown;
            this.pbPipe4.Location = new System.Drawing.Point(845, 1);
            this.pbPipe4.Name = "pbPipe4";
            this.pbPipe4.Size = new System.Drawing.Size(100, 265);
            this.pbPipe4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe4.TabIndex = 1;
            this.pbPipe4.TabStop = false;
            // 
            // pbPipe3
            // 
            this.pbPipe3.Image = global::FlappyBirds.Properties.Resources.pipe;
            this.pbPipe3.Location = new System.Drawing.Point(713, 418);
            this.pbPipe3.Name = "pbPipe3";
            this.pbPipe3.Size = new System.Drawing.Size(100, 165);
            this.pbPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe3.TabIndex = 0;
            this.pbPipe3.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(9, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(133, 39);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 634);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbBirds);
            this.Controls.Add(this.pbPipe4);
            this.Controls.Add(this.pbPipe2);
            this.Controls.Add(this.pbPipe3);
            this.Controls.Add(this.pbPipe1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBirds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPipe1;
        private System.Windows.Forms.PictureBox pbPipe2;
        private System.Windows.Forms.PictureBox pbBirds;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbPipe4;
        private System.Windows.Forms.PictureBox pbPipe3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrGame;
    }
}


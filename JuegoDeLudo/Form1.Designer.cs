namespace JuegoDeLudo
{
    partial class Form1
    {
        private PictureBox redPiece1;
        private PictureBox backgroundImage;
        private System.Windows.Forms.Label lblCurrentPlayer;


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnTirarDado = new Button();
            lblDadoValor = new Label();
            rojoCasaBase = new PictureBox();
            rojoPosicionInicio = new PictureBox();
            azulCasaBase = new PictureBox();
            azulPosicionInicio = new PictureBox();
            verdeCasaBase = new PictureBox();
            verdePosicionInicio = new PictureBox();
            amarilloCasaBase = new PictureBox();
            amarilloPosicionInicio = new PictureBox();
            pictureBox1 = new PictureBox();
            redPiece1 = new PictureBox();
            backgroundImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)rojoCasaBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rojoPosicionInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)azulCasaBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)azulPosicionInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)verdeCasaBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)verdePosicionInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amarilloCasaBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amarilloPosicionInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redPiece1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backgroundImage).BeginInit();
            SuspendLayout();
            // 
            // btnTirarDado
            // 
            btnTirarDado.Location = new Point(14, 14);
            btnTirarDado.Margin = new Padding(4, 3, 4, 3);
            btnTirarDado.Name = "btnTirarDado";
            btnTirarDado.Size = new Size(130, 27);
            btnTirarDado.TabIndex = 0;
            btnTirarDado.Text = "TIRAR DADO";
            btnTirarDado.UseVisualStyleBackColor = true;
            btnTirarDado.Click += btnTirarDado_Click;
            // 
            // lblDadoValor
            // 
            lblDadoValor.AutoSize = true;
            lblDadoValor.Location = new Point(150, 18);
            lblDadoValor.Margin = new Padding(4, 0, 4, 0);
            lblDadoValor.Name = "lblDadoValor";
            lblDadoValor.Size = new Size(41, 15);
            lblDadoValor.TabIndex = 1;
            lblDadoValor.Text = "Dado: ";
            // 
            // rojoCasaBase
            // 
            rojoCasaBase.BackColor = Color.Red;
            rojoCasaBase.Location = new Point(50, 50);
            rojoCasaBase.Margin = new Padding(4, 3, 4, 3);
            rojoCasaBase.Name = "rojoCasaBase";
            rojoCasaBase.Size = new Size(117, 115);
            rojoCasaBase.TabIndex = 2;
            rojoCasaBase.TabStop = false;
            // 
            // rojoPosicionInicio
            // 
            rojoPosicionInicio.BackColor = Color.Red;
            rojoPosicionInicio.Location = new Point(200, 50);
            rojoPosicionInicio.Margin = new Padding(4, 3, 4, 3);
            rojoPosicionInicio.Name = "rojoPosicionInicio";
            rojoPosicionInicio.Size = new Size(29, 29);
            rojoPosicionInicio.TabIndex = 3;
            rojoPosicionInicio.TabStop = false;
            // 
            // azulCasaBase
            // 
            azulCasaBase.BackColor = Color.Blue;
            azulCasaBase.Location = new Point(528, 50);
            azulCasaBase.Margin = new Padding(4, 3, 4, 3);
            azulCasaBase.Name = "azulCasaBase";
            azulCasaBase.Size = new Size(117, 115);
            azulCasaBase.TabIndex = 2;
            azulCasaBase.TabStop = false;
            // 
            // azulPosicionInicio
            // 
            azulPosicionInicio.BackColor = Color.Blue;
            azulPosicionInicio.Location = new Point(462, 50);
            azulPosicionInicio.Margin = new Padding(4, 3, 4, 3);
            azulPosicionInicio.Name = "azulPosicionInicio";
            azulPosicionInicio.Size = new Size(29, 29);
            azulPosicionInicio.TabIndex = 3;
            azulPosicionInicio.TabStop = false;
            // 
            // verdeCasaBase
            // 
            verdeCasaBase.BackColor = Color.Green;
            verdeCasaBase.Location = new Point(50, 385);
            verdeCasaBase.Margin = new Padding(4, 3, 4, 3);
            verdeCasaBase.Name = "verdeCasaBase";
            verdeCasaBase.Size = new Size(117, 115);
            verdeCasaBase.TabIndex = 4;
            verdeCasaBase.TabStop = false;
            // 
            // verdePosicionInicio
            // 
            verdePosicionInicio.BackColor = Color.Green;
            verdePosicionInicio.Location = new Point(200, 471);
            verdePosicionInicio.Margin = new Padding(4, 3, 4, 3);
            verdePosicionInicio.Name = "verdePosicionInicio";
            verdePosicionInicio.Size = new Size(29, 29);
            verdePosicionInicio.TabIndex = 5;
            verdePosicionInicio.TabStop = false;
            // 
            // amarilloCasaBase
            // 
            amarilloCasaBase.BackColor = Color.Yellow;
            amarilloCasaBase.Location = new Point(528, 385);
            amarilloCasaBase.Margin = new Padding(4, 3, 4, 3);
            amarilloCasaBase.Name = "amarilloCasaBase";
            amarilloCasaBase.Size = new Size(117, 115);
            amarilloCasaBase.TabIndex = 6;
            amarilloCasaBase.TabStop = false;
            // 
            // amarilloPosicionInicio
            // 
            amarilloPosicionInicio.BackColor = Color.Yellow;
            amarilloPosicionInicio.Location = new Point(462, 471);
            amarilloPosicionInicio.Margin = new Padding(4, 3, 4, 3);
            amarilloPosicionInicio.Name = "amarilloPosicionInicio";
            amarilloPosicionInicio.Size = new Size(29, 29);
            amarilloPosicionInicio.TabIndex = 7;
            amarilloPosicionInicio.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(73, 242);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 29);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // redPiece1
            // 
            redPiece1.BackColor = Color.Red;
            redPiece1.Location = new Point(60, 60);
            redPiece1.Name = "redPiece1";
            redPiece1.Size = new Size(20, 20);
            redPiece1.TabIndex = 4;
            redPiece1.TabStop = false;
            // 
            // backgroundImage
            // 
            backgroundImage.BackgroundImage = (Image)resources.GetObject("backgroundImage.BackgroundImage");
            backgroundImage.Location = new Point(0, 0);
            backgroundImage.Name = "backgroundImage";
            backgroundImage.Size = new Size(600, 600);
            backgroundImage.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundImage.TabIndex = 5;
            backgroundImage.TabStop = false;

            // Current player label
            lblCurrentPlayer = new System.Windows.Forms.Label();
            lblCurrentPlayer.AutoSize = true;
            lblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCurrentPlayer.Location = new System.Drawing.Point(620, 50); 
            lblCurrentPlayer.Name = "lblCurrentPlayer";
            lblCurrentPlayer.Size = new System.Drawing.Size(0, 20);
            lblCurrentPlayer.TabIndex = 5;
            this.Controls.Add(lblCurrentPlayer);


            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 661);
            Controls.Add(redPiece1);
            Controls.Add(pictureBox1);
            Controls.Add(amarilloCasaBase);
            Controls.Add(amarilloPosicionInicio);
            Controls.Add(verdeCasaBase);
            Controls.Add(verdePosicionInicio);
            Controls.Add(rojoCasaBase);
            Controls.Add(rojoPosicionInicio);
            Controls.Add(azulCasaBase);
            Controls.Add(azulPosicionInicio);
            Controls.Add(lblDadoValor);
            Controls.Add(btnTirarDado);
            Controls.Add(backgroundImage);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Ludo";
            ((System.ComponentModel.ISupportInitialize)rojoCasaBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)rojoPosicionInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)azulCasaBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)azulPosicionInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)verdeCasaBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)verdePosicionInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)amarilloCasaBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)amarilloPosicionInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)redPiece1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backgroundImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTirarDado;
        private Label lblDadoValor;
        private PictureBox rojoCasaBase;
        private PictureBox rojoPosicionInicio;
        private PictureBox azulCasaBase;
        private PictureBox azulPosicionInicio;
        private PictureBox verdeCasaBase;
        private PictureBox verdePosicionInicio;
        private PictureBox amarilloCasaBase;
        private PictureBox amarilloPosicionInicio;
        private PictureBox pictureBox1;
    }
}
namespace Quizguerra.Quiz
{
    partial class Form4
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
            this.inicio = new System.Windows.Forms.Button();
            this.barra = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // inicio
            // 
            this.inicio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inicio.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inicio.Location = new System.Drawing.Point(73, 447);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(148, 47);
            this.inicio.TabIndex = 0;
            this.inicio.Text = "Iniciar";
            this.inicio.UseVisualStyleBackColor = false;
            this.inicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // barra
            // 
            this.barra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.barra.Location = new System.Drawing.Point(261, 463);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(425, 31);
            this.barra.TabIndex = 1;
            this.barra.Click += new System.EventHandler(this.barra_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 9000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quizguerra.Quiz.Properties.Resources.primeira_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 556);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.inicio);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.ProgressBar barra;
        private System.Windows.Forms.Timer timer1;
    }
}
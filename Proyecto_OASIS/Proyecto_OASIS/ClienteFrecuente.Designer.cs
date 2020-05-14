namespace Proyecto_OASIS
{
    partial class ClienteFrecuente
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbhora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("BigNoodleTitling", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(144, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1240, 216);
            this.label2.TabIndex = 9;
            this.label2.Text = "NOMBRE DEL CLIENTE";
            // 
            // lbhora
            // 
            this.lbhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbhora.AutoSize = true;
            this.lbhora.BackColor = System.Drawing.Color.Transparent;
            this.lbhora.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.lbhora.Location = new System.Drawing.Point(947, 9);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(130, 70);
            this.lbhora.TabIndex = 12;
            this.lbhora.Text = "HORA";
            this.lbhora.Click += new System.EventHandler(this.Lbhora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(12, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 70);
            this.label1.TabIndex = 11;
            this.label1.Text = "SNACK OASIS";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.button1.Location = new System.Drawing.Point(926, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 113);
            this.button1.TabIndex = 20;
            this.button1.Text = "INICIAR VENTA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textbox.Font = new System.Drawing.Font("BigNoodleTitling", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.name_textbox.Location = new System.Drawing.Point(109, 338);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(1293, 221);
            this.name_textbox.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.button2.Location = new System.Drawing.Point(358, 670);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 113);
            this.button2.TabIndex = 22;
            this.button2.Text = "REGRESAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ClienteFrecuente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_OASIS.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ClienteFrecuente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteFrecuente";
            this.Load += new System.EventHandler(this.ClienteFrecuente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button button2;
    }
}
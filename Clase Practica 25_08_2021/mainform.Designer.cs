
namespace Clase_Practica_25_08_2021
{
    partial class mainform
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Mensaje = new System.Windows.Forms.Button();
            this.button_Dialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abrir Form 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Abrir Form 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Mensaje
            // 
            this.button_Mensaje.Location = new System.Drawing.Point(267, 158);
            this.button_Mensaje.Name = "button_Mensaje";
            this.button_Mensaje.Size = new System.Drawing.Size(75, 23);
            this.button_Mensaje.TabIndex = 2;
            this.button_Mensaje.Text = "Mensaje";
            this.button_Mensaje.UseVisualStyleBackColor = true;
            this.button_Mensaje.Click += new System.EventHandler(this.button_Mensaje_Click);
            // 
            // button_Dialog
            // 
            this.button_Dialog.Location = new System.Drawing.Point(267, 229);
            this.button_Dialog.Name = "button_Dialog";
            this.button_Dialog.Size = new System.Drawing.Size(75, 23);
            this.button_Dialog.TabIndex = 3;
            this.button_Dialog.Text = "Abrir";
            this.button_Dialog.UseVisualStyleBackColor = true;
            this.button_Dialog.Click += new System.EventHandler(this.button_Dialog_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Dialog);
            this.Controls.Add(this.button_Mensaje);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "mainform";
            this.Text = "mainform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Mensaje;
        private System.Windows.Forms.Button button_Dialog;
    }
}
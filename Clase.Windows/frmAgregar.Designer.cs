
namespace Clase.Windows
{
    partial class frmAgregar
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
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.RadioLabel = new System.Windows.Forms.Label();
            this.TrazoLabel = new System.Windows.Forms.Label();
            this.ColoresLabel = new System.Windows.Forms.Label();
            this.AgregarTextBox = new System.Windows.Forms.TextBox();
            this.RayaRadioButton = new System.Windows.Forms.RadioButton();
            this.ContinuoRadioButton = new System.Windows.Forms.RadioButton();
            this.PuntosRadioButton = new System.Windows.Forms.RadioButton();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ColorComboBox.Location = new System.Drawing.Point(115, 88);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorComboBox.TabIndex = 0;
            // 
            // RadioLabel
            // 
            this.RadioLabel.AutoSize = true;
            this.RadioLabel.Location = new System.Drawing.Point(13, 13);
            this.RadioLabel.Name = "RadioLabel";
            this.RadioLabel.Size = new System.Drawing.Size(84, 13);
            this.RadioLabel.TabIndex = 1;
            this.RadioLabel.Text = "Ingrese el Radio";
            // 
            // TrazoLabel
            // 
            this.TrazoLabel.AutoSize = true;
            this.TrazoLabel.Location = new System.Drawing.Point(13, 39);
            this.TrazoLabel.Name = "TrazoLabel";
            this.TrazoLabel.Size = new System.Drawing.Size(96, 13);
            this.TrazoLabel.TabIndex = 1;
            this.TrazoLabel.Text = "Trazos Disponibles";
            // 
            // ColoresLabel
            // 
            this.ColoresLabel.AutoSize = true;
            this.ColoresLabel.Location = new System.Drawing.Point(13, 91);
            this.ColoresLabel.Name = "ColoresLabel";
            this.ColoresLabel.Size = new System.Drawing.Size(99, 13);
            this.ColoresLabel.TabIndex = 1;
            this.ColoresLabel.Text = "Colores Disponibles";
            // 
            // AgregarTextBox
            // 
            this.AgregarTextBox.Location = new System.Drawing.Point(118, 5);
            this.AgregarTextBox.Name = "AgregarTextBox";
            this.AgregarTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgregarTextBox.TabIndex = 2;
            // 
            // RayaRadioButton
            // 
            this.RayaRadioButton.AutoSize = true;
            this.RayaRadioButton.Location = new System.Drawing.Point(118, 39);
            this.RayaRadioButton.Name = "RayaRadioButton";
            this.RayaRadioButton.Size = new System.Drawing.Size(50, 17);
            this.RayaRadioButton.TabIndex = 3;
            this.RayaRadioButton.TabStop = true;
            this.RayaRadioButton.Text = "Raya";
            this.RayaRadioButton.UseVisualStyleBackColor = true;
            // 
            // ContinuoRadioButton
            // 
            this.ContinuoRadioButton.AutoSize = true;
            this.ContinuoRadioButton.Location = new System.Drawing.Point(209, 37);
            this.ContinuoRadioButton.Name = "ContinuoRadioButton";
            this.ContinuoRadioButton.Size = new System.Drawing.Size(67, 17);
            this.ContinuoRadioButton.TabIndex = 3;
            this.ContinuoRadioButton.TabStop = true;
            this.ContinuoRadioButton.Text = "Continuo";
            this.ContinuoRadioButton.UseVisualStyleBackColor = true;
            // 
            // PuntosRadioButton
            // 
            this.PuntosRadioButton.AutoSize = true;
            this.PuntosRadioButton.Location = new System.Drawing.Point(118, 62);
            this.PuntosRadioButton.Name = "PuntosRadioButton";
            this.PuntosRadioButton.Size = new System.Drawing.Size(58, 17);
            this.PuntosRadioButton.TabIndex = 3;
            this.PuntosRadioButton.TabStop = true;
            this.PuntosRadioButton.Text = "Puntos";
            this.PuntosRadioButton.UseVisualStyleBackColor = true;
            this.PuntosRadioButton.CheckedChanged += new System.EventHandler(this.AzulRadioButton_CheckedChanged);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(16, 148);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(128, 52);
            this.AgregarButton.TabIndex = 4;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 252);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.PuntosRadioButton);
            this.Controls.Add(this.ContinuoRadioButton);
            this.Controls.Add(this.RayaRadioButton);
            this.Controls.Add(this.AgregarTextBox);
            this.Controls.Add(this.ColoresLabel);
            this.Controls.Add(this.TrazoLabel);
            this.Controls.Add(this.RadioLabel);
            this.Controls.Add(this.ColorComboBox);
            this.Name = "frmAgregar";
            this.Text = "AgregarEsfera";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label RadioLabel;
        private System.Windows.Forms.Label TrazoLabel;
        private System.Windows.Forms.Label ColoresLabel;
        private System.Windows.Forms.TextBox AgregarTextBox;
        private System.Windows.Forms.RadioButton RayaRadioButton;
        private System.Windows.Forms.RadioButton ContinuoRadioButton;
        private System.Windows.Forms.RadioButton PuntosRadioButton;
        private System.Windows.Forms.Button AgregarButton;
    }
}
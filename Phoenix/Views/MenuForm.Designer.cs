namespace Phoenix.Views
{
    partial class MenuForm
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
            this._buttonEnrollees = new System.Windows.Forms.Button();
            this._buttonSpecialties = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonEnrollees
            // 
            this._buttonEnrollees.Location = new System.Drawing.Point(273, 150);
            this._buttonEnrollees.Name = "_buttonEnrollees";
            this._buttonEnrollees.Size = new System.Drawing.Size(136, 30);
            this._buttonEnrollees.TabIndex = 0;
            this._buttonEnrollees.Text = "Абитуриенты";
            this._buttonEnrollees.UseVisualStyleBackColor = true;
            // 
            // _buttonSpecialties
            // 
            this._buttonSpecialties.Location = new System.Drawing.Point(273, 186);
            this._buttonSpecialties.Name = "_buttonSpecialties";
            this._buttonSpecialties.Size = new System.Drawing.Size(135, 50);
            this._buttonSpecialties.TabIndex = 1;
            this._buttonSpecialties.Text = "Специальности/професии";
            this._buttonSpecialties.UseVisualStyleBackColor = true;
            this._buttonSpecialties.Click += new System.EventHandler(this.ButtonSpecialties_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this._buttonSpecialties);
            this.Controls.Add(this._buttonEnrollees);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuForm";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private Button _buttonEnrollees;
        private Button _buttonSpecialties;
    }
}
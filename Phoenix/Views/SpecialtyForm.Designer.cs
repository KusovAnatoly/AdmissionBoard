namespace Phoenix.Views
{
    partial class SpecialtyForm
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
            this._dataGridViewSpecialties = new System.Windows.Forms.DataGridView();
            this.groupBoxElements = new System.Windows.Forms.GroupBox();
            this._textBoxSearch = new System.Windows.Forms.TextBox();
            this._panelAddEdit = new System.Windows.Forms.Panel();
            this._radioButtonSpecialty = new System.Windows.Forms.RadioButton();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this._radioButtonProfession = new System.Windows.Forms.RadioButton();
            this._panelSaveCancel = new System.Windows.Forms.Panel();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonDelete = new System.Windows.Forms.Button();
            this._buttonEdit = new System.Windows.Forms.Button();
            this._buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewSpecialties)).BeginInit();
            this.groupBoxElements.SuspendLayout();
            this._panelAddEdit.SuspendLayout();
            this._panelSaveCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dataGridViewSpecialties
            // 
            this._dataGridViewSpecialties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGridViewSpecialties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewSpecialties.Location = new System.Drawing.Point(12, 138);
            this._dataGridViewSpecialties.Name = "_dataGridViewSpecialties";
            this._dataGridViewSpecialties.RowTemplate.Height = 25;
            this._dataGridViewSpecialties.Size = new System.Drawing.Size(1040, 531);
            this._dataGridViewSpecialties.TabIndex = 0;
            // 
            // groupBoxElements
            // 
            this.groupBoxElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxElements.Controls.Add(this._textBoxSearch);
            this.groupBoxElements.Controls.Add(this._panelAddEdit);
            this.groupBoxElements.Controls.Add(this._panelSaveCancel);
            this.groupBoxElements.Controls.Add(this._buttonDelete);
            this.groupBoxElements.Controls.Add(this._buttonEdit);
            this.groupBoxElements.Controls.Add(this._buttonAdd);
            this.groupBoxElements.Location = new System.Drawing.Point(12, 12);
            this.groupBoxElements.Name = "groupBoxElements";
            this.groupBoxElements.Size = new System.Drawing.Size(1040, 120);
            this.groupBoxElements.TabIndex = 1;
            this.groupBoxElements.TabStop = false;
            this.groupBoxElements.Text = "Специальность";
            // 
            // _textBoxSearch
            // 
            this._textBoxSearch.Location = new System.Drawing.Point(374, 91);
            this._textBoxSearch.Name = "_textBoxSearch";
            this._textBoxSearch.PlaceholderText = "Поиск...";
            this._textBoxSearch.Size = new System.Drawing.Size(290, 23);
            this._textBoxSearch.TabIndex = 7;
            this._textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // _panelAddEdit
            // 
            this._panelAddEdit.Controls.Add(this._radioButtonSpecialty);
            this._panelAddEdit.Controls.Add(this._textBoxName);
            this._panelAddEdit.Controls.Add(this._radioButtonProfession);
            this._panelAddEdit.Location = new System.Drawing.Point(6, 14);
            this._panelAddEdit.Name = "_panelAddEdit";
            this._panelAddEdit.Size = new System.Drawing.Size(460, 100);
            this._panelAddEdit.TabIndex = 7;
            this._panelAddEdit.Visible = false;
            // 
            // _radioButtonSpecialty
            // 
            this._radioButtonSpecialty.AutoSize = true;
            this._radioButtonSpecialty.Location = new System.Drawing.Point(3, 63);
            this._radioButtonSpecialty.Name = "_radioButtonSpecialty";
            this._radioButtonSpecialty.Size = new System.Drawing.Size(322, 19);
            this._radioButtonSpecialty.TabIndex = 6;
            this._radioButtonSpecialty.Text = "Программа подготовки специалистов среднего звена";
            this._radioButtonSpecialty.UseVisualStyleBackColor = true;
            // 
            // _textBoxName
            // 
            this._textBoxName.Location = new System.Drawing.Point(3, 9);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.PlaceholderText = "Наименование";
            this._textBoxName.Size = new System.Drawing.Size(250, 23);
            this._textBoxName.TabIndex = 4;
            // 
            // _radioButtonProfession
            // 
            this._radioButtonProfession.AutoSize = true;
            this._radioButtonProfession.Checked = true;
            this._radioButtonProfession.Location = new System.Drawing.Point(3, 38);
            this._radioButtonProfession.Name = "_radioButtonProfession";
            this._radioButtonProfession.Size = new System.Drawing.Size(397, 19);
            this._radioButtonProfession.TabIndex = 5;
            this._radioButtonProfession.TabStop = true;
            this._radioButtonProfession.Text = "Программа подготовки квалифицированных рабочих и служащих";
            this._radioButtonProfession.UseVisualStyleBackColor = true;
            // 
            // _panelSaveCancel
            // 
            this._panelSaveCancel.Controls.Add(this._buttonCancel);
            this._panelSaveCancel.Controls.Add(this._buttonSave);
            this._panelSaveCancel.Location = new System.Drawing.Point(834, 14);
            this._panelSaveCancel.Name = "_panelSaveCancel";
            this._panelSaveCancel.Size = new System.Drawing.Size(200, 100);
            this._panelSaveCancel.TabIndex = 3;
            this._panelSaveCancel.Visible = false;
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(122, 53);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 5;
            this._buttonCancel.Text = "Отменить";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(122, 24);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 4;
            this._buttonSave.Text = "Сохранить";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // _buttonDelete
            // 
            this._buttonDelete.Enabled = false;
            this._buttonDelete.Location = new System.Drawing.Point(959, 80);
            this._buttonDelete.Name = "_buttonDelete";
            this._buttonDelete.Size = new System.Drawing.Size(75, 23);
            this._buttonDelete.TabIndex = 2;
            this._buttonDelete.Text = "Удалить";
            this._buttonDelete.UseVisualStyleBackColor = true;
            this._buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // _buttonEdit
            // 
            this._buttonEdit.Enabled = false;
            this._buttonEdit.Location = new System.Drawing.Point(959, 51);
            this._buttonEdit.Name = "_buttonEdit";
            this._buttonEdit.Size = new System.Drawing.Size(75, 23);
            this._buttonEdit.TabIndex = 1;
            this._buttonEdit.Text = "Править";
            this._buttonEdit.UseVisualStyleBackColor = true;
            this._buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(959, 22);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(75, 23);
            this._buttonAdd.TabIndex = 0;
            this._buttonAdd.Text = "Добавить";
            this._buttonAdd.UseVisualStyleBackColor = true;
            this._buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // SpecialtyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.groupBoxElements);
            this.Controls.Add(this._dataGridViewSpecialties);
            this.Name = "SpecialtyForm";
            this.Text = "Специальности";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewSpecialties)).EndInit();
            this.groupBoxElements.ResumeLayout(false);
            this.groupBoxElements.PerformLayout();
            this._panelAddEdit.ResumeLayout(false);
            this._panelAddEdit.PerformLayout();
            this._panelSaveCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView _dataGridViewSpecialties;
        private GroupBox groupBoxElements;
        private Button _buttonDelete;
        private Button _buttonEdit;
        private Button _buttonAdd;
        private Panel _panelSaveCancel;
        private Button _buttonSave;
        private RadioButton _radioButtonSpecialty;
        private RadioButton _radioButtonProfession;
        private TextBox _textBoxName;
        private Panel _panelAddEdit;
        private TextBox _textBoxSearch;
        private Button _buttonCancel;
    }
}
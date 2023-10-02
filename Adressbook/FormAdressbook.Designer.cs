namespace Adressbook
{
    partial class FormAdressbook
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
            labelName = new Label();
            labelStreet = new Label();
            labelPostalCode = new Label();
            labelCity = new Label();
            labelPhoneNumber = new Label();
            labelEmailAdress = new Label();
            textName = new TextBox();
            textStreet = new TextBox();
            textZipCode = new TextBox();
            textCity = new TextBox();
            textPhoneNumber = new TextBox();
            textEmailAdress = new TextBox();
            listAdressEntries = new ListView();
            columnName = new ColumnHeader();
            columnStreet = new ColumnHeader();
            columnPostalCode = new ColumnHeader();
            columnCity = new ColumnHeader();
            columnPhoneNumber = new ColumnHeader();
            columnEmailAdress = new ColumnHeader();
            textSearchBox = new TextBox();
            buttonSave = new Button();
            buttonSearch = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(56, 64);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(79, 32);
            labelName.TabIndex = 0;
            labelName.Text = "Namn";
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(56, 171);
            labelStreet.Margin = new Padding(4, 0, 4, 0);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(131, 32);
            labelStreet.TabIndex = 1;
            labelStreet.Text = "Gatuadress";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(56, 277);
            labelPostalCode.Margin = new Padding(4, 0, 4, 0);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(149, 32);
            labelPostalCode.TabIndex = 2;
            labelPostalCode.Text = "Postnummer";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(56, 384);
            labelCity.Margin = new Padding(4, 0, 4, 0);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(88, 32);
            labelCity.TabIndex = 3;
            labelCity.Text = "Postort";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(56, 491);
            labelPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(184, 32);
            labelPhoneNumber.TabIndex = 4;
            labelPhoneNumber.Text = "Telefonnummer";
            // 
            // labelEmailAdress
            // 
            labelEmailAdress.AutoSize = true;
            labelEmailAdress.Location = new Point(56, 597);
            labelEmailAdress.Margin = new Padding(4, 0, 4, 0);
            labelEmailAdress.Name = "labelEmailAdress";
            labelEmailAdress.Size = new Size(138, 32);
            labelEmailAdress.TabIndex = 5;
            labelEmailAdress.Text = "Emailadress";
            // 
            // textName
            // 
            textName.BorderStyle = BorderStyle.FixedSingle;
            textName.Location = new Point(56, 98);
            textName.Margin = new Padding(4, 2, 4, 2);
            textName.Name = "textName";
            textName.Size = new Size(331, 39);
            textName.TabIndex = 6;
            // 
            // textStreet
            // 
            textStreet.BorderStyle = BorderStyle.FixedSingle;
            textStreet.Location = new Point(56, 205);
            textStreet.Margin = new Padding(4, 2, 4, 2);
            textStreet.Name = "textStreet";
            textStreet.Size = new Size(331, 39);
            textStreet.TabIndex = 7;
            // 
            // textZipCode
            // 
            textZipCode.BorderStyle = BorderStyle.FixedSingle;
            textZipCode.Location = new Point(52, 311);
            textZipCode.Margin = new Padding(4, 2, 4, 2);
            textZipCode.Name = "textZipCode";
            textZipCode.Size = new Size(331, 39);
            textZipCode.TabIndex = 8;
            // 
            // textCity
            // 
            textCity.BorderStyle = BorderStyle.FixedSingle;
            textCity.Location = new Point(56, 418);
            textCity.Margin = new Padding(4, 2, 4, 2);
            textCity.Name = "textCity";
            textCity.Size = new Size(331, 39);
            textCity.TabIndex = 9;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textPhoneNumber.Location = new Point(56, 525);
            textPhoneNumber.Margin = new Padding(4, 2, 4, 2);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(331, 39);
            textPhoneNumber.TabIndex = 10;
            // 
            // textEmailAdress
            // 
            textEmailAdress.BorderStyle = BorderStyle.FixedSingle;
            textEmailAdress.Location = new Point(56, 631);
            textEmailAdress.Margin = new Padding(4, 2, 4, 2);
            textEmailAdress.Name = "textEmailAdress";
            textEmailAdress.Size = new Size(331, 39);
            textEmailAdress.TabIndex = 11;
            // 
            // listAdressEntries
            // 
            listAdressEntries.BorderStyle = BorderStyle.FixedSingle;
            listAdressEntries.Columns.AddRange(new ColumnHeader[] { columnName, columnStreet, columnPostalCode, columnCity, columnPhoneNumber, columnEmailAdress });
            listAdressEntries.FullRowSelect = true;
            listAdressEntries.Location = new Point(449, 205);
            listAdressEntries.Margin = new Padding(4, 2, 4, 2);
            listAdressEntries.Name = "listAdressEntries";
            listAdressEntries.Size = new Size(1391, 473);
            listAdressEntries.TabIndex = 12;
            listAdressEntries.UseCompatibleStateImageBehavior = false;
            listAdressEntries.View = View.Details;
            listAdressEntries.Click += listAdressEntries_Click;
            // 
            // columnName
            // 
            columnName.Text = "Namn";
            columnName.Width = 150;
            // 
            // columnStreet
            // 
            columnStreet.Text = "Gatuadress";
            columnStreet.Width = 150;
            // 
            // columnPostalCode
            // 
            columnPostalCode.Text = "Postnummer";
            columnPostalCode.Width = 100;
            // 
            // columnCity
            // 
            columnCity.Text = "Postort";
            columnCity.Width = 100;
            // 
            // columnPhoneNumber
            // 
            columnPhoneNumber.Text = "Telefonnummer";
            columnPhoneNumber.Width = 100;
            // 
            // columnEmailAdress
            // 
            columnEmailAdress.Text = "Emailadress";
            columnEmailAdress.Width = 150;
            // 
            // textSearchBox
            // 
            textSearchBox.BorderStyle = BorderStyle.FixedSingle;
            textSearchBox.Location = new Point(449, 98);
            textSearchBox.Margin = new Padding(4, 2, 4, 2);
            textSearchBox.Name = "textSearchBox";
            textSearchBox.Size = new Size(648, 39);
            textSearchBox.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(240, 708);
            buttonSave.Margin = new Padding(4, 2, 4, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 47);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(1124, 98);
            buttonSearch.Margin = new Padding(4, 2, 4, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(150, 49);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1692, 708);
            buttonDelete.Margin = new Padding(4, 2, 4, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 47);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Ta bort";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormAdressbook
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1907, 817);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSearch);
            Controls.Add(buttonSave);
            Controls.Add(textSearchBox);
            Controls.Add(listAdressEntries);
            Controls.Add(textEmailAdress);
            Controls.Add(textPhoneNumber);
            Controls.Add(textCity);
            Controls.Add(textZipCode);
            Controls.Add(textStreet);
            Controls.Add(textName);
            Controls.Add(labelEmailAdress);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelCity);
            Controls.Add(labelPostalCode);
            Controls.Add(labelStreet);
            Controls.Add(labelName);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormAdressbook";
            Text = "FormAdressbook";
            Load += FormAdressbook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelStreet;
        private Label labelPostalCode;
        private Label labelCity;
        private Label labelPhoneNumber;
        private Label labelEmailAdress;
        private TextBox textName;
        private TextBox textStreet;
        private TextBox textZipCode;
        private TextBox textCity;
        private TextBox textPhoneNumber;
        private TextBox textEmailAdress;
        private ListView listAdressEntries;
        private TextBox textSearchBox;
        private Button buttonSave;
        private Button buttonSearch;
        private Button buttonDelete;
        private ColumnHeader columnName;
        private ColumnHeader columnStreet;
        private ColumnHeader columnPostalCode;
        private ColumnHeader columnCity;
        private ColumnHeader columnPhoneNumber;
        private ColumnHeader columnEmailAdress;
    }
}
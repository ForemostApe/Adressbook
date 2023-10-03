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
            buttonModify = new Button();
            buttonClear = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(16, 25);
            labelName.Margin = new Padding(2, 0, 2, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Namn";
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(16, 75);
            labelStreet.Margin = new Padding(2, 0, 2, 0);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(65, 15);
            labelStreet.TabIndex = 1;
            labelStreet.Text = "Gatuadress";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(16, 125);
            labelPostalCode.Margin = new Padding(2, 0, 2, 0);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(76, 15);
            labelPostalCode.TabIndex = 2;
            labelPostalCode.Text = "Postnummer";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(16, 175);
            labelCity.Margin = new Padding(2, 0, 2, 0);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(45, 15);
            labelCity.TabIndex = 3;
            labelCity.Text = "Postort";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(16, 225);
            labelPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(91, 15);
            labelPhoneNumber.TabIndex = 4;
            labelPhoneNumber.Text = "Telefonnummer";
            // 
            // labelEmailAdress
            // 
            labelEmailAdress.AutoSize = true;
            labelEmailAdress.Location = new Point(16, 275);
            labelEmailAdress.Margin = new Padding(2, 0, 2, 0);
            labelEmailAdress.Name = "labelEmailAdress";
            labelEmailAdress.Size = new Size(69, 15);
            labelEmailAdress.TabIndex = 5;
            labelEmailAdress.Text = "Emailadress";
            // 
            // textName
            // 
            textName.BorderStyle = BorderStyle.FixedSingle;
            textName.Location = new Point(16, 41);
            textName.Margin = new Padding(2, 1, 2, 1);
            textName.Name = "textName";
            textName.Size = new Size(181, 23);
            textName.TabIndex = 10;
            // 
            // textStreet
            // 
            textStreet.BorderStyle = BorderStyle.FixedSingle;
            textStreet.Location = new Point(16, 91);
            textStreet.Margin = new Padding(2, 1, 2, 1);
            textStreet.Name = "textStreet";
            textStreet.Size = new Size(181, 23);
            textStreet.TabIndex = 20;
            // 
            // textZipCode
            // 
            textZipCode.BorderStyle = BorderStyle.FixedSingle;
            textZipCode.Location = new Point(16, 141);
            textZipCode.Margin = new Padding(2, 1, 2, 1);
            textZipCode.Name = "textZipCode";
            textZipCode.Size = new Size(179, 23);
            textZipCode.TabIndex = 30;
            // 
            // textCity
            // 
            textCity.BorderStyle = BorderStyle.FixedSingle;
            textCity.Location = new Point(16, 191);
            textCity.Margin = new Padding(2, 1, 2, 1);
            textCity.Name = "textCity";
            textCity.Size = new Size(181, 23);
            textCity.TabIndex = 40;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textPhoneNumber.Location = new Point(16, 241);
            textPhoneNumber.Margin = new Padding(2, 1, 2, 1);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(181, 23);
            textPhoneNumber.TabIndex = 50;
            // 
            // textEmailAdress
            // 
            textEmailAdress.BorderStyle = BorderStyle.FixedSingle;
            textEmailAdress.Location = new Point(16, 291);
            textEmailAdress.Margin = new Padding(2, 1, 2, 1);
            textEmailAdress.Name = "textEmailAdress";
            textEmailAdress.Size = new Size(181, 23);
            textEmailAdress.TabIndex = 60;
            // 
            // listAdressEntries
            // 
            listAdressEntries.BorderStyle = BorderStyle.FixedSingle;
            listAdressEntries.Columns.AddRange(new ColumnHeader[] { columnName, columnStreet, columnPostalCode, columnCity, columnPhoneNumber, columnEmailAdress });
            listAdressEntries.FullRowSelect = true;
            listAdressEntries.Location = new Point(242, 115);
            listAdressEntries.Margin = new Padding(2, 1, 2, 1);
            listAdressEntries.Name = "listAdressEntries";
            listAdressEntries.Size = new Size(750, 223);
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
            textSearchBox.Location = new Point(532, 65);
            textSearchBox.Margin = new Padding(2, 1, 2, 1);
            textSearchBox.Name = "textSearchBox";
            textSearchBox.Size = new Size(350, 23);
            textSearchBox.TabIndex = 100;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(117, 327);
            buttonSave.Margin = new Padding(2, 1, 2, 1);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(81, 22);
            buttonSave.TabIndex = 80;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(911, 63);
            buttonSearch.Margin = new Padding(2, 1, 2, 1);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(81, 23);
            buttonSearch.TabIndex = 110;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(911, 352);
            buttonDelete.Margin = new Padding(2, 1, 2, 1);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(81, 23);
            buttonDelete.TabIndex = 120;
            buttonDelete.Text = "Ta bort";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonModify
            // 
            buttonModify.Location = new Point(117, 327);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(81, 23);
            buttonModify.TabIndex = 90;
            buttonModify.Text = "Ändra";
            buttonModify.UseVisualStyleBackColor = true;
            buttonModify.Visible = false;
            buttonModify.Click += buttonModify_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(16, 327);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(81, 23);
            buttonClear.TabIndex = 70;
            buttonClear.Text = "Töm";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textPhoneNumber);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(buttonModify);
            groupBox1.Controls.Add(labelStreet);
            groupBox1.Controls.Add(labelPostalCode);
            groupBox1.Controls.Add(labelCity);
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(labelPhoneNumber);
            groupBox1.Controls.Add(labelEmailAdress);
            groupBox1.Controls.Add(textName);
            groupBox1.Controls.Add(textEmailAdress);
            groupBox1.Controls.Add(textStreet);
            groupBox1.Controls.Add(textZipCode);
            groupBox1.Controls.Add(textCity);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 370);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adressuppgifter";
            // 
            // FormAdressbook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 416);
            Controls.Add(groupBox1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSearch);
            Controls.Add(textSearchBox);
            Controls.Add(listAdressEntries);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormAdressbook";
            Text = "FormAdressbook";
            Load += FormAdressbook_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button buttonModify;
        private Button buttonClear;
        private GroupBox groupBox1;
    }
}
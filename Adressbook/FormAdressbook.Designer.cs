﻿namespace Adressbook
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
            textPostalCode = new TextBox();
            textCity = new TextBox();
            textPhoneNumber = new TextBox();
            textEmailAdress = new TextBox();
            listAdressViewPort = new ListView();
            textSearchBox = new TextBox();
            buttonSave = new Button();
            buttonSearch = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(30, 30);
            labelName.Margin = new Padding(2, 0, 2, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Namn";
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(30, 80);
            labelStreet.Margin = new Padding(2, 0, 2, 0);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(65, 15);
            labelStreet.TabIndex = 1;
            labelStreet.Text = "Gatuadress";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(30, 130);
            labelPostalCode.Margin = new Padding(2, 0, 2, 0);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(76, 15);
            labelPostalCode.TabIndex = 2;
            labelPostalCode.Text = "Postnummer";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(30, 180);
            labelCity.Margin = new Padding(2, 0, 2, 0);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(45, 15);
            labelCity.TabIndex = 3;
            labelCity.Text = "Postort";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(30, 230);
            labelPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(91, 15);
            labelPhoneNumber.TabIndex = 4;
            labelPhoneNumber.Text = "Telefonnummer";
            // 
            // labelEmailAdress
            // 
            labelEmailAdress.AutoSize = true;
            labelEmailAdress.Location = new Point(30, 280);
            labelEmailAdress.Margin = new Padding(2, 0, 2, 0);
            labelEmailAdress.Name = "labelEmailAdress";
            labelEmailAdress.Size = new Size(69, 15);
            labelEmailAdress.TabIndex = 5;
            labelEmailAdress.Text = "Emailadress";
            // 
            // textName
            // 
            textName.Location = new Point(30, 46);
            textName.Margin = new Padding(2, 1, 2, 1);
            textName.Name = "textName";
            textName.Size = new Size(180, 23);
            textName.TabIndex = 6;
            // 
            // textStreet
            // 
            textStreet.Location = new Point(30, 96);
            textStreet.Margin = new Padding(2, 1, 2, 1);
            textStreet.Name = "textStreet";
            textStreet.Size = new Size(180, 23);
            textStreet.TabIndex = 7;
            // 
            // textPostalCode
            // 
            textPostalCode.Location = new Point(28, 146);
            textPostalCode.Margin = new Padding(2, 1, 2, 1);
            textPostalCode.Name = "textPostalCode";
            textPostalCode.Size = new Size(180, 23);
            textPostalCode.TabIndex = 8;
            // 
            // textCity
            // 
            textCity.Location = new Point(30, 196);
            textCity.Margin = new Padding(2, 1, 2, 1);
            textCity.Name = "textCity";
            textCity.Size = new Size(180, 23);
            textCity.TabIndex = 9;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Location = new Point(30, 246);
            textPhoneNumber.Margin = new Padding(2, 1, 2, 1);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(180, 23);
            textPhoneNumber.TabIndex = 10;
            // 
            // textEmailAdress
            // 
            textEmailAdress.Location = new Point(30, 296);
            textEmailAdress.Margin = new Padding(2, 1, 2, 1);
            textEmailAdress.Name = "textEmailAdress";
            textEmailAdress.Size = new Size(180, 23);
            textEmailAdress.TabIndex = 11;
            // 
            // listAdressViewPort
            // 
            listAdressViewPort.Location = new Point(232, 46);
            listAdressViewPort.Margin = new Padding(2, 1, 2, 1);
            listAdressViewPort.Name = "listAdressViewPort";
            listAdressViewPort.Size = new Size(461, 223);
            listAdressViewPort.TabIndex = 12;
            listAdressViewPort.UseCompatibleStateImageBehavior = false;
            listAdressViewPort.SelectedIndexChanged += listAdressViewPort_SelectedIndexChanged;
            // 
            // textSearchBox
            // 
            textSearchBox.Location = new Point(232, 296);
            textSearchBox.Margin = new Padding(2, 1, 2, 1);
            textSearchBox.Name = "textSearchBox";
            textSearchBox.Size = new Size(361, 23);
            textSearchBox.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(129, 332);
            buttonSave.Margin = new Padding(2, 1, 2, 1);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(81, 22);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(512, 332);
            buttonSearch.Margin = new Padding(2, 1, 2, 1);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(81, 22);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(612, 296);
            buttonDelete.Margin = new Padding(2, 1, 2, 1);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(81, 22);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Ta bort";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // FormAdressbook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 388);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSearch);
            Controls.Add(buttonSave);
            Controls.Add(textSearchBox);
            Controls.Add(listAdressViewPort);
            Controls.Add(textEmailAdress);
            Controls.Add(textPhoneNumber);
            Controls.Add(textCity);
            Controls.Add(textPostalCode);
            Controls.Add(textStreet);
            Controls.Add(textName);
            Controls.Add(labelEmailAdress);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelCity);
            Controls.Add(labelPostalCode);
            Controls.Add(labelStreet);
            Controls.Add(labelName);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormAdressbook";
            Text = "FormAdressbook";
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
        private TextBox textPostalCode;
        private TextBox textCity;
        private TextBox textPhoneNumber;
        private TextBox textEmailAdress;
        private ListView listAdressViewPort;
        private TextBox textSearchBox;
        private Button buttonSave;
        private Button buttonSearch;
        private Button buttonDelete;
    }
}
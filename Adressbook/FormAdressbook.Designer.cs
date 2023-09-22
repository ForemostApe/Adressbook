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
            labelName.Location = new Point(55, 49);
            labelName.Name = "labelName";
            labelName.Size = new Size(79, 32);
            labelName.TabIndex = 0;
            labelName.Text = "Namn";
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(55, 134);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(131, 32);
            labelStreet.TabIndex = 1;
            labelStreet.Text = "Gatuadress";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(55, 223);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(149, 32);
            labelPostalCode.TabIndex = 2;
            labelPostalCode.Text = "Postnummer";
            labelPostalCode.Click += labelPostalCode_Click;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(55, 314);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(88, 32);
            labelCity.TabIndex = 3;
            labelCity.Text = "Postort";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(55, 410);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(184, 32);
            labelPhoneNumber.TabIndex = 4;
            labelPhoneNumber.Text = "Telefonnummer";
            // 
            // labelEmailAdress
            // 
            labelEmailAdress.AutoSize = true;
            labelEmailAdress.Location = new Point(55, 508);
            labelEmailAdress.Name = "labelEmailAdress";
            labelEmailAdress.Size = new Size(138, 32);
            labelEmailAdress.TabIndex = 5;
            labelEmailAdress.Text = "Emailadress";
            // 
            // textName
            // 
            textName.Location = new Point(55, 84);
            textName.Name = "textName";
            textName.Size = new Size(331, 39);
            textName.TabIndex = 6;
            // 
            // textStreet
            // 
            textStreet.Location = new Point(55, 169);
            textStreet.Name = "textStreet";
            textStreet.Size = new Size(331, 39);
            textStreet.TabIndex = 7;
            // 
            // textPostalCode
            // 
            textPostalCode.Location = new Point(55, 258);
            textPostalCode.Name = "textPostalCode";
            textPostalCode.Size = new Size(331, 39);
            textPostalCode.TabIndex = 8;
            textPostalCode.TextChanged += textBox3_TextChanged;
            // 
            // textCity
            // 
            textCity.Location = new Point(55, 349);
            textCity.Name = "textCity";
            textCity.Size = new Size(331, 39);
            textCity.TabIndex = 9;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Location = new Point(55, 445);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(331, 39);
            textPhoneNumber.TabIndex = 10;
            textPhoneNumber.TextChanged += textBox5_TextChanged;
            // 
            // textEmailAdress
            // 
            textEmailAdress.Location = new Point(55, 543);
            textEmailAdress.Name = "textEmailAdress";
            textEmailAdress.Size = new Size(331, 39);
            textEmailAdress.TabIndex = 11;
            // 
            // listAdressViewPort
            // 
            listAdressViewPort.Location = new Point(431, 84);
            listAdressViewPort.Name = "listAdressViewPort";
            listAdressViewPort.Size = new Size(852, 500);
            listAdressViewPort.TabIndex = 12;
            listAdressViewPort.UseCompatibleStateImageBehavior = false;
            listAdressViewPort.SelectedIndexChanged += listAdressViewPort_SelectedIndexChanged;
            // 
            // textSearchBox
            // 
            textSearchBox.Location = new Point(431, 617);
            textSearchBox.Name = "textSearchBox";
            textSearchBox.Size = new Size(427, 39);
            textSearchBox.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(236, 610);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 46);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(864, 617);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(150, 46);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1133, 613);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 46);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Ta bort";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // FormAdressbook
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 732);
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
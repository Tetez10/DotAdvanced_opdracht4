namespace Oef1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToonForm = new System.Windows.Forms.Button();
            this.toonMessagebox = new System.Windows.Forms.Button();
            this.verwijder = new System.Windows.Forms.Button();
            this.ZetAchteraan = new System.Windows.Forms.Button();
            this.Volgendetaak = new System.Windows.Forms.Button();
            this.VoegToe = new System.Windows.Forms.Button();
            this.titel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RijBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Beschrijving";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.ControlLight;
            this.info.Location = new System.Drawing.Point(171, 430);
            this.info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(724, 197);
            this.info.TabIndex = 42;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 381);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(724, 27);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.MintCream;
            this.checkBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox.Location = new System.Drawing.Point(32, 384);
            this.checkBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(101, 29);
            this.checkBox.TabIndex = 40;
            this.checkBox.Text = "Datum";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(32, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Taak";
            // 
            // ToonForm
            // 
            this.ToonForm.BackColor = System.Drawing.Color.Red;
            this.ToonForm.Location = new System.Drawing.Point(934, 604);
            this.ToonForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToonForm.Name = "ToonForm";
            this.ToonForm.Size = new System.Drawing.Size(181, 56);
            this.ToonForm.TabIndex = 38;
            this.ToonForm.Text = "Toon in form";
            this.ToonForm.UseVisualStyleBackColor = false;
            this.ToonForm.Click += new System.EventHandler(this.ToonForm_Click);
            // 
            // toonMessagebox
            // 
            this.toonMessagebox.BackColor = System.Drawing.Color.Red;
            this.toonMessagebox.Location = new System.Drawing.Point(934, 514);
            this.toonMessagebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toonMessagebox.Name = "toonMessagebox";
            this.toonMessagebox.Size = new System.Drawing.Size(181, 56);
            this.toonMessagebox.TabIndex = 37;
            this.toonMessagebox.Text = "Toon in messageBox";
            this.toonMessagebox.UseVisualStyleBackColor = false;
            this.toonMessagebox.Click += new System.EventHandler(this.toonMessagebox_Click);
            // 
            // verwijder
            // 
            this.verwijder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.verwijder.Location = new System.Drawing.Point(934, 450);
            this.verwijder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.verwijder.Name = "verwijder";
            this.verwijder.Size = new System.Drawing.Size(181, 43);
            this.verwijder.TabIndex = 36;
            this.verwijder.Text = "Taak Verwijderen";
            this.verwijder.UseVisualStyleBackColor = false;
            this.verwijder.Click += new System.EventHandler(this.verwijder_Click);
            // 
            // ZetAchteraan
            // 
            this.ZetAchteraan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ZetAchteraan.Location = new System.Drawing.Point(934, 382);
            this.ZetAchteraan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ZetAchteraan.Name = "ZetAchteraan";
            this.ZetAchteraan.Size = new System.Drawing.Size(181, 43);
            this.ZetAchteraan.TabIndex = 35;
            this.ZetAchteraan.Text = "Zet Taak Achteraan";
            this.ZetAchteraan.UseVisualStyleBackColor = false;
            this.ZetAchteraan.Click += new System.EventHandler(this.ZetAchteraan_Click);
            // 
            // Volgendetaak
            // 
            this.Volgendetaak.BackColor = System.Drawing.Color.DarkGray;
            this.Volgendetaak.Location = new System.Drawing.Point(934, 313);
            this.Volgendetaak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Volgendetaak.Name = "Volgendetaak";
            this.Volgendetaak.Size = new System.Drawing.Size(181, 43);
            this.Volgendetaak.TabIndex = 34;
            this.Volgendetaak.Text = "Volgende taak";
            this.Volgendetaak.UseVisualStyleBackColor = false;
            this.Volgendetaak.Click += new System.EventHandler(this.Volgendetaak_Click);
            // 
            // VoegToe
            // 
            this.VoegToe.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.VoegToe.Location = new System.Drawing.Point(513, 681);
            this.VoegToe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VoegToe.Name = "VoegToe";
            this.VoegToe.Size = new System.Drawing.Size(117, 59);
            this.VoegToe.TabIndex = 33;
            this.VoegToe.Text = "Toevoegen";
            this.VoegToe.UseVisualStyleBackColor = false;
            this.VoegToe.Click += new System.EventHandler(this.VoegToe_Click);
            // 
            // titel
            // 
            this.titel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.titel.Location = new System.Drawing.Point(171, 313);
            this.titel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(724, 27);
            this.titel.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(513, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 36);
            this.label3.TabIndex = 44;
            this.label3.Text = "Taak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(387, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 57);
            this.label4.TabIndex = 45;
            this.label4.Text = "TaakOptimizer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 46;
            // 
            // RijBox
            // 
            this.RijBox.Location = new System.Drawing.Point(147, 814);
            this.RijBox.Name = "RijBox";
            this.RijBox.Size = new System.Drawing.Size(773, 27);
            this.RijBox.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MintCream;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(19, 814);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Rij";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 891);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RijBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToonForm);
            this.Controls.Add(this.toonMessagebox);
            this.Controls.Add(this.verwijder);
            this.Controls.Add(this.ZetAchteraan);
            this.Controls.Add(this.Volgendetaak);
            this.Controls.Add(this.VoegToe);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Label label2;
        private TextBox info;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox;
        private Label label1;
        private Button ToonForm;
        private Button toonMessagebox;
        private Button verwijder;
        private Button ZetAchteraan;
        private Button Volgendetaak;
        private Button VoegToe;
        private TextBox titel;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox RijBox;
        private Label label6;
    }
}
namespace Kalkulacka
{
    partial class ScienceForm
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
            this.arrayText = new System.Windows.Forms.TextBox();
            this.cislo2Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.naDruhouBtn = new System.Windows.Forms.Button();
            this.naTretiBtn = new System.Windows.Forms.Button();
            this.odmocninaBtn = new System.Windows.Forms.Button();
            this.faktorialBtn = new System.Windows.Forms.Button();
            this.vysledekLabel = new System.Windows.Forms.Label();
            this.errLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.klasickaButton = new System.Windows.Forms.Button();
            this.medianBtn = new System.Windows.Forms.Button();
            this.modusBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrayText
            // 
            this.arrayText.Location = new System.Drawing.Point(12, 25);
            this.arrayText.Name = "arrayText";
            this.arrayText.Size = new System.Drawing.Size(123, 20);
            this.arrayText.TabIndex = 0;
            // 
            // cislo2Text
            // 
            this.cislo2Text.Location = new System.Drawing.Point(12, 133);
            this.cislo2Text.Name = "cislo2Text";
            this.cislo2Text.Size = new System.Drawing.Size(123, 20);
            this.cislo2Text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hodnoty (oddělujte \";\")";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hodnota";
            // 
            // naDruhouBtn
            // 
            this.naDruhouBtn.Location = new System.Drawing.Point(12, 159);
            this.naDruhouBtn.Name = "naDruhouBtn";
            this.naDruhouBtn.Size = new System.Drawing.Size(75, 58);
            this.naDruhouBtn.TabIndex = 4;
            this.naDruhouBtn.Text = "^2";
            this.naDruhouBtn.UseVisualStyleBackColor = true;
            this.naDruhouBtn.Click += new System.EventHandler(this.naDruhouBtn_Click);
            // 
            // naTretiBtn
            // 
            this.naTretiBtn.Location = new System.Drawing.Point(93, 159);
            this.naTretiBtn.Name = "naTretiBtn";
            this.naTretiBtn.Size = new System.Drawing.Size(75, 58);
            this.naTretiBtn.TabIndex = 5;
            this.naTretiBtn.Text = "^3";
            this.naTretiBtn.UseVisualStyleBackColor = true;
            this.naTretiBtn.Click += new System.EventHandler(this.naTretiBtn_Click);
            // 
            // odmocninaBtn
            // 
            this.odmocninaBtn.Location = new System.Drawing.Point(174, 159);
            this.odmocninaBtn.Name = "odmocninaBtn";
            this.odmocninaBtn.Size = new System.Drawing.Size(75, 58);
            this.odmocninaBtn.TabIndex = 6;
            this.odmocninaBtn.Text = "^1/2";
            this.odmocninaBtn.UseVisualStyleBackColor = true;
            this.odmocninaBtn.Click += new System.EventHandler(this.odmocninaBtn_Click);
            // 
            // faktorialBtn
            // 
            this.faktorialBtn.Location = new System.Drawing.Point(255, 159);
            this.faktorialBtn.Name = "faktorialBtn";
            this.faktorialBtn.Size = new System.Drawing.Size(75, 58);
            this.faktorialBtn.TabIndex = 7;
            this.faktorialBtn.Text = "!";
            this.faktorialBtn.UseVisualStyleBackColor = true;
            // 
            // vysledekLabel
            // 
            this.vysledekLabel.AutoSize = true;
            this.vysledekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vysledekLabel.Location = new System.Drawing.Point(12, 239);
            this.vysledekLabel.Name = "vysledekLabel";
            this.vysledekLabel.Size = new System.Drawing.Size(79, 29);
            this.vysledekLabel.TabIndex = 8;
            this.vysledekLabel.Text = "label3";
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errLabel.Location = new System.Drawing.Point(12, 239);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(79, 29);
            this.errLabel.TabIndex = 9;
            this.errLabel.Text = "label4";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(464, 228);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "END";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // klasickaButton
            // 
            this.klasickaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klasickaButton.Location = new System.Drawing.Point(452, 95);
            this.klasickaButton.Name = "klasickaButton";
            this.klasickaButton.Size = new System.Drawing.Size(87, 54);
            this.klasickaButton.TabIndex = 120;
            this.klasickaButton.Text = "Klasická";
            this.klasickaButton.UseVisualStyleBackColor = true;
            this.klasickaButton.Click += new System.EventHandler(this.klasickaButton_Click);
            // 
            // medianBtn
            // 
            this.medianBtn.Location = new System.Drawing.Point(12, 51);
            this.medianBtn.Name = "medianBtn";
            this.medianBtn.Size = new System.Drawing.Size(75, 43);
            this.medianBtn.TabIndex = 121;
            this.medianBtn.Text = "Medián";
            this.medianBtn.UseVisualStyleBackColor = true;
            this.medianBtn.Click += new System.EventHandler(this.medianBtn_Click);
            // 
            // modusBtn
            // 
            this.modusBtn.Location = new System.Drawing.Point(93, 51);
            this.modusBtn.Name = "modusBtn";
            this.modusBtn.Size = new System.Drawing.Size(75, 43);
            this.modusBtn.TabIndex = 122;
            this.modusBtn.Text = "Modus";
            this.modusBtn.UseVisualStyleBackColor = true;
            // 
            // ScienceForm
            // 
            this.ClientSize = new System.Drawing.Size(551, 277);
            this.Controls.Add(this.modusBtn);
            this.Controls.Add(this.medianBtn);
            this.Controls.Add(this.klasickaButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.vysledekLabel);
            this.Controls.Add(this.faktorialBtn);
            this.Controls.Add(this.odmocninaBtn);
            this.Controls.Add(this.naTretiBtn);
            this.Controls.Add(this.naDruhouBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cislo2Text);
            this.Controls.Add(this.arrayText);
            this.Name = "ScienceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ScienceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox arrayText;
        private System.Windows.Forms.TextBox cislo2Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button naDruhouBtn;
        private System.Windows.Forms.Button naTretiBtn;
        private System.Windows.Forms.Button odmocninaBtn;
        private System.Windows.Forms.Button faktorialBtn;
        private System.Windows.Forms.Label vysledekLabel;
        private System.Windows.Forms.Label errLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button klasickaButton;
        private System.Windows.Forms.Button medianBtn;
        private System.Windows.Forms.Button modusBtn;
    }
}

#endregion
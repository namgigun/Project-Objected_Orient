
namespace TetrisGame.Forms
{
    partial class SettinsForm
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
            this.rowNumLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rowTextBox = new System.Windows.Forms.TextBox();
            this.columnTextBox = new System.Windows.Forms.TextBox();
            this.addNewButton = new System.Windows.Forms.Button();
            this.saveAndExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c33 = new System.Windows.Forms.CheckBox();
            this.c32 = new System.Windows.Forms.CheckBox();
            this.c31 = new System.Windows.Forms.CheckBox();
            this.c30 = new System.Windows.Forms.CheckBox();
            this.c23 = new System.Windows.Forms.CheckBox();
            this.c22 = new System.Windows.Forms.CheckBox();
            this.c21 = new System.Windows.Forms.CheckBox();
            this.c20 = new System.Windows.Forms.CheckBox();
            this.c13 = new System.Windows.Forms.CheckBox();
            this.c12 = new System.Windows.Forms.CheckBox();
            this.c11 = new System.Windows.Forms.CheckBox();
            this.c10 = new System.Windows.Forms.CheckBox();
            this.c03 = new System.Windows.Forms.CheckBox();
            this.c02 = new System.Windows.Forms.CheckBox();
            this.c01 = new System.Windows.Forms.CheckBox();
            this.c00 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rowNumLable
            // 
            this.rowNumLable.AutoSize = true;
            this.rowNumLable.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowNumLable.Location = new System.Drawing.Point(12, 9);
            this.rowNumLable.Name = "rowNumLable";
            this.rowNumLable.Size = new System.Drawing.Size(182, 33);
            this.rowNumLable.TabIndex = 2;
            this.rowNumLable.Text = "Row numbers:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Column numbers:";
            // 
            // rowTextBox
            // 
            this.rowTextBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTextBox.Location = new System.Drawing.Point(231, 8);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(100, 38);
            this.rowTextBox.TabIndex = 4;
            // 
            // columnTextBox
            // 
            this.columnTextBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnTextBox.Location = new System.Drawing.Point(231, 66);
            this.columnTextBox.Name = "columnTextBox";
            this.columnTextBox.Size = new System.Drawing.Size(100, 38);
            this.columnTextBox.TabIndex = 5;
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(86, 267);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(171, 40);
            this.addNewButton.TabIndex = 6;
            this.addNewButton.Text = "Add new block";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // saveAndExitButton
            // 
            this.saveAndExitButton.Location = new System.Drawing.Point(86, 313);
            this.saveAndExitButton.Name = "saveAndExitButton";
            this.saveAndExitButton.Size = new System.Drawing.Size(171, 40);
            this.saveAndExitButton.TabIndex = 7;
            this.saveAndExitButton.Text = "Save and exit to menu";
            this.saveAndExitButton.UseVisualStyleBackColor = true;
            this.saveAndExitButton.Click += new System.EventHandler(this.saveAndExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c33);
            this.panel1.Controls.Add(this.c32);
            this.panel1.Controls.Add(this.c31);
            this.panel1.Controls.Add(this.c30);
            this.panel1.Controls.Add(this.c23);
            this.panel1.Controls.Add(this.c22);
            this.panel1.Controls.Add(this.c21);
            this.panel1.Controls.Add(this.c20);
            this.panel1.Controls.Add(this.c13);
            this.panel1.Controls.Add(this.c12);
            this.panel1.Controls.Add(this.c11);
            this.panel1.Controls.Add(this.c10);
            this.panel1.Controls.Add(this.c03);
            this.panel1.Controls.Add(this.c02);
            this.panel1.Controls.Add(this.c01);
            this.panel1.Controls.Add(this.c00);
            this.panel1.Location = new System.Drawing.Point(108, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 119);
            this.panel1.TabIndex = 8;
            // 
            // c33
            // 
            this.c33.Appearance = System.Windows.Forms.Appearance.Button;
            this.c33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c33.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c33.FlatAppearance.BorderSize = 2;
            this.c33.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c33.Location = new System.Drawing.Point(92, 88);
            this.c33.Name = "c33";
            this.c33.Size = new System.Drawing.Size(20, 19);
            this.c33.TabIndex = 24;
            this.c33.UseVisualStyleBackColor = false;
            // 
            // c32
            // 
            this.c32.Appearance = System.Windows.Forms.Appearance.Button;
            this.c32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c32.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c32.FlatAppearance.BorderSize = 2;
            this.c32.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c32.Location = new System.Drawing.Point(66, 88);
            this.c32.Name = "c32";
            this.c32.Size = new System.Drawing.Size(20, 19);
            this.c32.TabIndex = 23;
            this.c32.UseVisualStyleBackColor = false;
            // 
            // c31
            // 
            this.c31.Appearance = System.Windows.Forms.Appearance.Button;
            this.c31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c31.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c31.FlatAppearance.BorderSize = 2;
            this.c31.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c31.Location = new System.Drawing.Point(40, 88);
            this.c31.Name = "c31";
            this.c31.Size = new System.Drawing.Size(20, 19);
            this.c31.TabIndex = 22;
            this.c31.UseVisualStyleBackColor = false;
            // 
            // c30
            // 
            this.c30.Appearance = System.Windows.Forms.Appearance.Button;
            this.c30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c30.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c30.FlatAppearance.BorderSize = 2;
            this.c30.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c30.Location = new System.Drawing.Point(14, 88);
            this.c30.Name = "c30";
            this.c30.Size = new System.Drawing.Size(20, 19);
            this.c30.TabIndex = 21;
            this.c30.UseVisualStyleBackColor = false;
            // 
            // c23
            // 
            this.c23.Appearance = System.Windows.Forms.Appearance.Button;
            this.c23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c23.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c23.FlatAppearance.BorderSize = 2;
            this.c23.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c23.Location = new System.Drawing.Point(92, 63);
            this.c23.Name = "c23";
            this.c23.Size = new System.Drawing.Size(20, 19);
            this.c23.TabIndex = 20;
            this.c23.UseVisualStyleBackColor = false;
            // 
            // c22
            // 
            this.c22.Appearance = System.Windows.Forms.Appearance.Button;
            this.c22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c22.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c22.FlatAppearance.BorderSize = 2;
            this.c22.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c22.Location = new System.Drawing.Point(66, 63);
            this.c22.Name = "c22";
            this.c22.Size = new System.Drawing.Size(20, 19);
            this.c22.TabIndex = 19;
            this.c22.UseVisualStyleBackColor = false;
            // 
            // c21
            // 
            this.c21.Appearance = System.Windows.Forms.Appearance.Button;
            this.c21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c21.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c21.FlatAppearance.BorderSize = 2;
            this.c21.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c21.Location = new System.Drawing.Point(40, 63);
            this.c21.Name = "c21";
            this.c21.Size = new System.Drawing.Size(20, 19);
            this.c21.TabIndex = 18;
            this.c21.UseVisualStyleBackColor = false;
            // 
            // c20
            // 
            this.c20.Appearance = System.Windows.Forms.Appearance.Button;
            this.c20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c20.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c20.FlatAppearance.BorderSize = 2;
            this.c20.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c20.Location = new System.Drawing.Point(14, 63);
            this.c20.Name = "c20";
            this.c20.Size = new System.Drawing.Size(20, 19);
            this.c20.TabIndex = 17;
            this.c20.UseVisualStyleBackColor = false;
            // 
            // c13
            // 
            this.c13.Appearance = System.Windows.Forms.Appearance.Button;
            this.c13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c13.FlatAppearance.BorderSize = 2;
            this.c13.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c13.Location = new System.Drawing.Point(92, 38);
            this.c13.Name = "c13";
            this.c13.Size = new System.Drawing.Size(20, 19);
            this.c13.TabIndex = 16;
            this.c13.UseVisualStyleBackColor = false;
            // 
            // c12
            // 
            this.c12.Appearance = System.Windows.Forms.Appearance.Button;
            this.c12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c12.FlatAppearance.BorderSize = 2;
            this.c12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c12.Location = new System.Drawing.Point(66, 38);
            this.c12.Name = "c12";
            this.c12.Size = new System.Drawing.Size(20, 19);
            this.c12.TabIndex = 15;
            this.c12.UseVisualStyleBackColor = false;
            // 
            // c11
            // 
            this.c11.Appearance = System.Windows.Forms.Appearance.Button;
            this.c11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c11.FlatAppearance.BorderSize = 2;
            this.c11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c11.Location = new System.Drawing.Point(40, 38);
            this.c11.Name = "c11";
            this.c11.Size = new System.Drawing.Size(20, 19);
            this.c11.TabIndex = 14;
            this.c11.UseVisualStyleBackColor = false;
            // 
            // c10
            // 
            this.c10.Appearance = System.Windows.Forms.Appearance.Button;
            this.c10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c10.FlatAppearance.BorderSize = 2;
            this.c10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c10.Location = new System.Drawing.Point(14, 38);
            this.c10.Name = "c10";
            this.c10.Size = new System.Drawing.Size(20, 19);
            this.c10.TabIndex = 13;
            this.c10.UseVisualStyleBackColor = false;
            // 
            // c03
            // 
            this.c03.Appearance = System.Windows.Forms.Appearance.Button;
            this.c03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c03.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c03.FlatAppearance.BorderSize = 2;
            this.c03.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c03.Location = new System.Drawing.Point(92, 13);
            this.c03.Name = "c03";
            this.c03.Size = new System.Drawing.Size(20, 19);
            this.c03.TabIndex = 12;
            this.c03.UseVisualStyleBackColor = false;
            // 
            // c02
            // 
            this.c02.Appearance = System.Windows.Forms.Appearance.Button;
            this.c02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c02.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c02.FlatAppearance.BorderSize = 2;
            this.c02.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c02.Location = new System.Drawing.Point(66, 13);
            this.c02.Name = "c02";
            this.c02.Size = new System.Drawing.Size(20, 19);
            this.c02.TabIndex = 11;
            this.c02.UseVisualStyleBackColor = false;
            // 
            // c01
            // 
            this.c01.Appearance = System.Windows.Forms.Appearance.Button;
            this.c01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c01.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c01.FlatAppearance.BorderSize = 2;
            this.c01.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c01.Location = new System.Drawing.Point(40, 13);
            this.c01.Name = "c01";
            this.c01.Size = new System.Drawing.Size(20, 19);
            this.c01.TabIndex = 10;
            this.c01.UseVisualStyleBackColor = false;
            // 
            // c00
            // 
            this.c00.Appearance = System.Windows.Forms.Appearance.Button;
            this.c00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.c00.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c00.FlatAppearance.BorderSize = 2;
            this.c00.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.c00.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c00.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.c00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c00.Location = new System.Drawing.Point(14, 13);
            this.c00.Name = "c00";
            this.c00.Size = new System.Drawing.Size(20, 19);
            this.c00.TabIndex = 9;
            this.c00.UseVisualStyleBackColor = false;
            // 
            // SettinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveAndExitButton);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.columnTextBox);
            this.Controls.Add(this.rowTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rowNumLable);
            this.Name = "SettinsForm";
            this.Text = "SettinsForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rowNumLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rowTextBox;
        private System.Windows.Forms.TextBox columnTextBox;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button saveAndExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox c33;
        private System.Windows.Forms.CheckBox c32;
        private System.Windows.Forms.CheckBox c31;
        private System.Windows.Forms.CheckBox c30;
        private System.Windows.Forms.CheckBox c23;
        private System.Windows.Forms.CheckBox c22;
        private System.Windows.Forms.CheckBox c21;
        private System.Windows.Forms.CheckBox c20;
        private System.Windows.Forms.CheckBox c13;
        private System.Windows.Forms.CheckBox c12;
        private System.Windows.Forms.CheckBox c11;
        private System.Windows.Forms.CheckBox c10;
        private System.Windows.Forms.CheckBox c03;
        private System.Windows.Forms.CheckBox c02;
        private System.Windows.Forms.CheckBox c01;
        private System.Windows.Forms.CheckBox c00;
    }
}
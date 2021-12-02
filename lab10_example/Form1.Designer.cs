namespace lab10_example
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.textBoxCols = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelIndexPositivColumn = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.button_Sort = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGrid2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметри матриці:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "К-сть рядків";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "К-сть стовпців";
            // 
            // textBoxRows
            // 
            this.textBoxRows.Location = new System.Drawing.Point(146, 65);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(50, 22);
            this.textBoxRows.TabIndex = 3;
            // 
            // textBoxCols
            // 
            this.textBoxCols.Location = new System.Drawing.Point(146, 98);
            this.textBoxCols.Name = "textBoxCols";
            this.textBoxCols.Size = new System.Drawing.Size(50, 22);
            this.textBoxCols.TabIndex = 4;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(463, 97);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(50, 22);
            this.textBoxMax.TabIndex = 8;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(463, 64);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(50, 22);
            this.textBoxMin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Максимальне знач елемента";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Мінімальне знач елемента";
            // 
            // labelIndexPositivColumn
            // 
            this.labelIndexPositivColumn.AutoSize = true;
            this.labelIndexPositivColumn.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexPositivColumn.Location = new System.Drawing.Point(12, 164);
            this.labelIndexPositivColumn.Name = "labelIndexPositivColumn";
            this.labelIndexPositivColumn.Size = new System.Drawing.Size(251, 48);
            this.labelIndexPositivColumn.TabIndex = 9;
            this.labelIndexPositivColumn.Text = "№ першого позитивного \r\nстовпця -";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(554, 79);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(173, 40);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "Створити матрицю";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // button_Sort
            // 
            this.button_Sort.AccessibleDescription = "Сортування рядків матриці за зростанням суми абсолютних значень елементів рядків";
            this.button_Sort.Location = new System.Drawing.Point(281, 178);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(232, 40);
            this.button_Sort.TabIndex = 11;
            this.button_Sort.Text = "Сортувати за характеристикою";
            this.button_Sort.UseVisualStyleBackColor = true;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 241);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(232, 234);
            this.dataGrid.TabIndex = 12;
            this.dataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGrid_DataBindingComplete);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(551, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 48);
            this.label6.TabIndex = 14;
            this.label6.Text = "Масив зі значеннями \r\nабсолютної суми \r\nелементів кожного рядка";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(554, 241);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 228);
            this.listBox1.TabIndex = 15;
            // 
            // dataGrid2
            // 
            this.dataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid2.Location = new System.Drawing.Point(281, 241);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.RowHeadersWidth = 51;
            this.dataGrid2.RowTemplate.Height = 24;
            this.dataGrid2.Size = new System.Drawing.Size(232, 234);
            this.dataGrid2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 510);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelIndexPositivColumn);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCols);
            this.Controls.Add(this.textBoxRows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Робота з двовимірними масивами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.TextBox textBoxCols;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelIndexPositivColumn;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGrid2;
    }
}


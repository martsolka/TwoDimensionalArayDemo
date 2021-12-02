using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10_example
{
    public partial class Form1 : Form
    {
        Matrix2D matrix;
        public Form1()
        {
            InitializeComponent();
            button_Sort.Enabled = false;
            toolTip1.SetToolTip(button_Sort, "Сортування рядків матриці за зростанням суми абсолютних значень елементів рядків");
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            matrix.SortRowsByCharacteristic();
            Print(matrix, dt);
            dataGrid2.DataSource = dt.DefaultView;
            dataGrid2.ColumnHeadersVisible = false;
            dataGrid2.AllowUserToAddRows = false;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            int rows = int.Parse(textBoxRows.Text);
            int cols = int.Parse(textBoxCols.Text);
            matrix = new Matrix2D(rows, cols);
            int max = int.Parse(textBoxMax.Text);
            int min = int.Parse(textBoxMin.Text);
            matrix.FillElementsRandom(min, max);
            DataTable dt = new DataTable();
            Print(matrix, dt);
            dataGrid.DataSource = dt.DefaultView;
            //dataGrid.ColumnHeadersVisible = false;
            dataGrid.AllowUserToAddRows = false;
            int columnIndex = matrix.IndexOfFirstPositiveColumn() + 1;
            labelIndexPositivColumn.Text =

            "Номер першого позитивного стовпця: " + columnIndex.ToString();
            string res = "";
            listBox1.Items.Clear();
            listBox1.Items.Clear();
            for (int i = 0; i < rows; i++)
            {
                res = "Рядок " + (i + 1).ToString() + ": сума = ";
                res += (matrix.AbsolutRowsSum[i]).ToString();
                listBox1.Items.Add(res);
            }
            button_Sort.Enabled = true;
        }
        
        private void Print(Matrix2D matrix, DataTable dt)
        {
            int columns = matrix.ColCount;
            int rows = matrix.RowCount;
            for (int i = 0; i < columns; i++)
            {
                dt.Columns.Add(i.ToString(), typeof(double));
            }
            for (int row = 0; row < rows; row++)
            {
                DataRow dr = dt.NewRow();
                for (int col = 0; col < columns; col++)
                {
                    dr[col] = matrix[row, col];
                }
                dt.Rows.Add(dr);
            }
        }

        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                dataGrid.Rows[i].HeaderCell.Value = String.Format("Row{0}", dataGrid.Rows[i].Index + 1);
            }
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                dataGrid.Columns[i].HeaderCell.Value = String.Format("Col{0}", dataGrid.Columns[i].Index + 1);
            }
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

using autoProject.dbClases;
using System.Data.Entity;

namespace autoProject.formClases
{
    public partial class FormAddExcelData : Form
    {
        DataTable dt = new DataTable();
      
        public FormAddExcelData()
        {
            InitializeComponent();
        }
        // по нажатию на клавишу выбираем Excel файл на закгрузку
        private void btChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox_pass.Text = openFileDialog1.FileName;   // получаем полный путь к файлу и показываем его в текстБоксе  
            }
        }
        // отображаем на вьюхе вычитанные данные из файла
        //
        private void btOpenExcel_Click(object sender, EventArgs e)
        {

            String connString = ("Provider=Microsoft.ACE.OLEDB.12.0;" +
                                 "Data Source=" + textBox_pass.Text + ";" +
                                 "Extended Properties=Excel 12.0 Xml");
            OleDbConnection conn = new OleDbConnection(connString);

            // создаем список названий листов Excel файла


            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("SELECT * FROM [Marks$]", conn);
            
            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            var countMarks = dt.Rows.Count;
            for (int i = 0; i < countMarks; i++)
            {
                string s = dt.Rows[i][0].ToString();
                comboBox1.Items.Add(s);
            }
        }

        // создание контекста для добавления марок в базу 
        private void btAddExcelDada_Click(object sender, EventArgs e)
        {

            using (var context = new OurBaseContext())
            {
                var countMarks = dataGridView1.Rows.Count;

                for (int i = 0; i < countMarks; i++)
                {
                    //   string s = dt.Rows[i][0].ToString();
                    if(dataGridView1.Rows[i].Cells[0].Value != null)
                    {
                        context.Brends.Add(new Brend()
                        {
                            BrandName = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                        });
                    }
                }
                context.SaveChanges();
            }
        }

        // комбобокс из списка марок автомобилей
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
         

        }
    }
}

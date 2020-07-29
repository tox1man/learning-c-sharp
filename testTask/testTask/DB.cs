using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace testTask
{
    public partial class DB : Form
    {
        static DateTime dt = DateTime.Today;
        public static string dateString = $"{dt.ToString("dd.MM.yyyy")}";

        public DB()
        {
            InitializeComponent();
        }

        private XmlDocument getXml()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            XmlDocument doc = new XmlDocument();
            doc.Load(getLink(dateString));
            xmlShow.Text = doc.InnerXml;
            return doc;
        }

        private void saveXml(XmlDocument xmlDoc, string date)
        {
            xmlDoc.Save($"SB_currencies_{date}.xml");
        }


        private DataSet getTable() 
        {
            DataTable CurrencyTable = new DataTable("Currencies Table");
            DataSet ds = new DataSet();

            ds.ReadXml($"SB_currencies_{dateString}.xml");
            dgvTable.DataSource = ds.Tables[1];
            DataColumn[] ColumnsKyeArr = new DataColumn[1] { ds.Tables[1].Columns[5] };
            ds.Tables[1].PrimaryKey = ColumnsKyeArr;
            return ds;
        }


        private static string getLink(string dateString)
        {
            string url = @"http://www.cbr.ru/scripts/XML_daily.asp?date_req=";
            url += dateString;
            return url;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Parse_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                dateString = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Неверный формат даты. Используется дата по умолчанию (сегодняшняя).", "Ошибка");
            }
            getXml();
        }

        private void loadListBox(DataSet ds)
        {
            for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[1].Rows[i].ItemArray[3]);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            saveXml(getXml(), dateString);
            loadListBox(getTable());
        }

        private void FindCurr_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string itemValue = getTable().Tables[1].Rows[listBox1.SelectedIndex].ItemArray[4].ToString();
                string itemName = listBox1.SelectedItem.ToString();
                MessageBox.Show($"Курс {itemName} на {dateString}: {itemValue} рубля.", $"Курс {itemName}");
            }
        }
    }
}

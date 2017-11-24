using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskToDoList
{
    public partial class Task : Form
    {
        public Task()
        {
            InitializeComponent();
        }

        DealsMassive a = new DealsMassive();
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddDeal_Click(object sender, EventArgs e)
        {
            try
            {
                int data = Convert.ToInt32(textBoxAddData.Text);
                a.PutDeal(textBoxAddValue.Text, data);
                labelDealsCount.Text = "Сколько дел запланировано : " + a.Count.ToString();
                string support = (a.IsEmpty) ? "Да" : "Нет";
                labelIsEmpty.Text = "Пуст ли список дел : " + support;
                textBoxDeals.Text = a.Printer();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int data = Convert.ToInt32(textBoxData.Text);
                textBoxFoundedDeals.Text = a.GetByData(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void textBoxData_Click(object sender, EventArgs e)
        {
            textBoxData.Text = null;
        }

        private void textBoxAddData_Click(object sender, EventArgs e)
        {
            textBoxAddData.Text = null;
        }

        private void textBoxAddValue_Click(object sender, EventArgs e)
        {
            textBoxAddValue.Text = null;
        }

        
    }
}

using System;
using System.Windows.Forms;

namespace BTVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                txtTen.Text = listView2.SelectedItems[0].SubItems[0].Text;
                txtNgaySinh.Text = listView2.SelectedItems[0].SubItems[1].Text;
                txtDiaChi.Text = listView2.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem listItem = new ListViewItem(txtTen.Text);
            listItem.SubItems.Add(txtNgaySinh.Text);
            listItem.SubItems.Add(txtDiaChi.Text);
            listView2.Items.Add(listItem);
            txtTen.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView2.Columns[0].Width = (int)(listView2.Width * 0.25);
            listView2.Columns[1].Width = (int)(listView2.Width * 0.25);
            listView2.Columns[2].Width = (int)(listView2.Width * 0.25);
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.SelectedItems[0].SubItems[0].Text = txtTen.Text;
                listView2.SelectedItems[0].SubItems[1].Text = txtNgaySinh.Text;
                listView2.SelectedItems[0].SubItems[2].Text = txtDiaChi.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.Items.Remove(listView2.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất 1 dòng");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        Employee emp;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get employees
            dataGridView1.DataSource = null; // clear our the data
            dataGridView1.DataSource = emp.GetEmployees(); 
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            emp = new Employee();
            emp.InitializeEmployees();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add employee obj
            Employee obj = new Employee();
            obj.Id = Int32.Parse(textBox2.Text); //type cast from int to string
            obj.Name = textBox1.Text;
            obj.Address = textBox3.Text;
            emp.AddEmp(obj);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

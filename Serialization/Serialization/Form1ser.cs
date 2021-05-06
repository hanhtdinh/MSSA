using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;

namespace Serialization
{
    public partial class Form1 : Form
    {
        Customer cust; //create customer and gives it a global scope within event handlers
        int[] party = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }; //create array for party sizes
        string[] location = new string[] { "Inside Table", "Inside Booth", "Outside Table", "Outside Bar" }; //create array for location
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = party; //assigns info for the combo box
            comboBox1.DataSource = location;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //customer obj
            if(textBox1.Text!=string.Empty && comboBox2.Text!=string.Empty && comboBox1.Text!=string.Empty)
            {
                cust = new Customer();
                //get values from text box
                cust.Name = textBox1.Text;
                //cus t.partySize = (int)(comboBox2.SelectedItem.ToString()); //typecast
                cust.partySize = comboBox2.SelectedIndex; //actual rep. internally
                cust.seatLocation = comboBox1.SelectedItem.ToString(); //exact item along w/ string rep
            }

            Refreshdata();
        }
        private void Refreshdata()
        {
            textBox1.Text = string.Empty;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //binary click
            FileStream fstream = new FileStream(@"C:\Serialization\Binary.txt", FileMode.Open, FileAccess.ReadWrite);
            //binary serialization
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fstream, cust); //where (filepath), what (cust obj)

            //binary deserialization
            fstream.Close(); //need to close so it doesn't think it's still open
            FileStream fstreamnew = new FileStream(@"C:\Serialization\Binary.txt", FileMode.Open, FileAccess.ReadWrite);
            Customer cust1;
            cust1 = binaryFormatter.Deserialize(fstreamnew) as Customer;
            fstreamnew.Close();
            //DialogResult dialogResult = MessageBox.Show(textBox1.Text, comboBox2.Text, comboBox1.Text, textBox1, comboBox2, comboBox1);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //XML
            SoapFormatter soapFormatter = new SoapFormatter(); //create soapformatter
            FileStream fstreamxml = new FileStream(@"C:\Serialization\XML.xml", FileMode.OpenOrCreate, FileAccess.Write);
            soapFormatter.Serialize(fstreamxml, cust);
            fstreamxml.Close();

            //deserialization
            FileStream buffer = File.OpenRead(@"C:\Serialization\XML.xml");
            Customer c = soapFormatter.Deserialize(buffer) as Customer;
            buffer.Close();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //JSON
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(cust.GetType());
            FileStream buffernew = new FileStream(@"C:\Serialization\JSON.txt", FileMode.Open, FileAccess.Write);
            jsonSerializer.WriteObject(buffernew, cust);
            buffernew.Close();

            //deserialization
            FileStream buffer1 = File.OpenRead(@"C:Serialization\JSON.txt");
            Customer jsonobj = jsonSerializer.ReadObject(buffer1) as Customer;
            buffer1.Close();
            //StreamReader streamReader = new StreamReader(fstream);



        }
    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Биохимический_анализ_крови
{

	public partial class Start : Form
	{
		List<Person> pdata = new List<Person>();
		List<Test_results> adata = new List<Test_results>();
		int sel_id = -1;
		int flag = 0;
		public Start(int a,int f)
		{
			InitializeComponent();
			sel_id = a;
			int flag = f;
		}

		public void clear_textboxs()
		{
			this.textBox1.Clear(); this.textBox2.Clear();
			this.textBox3.Clear(); this.textBox4.Clear();
			this.textBox5.Clear(); this.textBox6.Clear();
			this.textBox7.Clear(); this.textBox8.Clear();
			this.textBox7.Clear(); this.textBox8.Clear();
			this.textBox9.Clear(); this.textBox10.Clear();
			this.textBox11.Clear(); this.textBox12.Clear();
			this.textBox13.Clear(); this.textBox14.Clear();
			this.textBox15.Clear(); this.textBox16.Clear();
			this.textBox17.Clear(); this.textBox18.Clear();
			this.textBox19.Clear(); this.textBox20.Clear();
			this.textBox21.Clear(); this.textBox22.Clear();
			this.textBox23.Clear(); this.textBox24.Clear();
			this.textBox25.Clear(); this.textBox26.Clear();
			this.textBox27.Clear(); this.textBox28.Clear();
			this.textBox29.Clear(); this.textBox30.Clear();
			this.textBox31.Clear(); this.textBox32.Clear();
			this.textBox33.Clear(); this.textBox34.Clear();
		}

		private void ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Close(object sender, FormClosingEventArgs e)
		{
			switch (MessageBox.Show("Завершить работу ?", "Завершение работы",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
			{
				case DialogResult.Yes:
					{
						e.Cancel = false;
						break;
					}
				case DialogResult.No:
					{
						e.Cancel = true;
						break;
					}
				case DialogResult.Cancel:
					{
						e.Cancel = true;
						break;
					}
			}
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pdata.Add(new Person(int.Parse(textBox1.Text), textBox2.Text,textBox3.Text, textBox4.Text, textBox5.Text,textBox6.Text, textBox7.Text, textBox8.Text));
			listBox1.Items.Add(pdata[pdata.Count-1].PatientID + " " + pdata[pdata.Count-1].PIN +" " + pdata[pdata.Count-1].Surname + " " + pdata[pdata.Count-1].Name);

			adata.Add(new Test_results(
				int.Parse(textBox1.Text),textBox2.Text,
				textBox3.Text, textBox4.Text, 
				textBox5.Text, textBox6.Text, 
				textBox7.Text, textBox8.Text,
				int.Parse(textBox9.Text), int.Parse(textBox10.Text), 
				int.Parse(textBox11.Text), int.Parse(textBox12.Text),
				int.Parse(textBox13.Text), int.Parse(textBox14.Text),
				int.Parse(textBox15.Text), int.Parse(textBox16.Text), 
				int.Parse(textBox17.Text), int.Parse(textBox18.Text),
				int.Parse(textBox19.Text), int.Parse(textBox20.Text),
				int.Parse(textBox21.Text),double.Parse(textBox22.Text), 
				double.Parse(textBox23.Text),double.Parse(textBox24.Text), 
				double.Parse(textBox25.Text),double.Parse(textBox26.Text), 
				double.Parse(textBox27.Text),double.Parse(textBox28.Text),
				double.Parse(textBox29.Text),double.Parse(textBox30.Text),
				double.Parse(textBox31.Text),double.Parse(textBox32.Text), 
				double.Parse(textBox33.Text),double.Parse(textBox34.Text))
				);
			clear_textboxs();
		}
		void edit_fun(int num)
		{
            textBox1.Text = adata[num].PatientID.ToString();
            textBox2.Text = adata[num].PIN.ToString();
            textBox3.Text = adata[num].Surname.ToString();
            textBox4.Text = adata[num].Name.ToString();
            textBox5.Text = adata[num].Patronymic.ToString();
            textBox6.Text = adata[num].Birthday.ToString();
            textBox7.Text = adata[num].Address.ToString();
            textBox8.Text = adata[num].Phone_number.ToString();

            textBox9.Text = adata[num].AlAT.ToString();
            textBox10.Text = adata[num].Albumen.ToString();
            textBox11.Text = adata[num].Antistreptolysin_O.ToString();
            textBox12.Text = adata[num].AsAt_aspartate_aminotransferase.ToString();
            textBox13.Text = adata[num].Gamma_GTP.ToString();
            textBox14.Text = adata[num].Atherogenicity_coefficient_Ka.ToString();
            textBox15.Text = adata[num].Creatini.ToString();
            textBox16.Text = adata[num].Lipase.ToString();
            textBox17.Text = adata[num].Sodium.ToString();
            textBox18.Text = adata[num].Total_lipids.ToString();
            textBox19.Text = adata[num].Total_bilirubin.ToString();
            textBox20.Text = adata[num].CRP_C_reactive_protein.ToString();
            textBox21.Text = adata[num].Chlorine.ToString();

            textBox22.Text = adata[num].Glucose.ToString();
            textBox23.Text = adata[num].Iron.ToString();
            textBox24.Text = adata[num].Potassium.ToString();
            textBox25.Text = adata[num].Calcium.ToString();
            textBox26.Text = adata[num].Urea.ToString();
            textBox27.Text = adata[num].Total_bilirubin.ToString();
            textBox28.Text = adata[num].Residual_Nitrogen.ToString();
            textBox29.Text = adata[num].Rheumofactor_rheumatoid_factor.ToString();
            textBox30.Text = adata[num].Triglycerides.ToString();
            textBox31.Text = adata[num].Phospholipids.ToString();
            textBox32.Text = adata[num].Cholesterol_Cholesterol.ToString();
            textBox33.Text = adata[num].Cholesterol_HDL.ToString();
            textBox34.Text = adata[num].LDL_cholesterol.ToString();

            pdata.Remove(pdata[num]);
            adata.Remove(adata[num]);
            listBox1.Items.Clear();
            for (int i = 0; i < pdata.Count; i++)
            {
                listBox1.Items.Add(pdata[i].PatientID + " " + pdata[i].PIN + " " + pdata[i].Surname + " " + pdata[i].Name);
            }
        }


		private void button3_Click(object sender, EventArgs e)
		{
			if(flag > 0)
			{
				edit_fun(sel_id);
			}
			int num = listBox1.SelectedIndex;
			edit_fun(num);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int num = listBox1.SelectedIndex;
			pdata.Remove(pdata[num]);
			adata.Remove(adata[num]);
			listBox1.Items.Clear();
			for (int i = 0; i < pdata.Count; i++)
			{
				listBox1.Items.Add(pdata[i].PatientID + " " + pdata[i].PIN + " " + pdata[i].Surname + " " + pdata[i].Name);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Search search = new Search(this.adata,this.pdata);
			this.Hide();
			search.ShowDialog();
			this.Show();
			flag = 1;
            if (flag > 0)
            {
				for(int i = 0; i < pdata.Count;i++) 
				{
					if (sel_id == pdata[i].PatientID) 
					{
						edit_fun(i);
					}
				}
            }
        }

		private void Open_Base_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			// получаем выбранный файл
			string filename = openFileDialog1.FileName;
			string path = filename;
			// асинхронное чтение
			XmlSerializer deserialiser = new XmlSerializer(typeof(List<Test_results>));
			TextReader FileStream = new StreamReader(filename);
			this.adata = (List<Test_results>)deserialiser.Deserialize(FileStream);
			FileStream.Close();
			for (int i = 0; i < adata.Count; i++)
			{
				listBox1.Items.Add(adata[i].PatientID + " " + adata[i].PIN + " " + adata[i].Surname + " " + adata[i].Name);
			}
			for (int i = 0; i < adata.Count; i++) 
			{
				Person per_data = new Person();
                per_data.PatientID = adata[i].PatientID;
                per_data.PIN = adata[i].PIN;//Personal identification number
                per_data.Name = adata[i].Name;
				per_data.Surname = adata[i].Surname;
				per_data.Patronymic = adata[i].Patronymic;
				per_data.Birthday = adata[i].Birthday;
				per_data.Address = adata[i].Address;
				per_data.Phone_number = adata[i].Phone_number;

				pdata.Add(per_data);
			}

		}

		private void Save_base_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			// получаем выбранный файл
			string filename = saveFileDialog1.FileName;
			// сохраняем текст в файл
			XmlSerializer serialiser = new XmlSerializer(typeof(List<Test_results>));
			TextWriter FileStream = new StreamWriter(filename);
			serialiser.Serialize(FileStream, adata);
			FileStream.Close();

			MessageBox.Show("Файл сохранен");
		}
    }
}
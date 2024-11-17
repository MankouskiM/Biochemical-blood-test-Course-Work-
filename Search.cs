using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Биохимический_анализ_крови;

namespace Биохимический_анализ_крови
{
	public partial class Search : Form 
	{
		List<Person> s_pdata = new List<Person>();
		int[] mas_id;
		public Search(List<Test_results> adata,List<Person> pdata)
		{
			InitializeComponent();
			int a = 0 ;
			int f = 0 ;
			Start start = new Start(a, f);
			s_pdata = pdata;
			for (int i = 0; i < pdata.Count; i++) 
			{
				listBox1.Items.Add(pdata[i].PatientID + " " + pdata[i].PIN + " " + pdata[i].Surname + " " + pdata[i].Name);
			}
			int[] mas_id = new int[adata.Count];
			for (int i = 0; i < adata.Count; i++)
			{
				mas_id[i] = adata[i].PatientID;
			}
		}
		int sel_id = 0;

        private void button1_Click_1(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			string key;
			if (radioButton1.Checked)
			{
				key = textBox1.Text;
				for  (int i = 0; i < s_pdata.Count; i++)
				{
					if (int.Parse(key) == s_pdata[i].PatientID)
					{
						listBox1.Items.Add(s_pdata[i].PatientID + " " + s_pdata[i].PIN + " " + s_pdata[i].Surname + " " + s_pdata[i].Name);
						sel_id = s_pdata[i].PatientID;
						break; 
					}
				}
			}
			if (radioButton2.Checked)
			{
				key = textBox1.Text;
                for (int i = 0; i < s_pdata.Count; i++)
                {
                    if (key == s_pdata[i].PIN)
                    {
                        listBox1.Items.Add(s_pdata[i].PatientID + " " + s_pdata[i].PIN + " " + s_pdata[i].Surname + " " + s_pdata[i].Name);
                        sel_id = s_pdata[i].PatientID;
                        break;
                    }
                }
            }
			if (radioButton3.Checked)
			{
                key = textBox1.Text;
                for (int i = 0; i < s_pdata.Count; i++)
                {
                    if (key == s_pdata[i].Surname)
                    {
                        listBox1.Items.Add(s_pdata[i].PatientID + " " + s_pdata[i].PIN + " " + s_pdata[i].Surname + " " + s_pdata[i].Name);
                        sel_id = s_pdata[i].PatientID;
                        break;
                    }
                }
            }
			if (radioButton4.Checked)
			{
                key = textBox1.Text;
                for (int i = 0; i < s_pdata.Count; i++)
                {
                    if (key == s_pdata[i].Name)
                    {
                        listBox1.Items.Add(s_pdata[i].PatientID + " " + s_pdata[i].PIN + " " + s_pdata[i].Surname + " " + s_pdata[i].Name);
                        sel_id = s_pdata[i].PatientID;
                        break;
                    }
                }
            }
			if (radioButton5.Checked)
			{
                key = textBox1.Text;
                for (int i = 0; i < s_pdata.Count; i++)
                {
                    if (key == s_pdata[i].Patronymic)
                    {
                        listBox1.Items.Add(s_pdata[i].PatientID + " " + s_pdata[i].PIN + " " + s_pdata[i].Surname + " " + s_pdata[i].Name);
                        sel_id = s_pdata[i].PatientID;
                        break;
                    }
                }
            }
			if (radioButton6.Checked)
			{
                key = textBox1.Text;
                for (int i = 0; i < s_pdata.Count; i++)
                {
                    if (key == s_pdata[i].Address)
                    {
                        listBox1.Items.Add(s_pdata[i].PatientID + " " + s_pdata[i].PIN + " " + s_pdata[i].Surname + " " + s_pdata[i].Name);
                        sel_id = s_pdata[i].PatientID;
                        break;
                    }
                }
            }
			if (radioButton7.Checked)
			{
                key = textBox1.Text;
                for (int i = 0; i < s_pdata.Count; i++)
                {
                    if (key == s_pdata[i].Birthday)
                    {
                        listBox1.Items.Add(s_pdata[i].PatientID + " " + s_pdata[i].PIN + " " + s_pdata[i].Surname + " " + s_pdata[i].Name);
                        sel_id = s_pdata[i].PatientID;
                        break;
                    }
                }
            }
			if (radioButton8.Checked)
			{
                key = textBox1.Text;
                for (int i = 0; i < s_pdata.Count; i++)
                {
                    if (key == s_pdata[i].Phone_number)
                    {
                        listBox1.Items.Add(s_pdata[i].PatientID + " " + s_pdata[i].PIN + " " + s_pdata[i].Surname + " " + s_pdata[i].Name);
                        sel_id = s_pdata[i].PatientID;
                        break;
                    }
                }
            }

		}
        private void button2_Click(object sender, EventArgs e)
        {
			int f = 1;
            Start start = new Start(sel_id,f);
            this.Hide();
        }
    }
}

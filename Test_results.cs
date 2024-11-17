using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Биохимический_анализ_крови
{
	public class Test_results : Person
	{
		public int AlAT; // АлАт норма 7-41 МЕ\Л
		public int Albumen; // Альбумин 60% 
		public int Antistreptolysin_O; // 100-200
		public int AsAt_aspartate_aminotransferase;// 10-38
		public int Gamma_GTP; // 10-106
		public int Atherogenicity_coefficient_Ka; // <3
		public int Creatini;//44-106
		public int Lipase; // 0-60
		public int Sodium; // 136-145
		public int Total_lipids; // 4-8
		public int Total_protein; //48-85
		public int CRP_C_reactive_protein; // >5
		public int Chlorine;// 98-107

		public double Glucose; // 3,33-5,55
		public double Iron; // 7,16-30,43
		public double Potassium; // 4.1-5.5
		public double Calcium; // 2.15-2.50
		public double Urea; // 2.5-8.3
		public double Total_bilirubin; // 8.5-20.55
		public double Residual_Nitrogen; //14.3-28.6
		public double Rheumofactor_rheumatoid_factor;// >30
		public double Triglycerides; //0.4-2.71
		public double Phospholipids; // 2.52-2.91
		public double Cholesterol_Cholesterol;//3.6-7.8
		public double Cholesterol_HDL; // 0.72-2.28
		public double LDL_cholesterol; // 1.92-4.51

		public Test_results(int ID, string pin, string name, string surname, 
			string patron, string birth, string add, string Phnum,
			int AlAT, int Alb, int Ant, int AsAt,int GTP, int AcKa, int Creatin, int Lipase, 
			int Sodium,int Total_lipids, int Total_protein, int CRP_C_reactive_protein, int Chlorine, 
			double Glucose, double Iron, double Potassium, double Calcium, double Urea, double Total_bilirubin, 
			double Residual_Nitrogen, double Rheumofactor_rheumatoid_factor, double Triglycerides, 
			double Phospholipids, double Cholesterol_Cholesterol, double Cholesterol_HDL, double LDL_cholesterol)
			:base(ID,pin,name,surname,patron,birth,add,Phnum)
		{

			this.AlAT = AlAT;
			this.Albumen = Alb;
			this.Antistreptolysin_O = Ant;
			this.AsAt_aspartate_aminotransferase = AsAt;
			this.Gamma_GTP = GTP;
			this.Atherogenicity_coefficient_Ka = AcKa;
			this.Creatini = Creatin;
			this.Lipase = Lipase;
			this.Sodium =Sodium;
			this.Total_lipids = Total_lipids;
			this.Total_protein = Total_protein;
			this.CRP_C_reactive_protein = CRP_C_reactive_protein;
			this.Chlorine = Chlorine;

			this.Glucose = Glucose;
			this.Iron = Iron;
			this.Potassium = Potassium;
			this.Calcium = Calcium;
			this.Urea = Urea;
			this.Total_bilirubin = Total_bilirubin;
			this.Residual_Nitrogen = Residual_Nitrogen;
			this.Rheumofactor_rheumatoid_factor = Rheumofactor_rheumatoid_factor;
			this.Triglycerides = Triglycerides;
			this.Phospholipids = Phospholipids;
			this.Cholesterol_Cholesterol = Cholesterol_Cholesterol;
			this.Cholesterol_HDL = Cholesterol_HDL;
			this.LDL_cholesterol = LDL_cholesterol;
		}

		public Test_results() {}
	}
}

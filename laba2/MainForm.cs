/*
 * Created by SharpDevelop.
 * User: adfgh
 * Date: 01-03-2019
 * Time: 13:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace laba2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		Parallelepiped P=new Parallelepiped ();
		void Button1Click(object sender, EventArgs e)
		{
			P.setA (Convert.ToDouble(textBox1.Text));
			P.setB (Convert.ToDouble(textBox2.Text));	
			P.setC (Convert.ToDouble(textBox3.Text));			
		}
		void Button2Click(object sender, EventArgs e)
		{
			label4.Text=P.Ploschad().ToString();
			label7.Text=P.Obem().ToString();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Parallelepiped P=new Parallelepiped ();	
			P.setA (Convert.ToDouble(textBox1.Text));
			P.setB (Convert.ToDouble(textBox2.Text));
			P.setC (Convert.ToDouble(textBox3.Text));
			label4.Text=P.Ploschad().ToString();
			label7.Text=P.Obem().ToString();
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		class Parallelepiped {
			double a, b, c;
			public void setA (double X) { a=X ;}
			public void setB (double X) { b=X ;}
			public void setC (double X) { c=X ;}
			public double geta () {return a;}
			public double getb () {return b;}
			public double getc() {return c;}
			public double Ploschad () {return 2*getc()*(geta()+getb()) ;}
			public double Obem () {return geta()*getb()*getc() ;}
		}
		
	}
}

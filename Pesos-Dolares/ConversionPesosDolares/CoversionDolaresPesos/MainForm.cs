
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CoversionDolaresPesos
{
	
	public partial class MainForm : Form
	{
		double a,b,resultado;
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
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			
			try{
					
				a = Double.Parse(textBox1.Text);
				b= Double.Parse(textBox2.Text);
			
				resultado = a/b;
		 
			textBox3.Text = resultado.ToString();
		
				}
		    catch(FormatException) {
				
			   if (textBox1.Text == ""|| textBox2.Text == ""){
				MessageBox.Show(" Error Campos Vacios !!");
				}
				else
				MessageBox.Show(" Error No se Pueden Introducir Caracteres !!");	
			}	
				
				 if (textBox1.Text.StartsWith("0") || textBox2.Text.StartsWith("0")){
			 textBox3.Clear();
		        MessageBox.Show("Error No se Puede Realizar el Cambio con los Campos en 0 !!");
		       	
	       }			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
	}
		
}
		
	


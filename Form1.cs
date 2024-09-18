using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Entity;
using ToDo.Repository;

namespace ToDo
{
	public partial class Form1 : Form
	{
		private LiveStockEntity lse = new LiveStockEntity();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string connectionString = "Server=ANPC;Database=baitap;Trusted_Connection=True;";
			BaseRepository repository = BaseRepository.GetInstance(connectionString);
			lse = repository.GetAll();
			string theSound = "";
			Cow cow = new Cow();
			Sheep sheep = new Sheep();
			Goat goat = new Goat();
			for(int i = 0;i < lse.CowNumber; i++)
			{
				theSound += cow.MakeSound();
			}
			for(int i = 0;i < lse.SheepNumber; i++)
			{
				theSound += sheep.MakeSound();
			}
			for(int i = 0;i < lse.GoatNumber; i++)
			{
				theSound += goat.MakeSound();
			}
			this.label1.Text=theSound;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}

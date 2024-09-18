﻿using System;
using System.Windows.Forms;
using ToDo.Entity;
using ToDo.Repository;

namespace ToDo
{
	public partial class Form1 : Form
	{
		private LiveStockEntity lse = new LiveStockEntity();
		private string connectionString = "Server=ANPC;Database=baitap;Trusted_Connection=True;";
		BaseRepository repository; 
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			BaseRepository.GetInstance(connectionString);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void giveBirthBtn_Click(object sender, EventArgs e)
		{
			Form newForm = new Form();
			
			LiveStockEntity liveStockEntity = BaseRepository.GetInstance(connectionString).GetAll();
			Cow cow = new Cow();
			Sheep sheep = new Sheep();
			Goat goat = new Goat();
			int totalCow = 0;
			int totalSheep = 0;
			int totalGoat = 0;
			for(int i = 0; i < liveStockEntity.CowNumber;i++)
			{
				totalCow += cow.GiveBirth();
			}
			for(int i = 0; i < liveStockEntity.SheepNumber;i++)
			{
				totalSheep += sheep.GiveBirth();
			}
			for(int i = 0; i < liveStockEntity.GoatNumber;i++)
			{
				totalGoat += goat.GiveBirth();
			}
			Label cowLable = new Label
			{
				Text = "Cow:" + totalCow.ToString(),
				Location = new System.Drawing.Point(0, 0),
				Width = 50,
				Height = 50,
			};
			Label sheepLable = new Label
			{
				Text = "Sheep:" + totalSheep.ToString(),
				Location = new System.Drawing.Point(50, 0),
				Width = 50,
				Height = 50,
			};
			Label goatLable = new Label
			{
				Text = "Goat:" + totalGoat.ToString(),
				Location = new System.Drawing.Point(100, 0),
				Width = 50,
				Height = 50,
			};

			newForm.Controls.Add(goatLable);	
			newForm.Controls.Add(sheepLable);	
			newForm.Controls.Add(cowLable);	
		
			newForm.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int.TryParse(cowInput.Text, out int cow);
			int.TryParse(sheepInput.Text, out int sheep);			
			int.TryParse(goatInput.Text, out int goat);

			BaseRepository.GetInstance(this.connectionString).Save(cow, sheep, goat);
			
			//Reset input to empty
			cowInput.Text = string.Empty;
			sheepInput.Text = string.Empty;
			goatInput.Text = string.Empty;
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}
	}
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Entity;

namespace ToDo.Repository
{
	public class BaseRepository
	{
		private static BaseRepository instance = null;
		private static SqlConnection TheConnection;
		private string connectionString;
		private BaseRepository()
		{

		}
		public static BaseRepository GetInstance(string connectionString)
		{
			if (instance == null)
			{
				instance = new BaseRepository(connectionString);
			}
			return instance;
		}
		private BaseRepository(string connectionString)
		{
			TheConnection = new SqlConnection(connectionString);
			TheConnection = new SqlConnection(connectionString);
		}

		public LiveStockEntity GetAll()
		{
			LiveStockEntity liveStock = new LiveStockEntity();
			try
			{
				TheConnection.Open();
				string query = "SELECT * FROM livestock";
				SqlCommand command = new SqlCommand(query, TheConnection);
				SqlDataReader reader = command.ExecuteReader();
				reader.Read();
				object cow = reader["cow"];
				object sheep = reader["sheep"];
				object goat = reader["goat"];
				liveStock.CowNumber = (int)cow;
				liveStock.SheepNumber = (int)sheep;
				liveStock.GoatNumber = (int)goat;
				reader.Close();
				return liveStock;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			TheConnection.Close();
			return liveStock;
		}
		public void Save(int cow, int sheep, int goat)
		{

			TheConnection.Open();
			string query = "UPDATE livestock SET cow = @cow, sheep = @sheep, goat = @goat";
			SqlCommand command = new SqlCommand(query, TheConnection);
			command.Parameters.AddWithValue("@cow", cow);
			command.Parameters.AddWithValue("@sheep", sheep);
			command.Parameters.AddWithValue("@goat", goat);
			command.ExecuteNonQuery();
			TheConnection.Close();
		}

	}
}

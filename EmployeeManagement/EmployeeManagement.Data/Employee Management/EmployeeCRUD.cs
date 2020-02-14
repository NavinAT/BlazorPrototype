using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.JSInterop;

namespace EmployeeManagement.Data
{
	public class EmployeeCRUD
	{
		#region Constants
		private const string CONNECTION_STRING = "Data Source=MS-00603;Initial Catalog=EmployeeInformation;Persist Security Info=True;User ID=sa;Password=password-123";
		#endregion

		#region Fields
		private static SqlCommand sqlCommand;
		#endregion

		#region Publics
		public static void CreateEmployee(EmployeeInformation employee)
		{
			using SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
			const string strInsertQuery = "insert into Employee(EmployeeId, EmployeeName, Department, salary, Dob, City) values(@EmployeeNumber, @EmployeeName, @Department, @Salary, @Dob, @City)";
			sqlCommand = new SqlCommand(strInsertQuery, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@EmployeeNumber", Guid.NewGuid().ToString());
			sqlCommand.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
			sqlCommand.Parameters.AddWithValue("@Department", employee.Department);
			sqlCommand.Parameters.AddWithValue("@Salary", employee.Salary);
			sqlCommand.Parameters.AddWithValue("@Dob", employee.Dob.Date);
			sqlCommand.Parameters.AddWithValue("@City", employee.City);

			OpenAndCloseConnection(sqlConnection, sqlCommand);
		}

		public static List<EmployeeInformation> FetchEmployees()
		{
			List<EmployeeInformation> listEmployees = new List<EmployeeInformation>();
			using SqlConnection con = new SqlConnection(CONNECTION_STRING);
			const string strSelectQuery = "select * from Employee";
			sqlCommand = new SqlCommand(strSelectQuery, con);
			con.Open();

			SqlDataReader sqlReader = sqlCommand.ExecuteReader();
			if (sqlReader.HasRows)
			{
				while (sqlReader.Read())
				{
					EmployeeInformation employee = new EmployeeInformation
					{
						EmployeeNumber = Guid.Parse(sqlReader["EmployeeId"].ToString()),
						EmployeeName = sqlReader["EmployeeName"].ToString(),
						Department = sqlReader["Department"].ToString(),
						Salary = Convert.ToInt32(sqlReader["salary"]),
						Dob = Convert.ToDateTime(sqlReader["Dob"]),
						City = sqlReader["City"].ToString()
					};
					listEmployees.Add(employee);
				}

				con.Close();
				sqlCommand.Dispose();
			}

			return listEmployees;
		}

		public static EmployeeInformation FetchSingleEmployee(Guid uqEmployeeNumber)
		{
			EmployeeInformation employee = null;
			using SqlConnection con = new SqlConnection(CONNECTION_STRING);
			const string strQuery = "Select * from Employee where EmployeeId = @EmployeeNumber";

			sqlCommand = new SqlCommand(strQuery, con);
			sqlCommand.Parameters.AddWithValue("@EmployeeNumber", uqEmployeeNumber);

			con.Open();
			SqlDataReader dataReader = sqlCommand.ExecuteReader();
			while(dataReader.Read())
			{
				employee = new EmployeeInformation
				           {
					           EmployeeNumber = Guid.Parse(dataReader["EmployeeId"].ToString()),
					           EmployeeName = dataReader["EmployeeName"].ToString(),
					           Department = dataReader["Department"].ToString(),
					           Salary = Convert.ToInt32(dataReader["salary"]),
					           Dob = Convert.ToDateTime(dataReader["Dob"]),
					           City = dataReader["City"].ToString()
				           };
			}

			return employee;
		}

		public static void EditEmployee(Guid uqEmployeeNumber, EmployeeInformation employee)
		{
			using SqlConnection con = new SqlConnection(CONNECTION_STRING);
			const string strUpdateQuery = "Update Employee set EmployeeName = @EmployeeName, Department = @Department, salary = @salary, Dob = @Dob, City = @City where EmployeeId = @EmployeeNumber";

			sqlCommand = new SqlCommand(strUpdateQuery, con);
			sqlCommand.Parameters.AddWithValue("@EmployeeNumber", uqEmployeeNumber);
			sqlCommand.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
			sqlCommand.Parameters.AddWithValue("@Department", employee.Department);
			sqlCommand.Parameters.AddWithValue("@salary", employee.Salary);
			sqlCommand.Parameters.AddWithValue("@Dob", employee.Dob);
			sqlCommand.Parameters.AddWithValue("@City", employee.City);

			OpenAndCloseConnection(con, sqlCommand);
		}

		[JSInvokable]
		public static void DeleteEmployee(Guid gEmployeeId)
		{
			using SqlConnection con = new SqlConnection(CONNECTION_STRING);
			string strDeleteQuery = "Delete from Employee where EmployeeId = @EmployeeNumber";

			sqlCommand = new SqlCommand(strDeleteQuery, con);
			sqlCommand.Parameters.AddWithValue("@EmployeeNumber", gEmployeeId);

			OpenAndCloseConnection(con, sqlCommand);
		}

		public static List<string> FetchDropDownList(string strTableName)
		{
			List<string> DropDownValues = new List<string>();

			using SqlConnection connection = new SqlConnection(CONNECTION_STRING);
			string strQuery = $"Select * from {strTableName}";
			sqlCommand = new SqlCommand(strQuery, connection);

			connection.Open();
			SqlDataReader dataReader = sqlCommand.ExecuteReader();

			while(dataReader.Read())
			{
				string strListvalue = dataReader["CityName"].ToString();

				DropDownValues.Add(strListvalue);
			}

			return DropDownValues;
		}
		#endregion

		#region Privates
		private static void OpenAndCloseConnection(SqlConnection con, SqlCommand command)
		{
			con.Open();
			command.ExecuteNonQuery();

			con.Close();
			con.Dispose();
		}
		#endregion
	}
}
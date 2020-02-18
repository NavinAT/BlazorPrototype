using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BlazorAppCRUD
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
			const string strInsertQuery = "insert into Employee(EmployeeId, EmployeeName, Department, salary, DOB, City) values(@EmployeeId, @EmployeeName, @Department, @Salary, @DOB, @City)";
			sqlCommand = new SqlCommand(strInsertQuery, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@EmployeeId", Guid.NewGuid().ToString());
			sqlCommand.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
			sqlCommand.Parameters.AddWithValue("@Department", employee.Department);
			sqlCommand.Parameters.AddWithValue("@Salary", employee.Salary);
			sqlCommand.Parameters.AddWithValue("@DOB", employee.DOB.Date);
			sqlCommand.Parameters.AddWithValue("@City", employee.City);

			OpenAndCloseConnection(sqlConnection, sqlCommand);
		}

		public static List<EmployeeInformation> FetchEmployees()
		{
			List<EmployeeInformation> lstEmployees = new List<EmployeeInformation>();
			using SqlConnection con = new SqlConnection(CONNECTION_STRING);
			const string strSelectQuery = "select * from Employee";
			sqlCommand = new SqlCommand(strSelectQuery, con);
			con.Open();

			SqlDataReader sqlReader = sqlCommand.ExecuteReader();
			if(sqlReader.HasRows)
			{
				while(sqlReader.Read())
				{
					EmployeeInformation employee = new EmployeeInformation
					                               {
						                               EmployeeId = sqlReader["EmployeeId"].ToString(),
						                               EmployeeName = sqlReader["EmployeeName"].ToString(),
						                               Department = sqlReader["Department"].ToString(),
						                               Salary = Convert.ToInt32(sqlReader["salary"]),
						                               DOB = Convert.ToDateTime(sqlReader["DOB"]),
						                               City = sqlReader["City"].ToString()
					                               };
					lstEmployees.Add(employee);
				}

				con.Close();
				sqlCommand.Dispose();
			}

			return lstEmployees;
		}

		public static EmployeeInformation FetchSingleEmployee(string strEmployeeId)
		{
			EmployeeInformation employee = null;
			using SqlConnection con = new SqlConnection(CONNECTION_STRING);
			const string strQuery = "Select * from Employee where EmployeeId = @EmployeeId";

			sqlCommand = new SqlCommand(strQuery, con);
			sqlCommand.Parameters.AddWithValue("@EmployeeId", strEmployeeId);

			con.Open();
			SqlDataReader dataReader = sqlCommand.ExecuteReader();
			while(dataReader.Read())
			{
				employee = new EmployeeInformation
				           {
					           EmployeeId = dataReader["EmployeeId"].ToString(),
					           EmployeeName = dataReader["EmployeeName"].ToString(),
					           Department = dataReader["Department"].ToString(),
					           Salary = Convert.ToInt32(dataReader["salary"]),
					           DOB = Convert.ToDateTime(dataReader["DOB"]),
					           City = dataReader["City"].ToString()
				           };
			}

			return employee;
		}

		public static void EditEmployee(string strEmployeeId, EmployeeInformation employee)
		{
			using SqlConnection con = new SqlConnection(CONNECTION_STRING);
			const string strUpdateQuery = "Update Employee set EmployeeName = @EmployeeName, Department = @Department, salary = @salary, DOB = @DOB, City = @City where EmployeeId = @EmployeeId";

			sqlCommand = new SqlCommand(strUpdateQuery, con);
			sqlCommand.Parameters.AddWithValue("@EmployeeId", strEmployeeId);
			sqlCommand.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
			sqlCommand.Parameters.AddWithValue("@Department", employee.Department);
			sqlCommand.Parameters.AddWithValue("@salary", employee.Salary);
			sqlCommand.Parameters.AddWithValue("@DOB", employee.DOB);
			sqlCommand.Parameters.AddWithValue("@City", employee.City);

			OpenAndCloseConnection(con, sqlCommand);
		}

		public static void DeleteEmployee(string strEmployeeId)
		{
			using SqlConnection con = new SqlConnection(CONNECTION_STRING);
			string strDeleteQuery = "Delete from Employee where EmployeeId = @EmployeeId";

			sqlCommand = new SqlCommand(strDeleteQuery, con);
			sqlCommand.Parameters.AddWithValue("@EmployeeId", strEmployeeId);

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
using System.Data;
using System.Linq;

namespace BlazorPrototype
{
	public class InsuranceTable
	{
		#region Fields
		#endregion

		#region Properties
		public DataTable Insurance { get; private set; }
		#endregion

		#region Constructors
		public InsuranceTable()
		{
			CreateTable();
		}
		#endregion

		#region Publics
		public DataRow CreateDataRow()
		{
			return this.Insurance.NewRow();
		}

		public DataRow FindById(int nId)
		{
			DataRow row = this.Insurance.Select().FirstOrDefault(r => ((int) r["Id"] == nId));
			return row;
		}

		public void Add(DataRow rowInsurance)
		{
			int nId = 0;
			if(this.Insurance.Rows.Count > 0)
			{
				DataRow rowPrev = this.Insurance.Rows[this.Insurance.Rows.Count - 1];
				nId = (int) rowPrev["Id"];
			}

			rowInsurance["Id"] = nId + 1;

			this.Insurance.Rows.Add(rowInsurance);
			this.Insurance.AcceptChanges();
		}

		public void Update(int nId, string strCaption, string strShortCaption)
		{
			DataRow row = this.Insurance.Rows[nId];
			row["Caption"] = strCaption;
			row["ShortCaption"] = strShortCaption;
		}

		public void Remove(int nId)
		{
			DataRow row = FindById(nId);
			if(row != null)
			{
				this.Insurance.Rows.Remove(row);
				this.Insurance.AcceptChanges();
			}
		}
		#endregion

		#region Privates
		private void CreateTable()
		{
			this.Insurance = new DataTable();

			this.Insurance.Columns.AddRange(new DataColumn[3]
			                                {
				                                new DataColumn("Id", typeof(int)),
				                                new DataColumn("Caption", typeof(string)),
				                                new DataColumn("ShortCaption", typeof(string))
			                                });
			this.Insurance.Rows.Add(1, "Bajaj Insurance", "BI");
			this.Insurance.Rows.Add(2, "Life Insurance", "LI");
			this.Insurance.AcceptChanges();
		}
		#endregion
	}
}
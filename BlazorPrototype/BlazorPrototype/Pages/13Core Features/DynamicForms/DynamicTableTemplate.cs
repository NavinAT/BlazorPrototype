using System.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorPrototype
{
	public class DynamicTableTemplate
	{
		private static bool _showEdit;
		private static bool _showDelete;
		private static string _ComponentName;

		#region Publics
		public static RenderFragment BuildTable(DataTable tabEmployee, bool bShowEdit, bool bShowDelete, string strComponentName)
		{
			_showEdit = bShowEdit;
			_showDelete = bShowDelete;
			_ComponentName = strComponentName;

			void RenderFragment(RenderTreeBuilder builder)
			{
				builder.OpenElement(0, "table");
				builder.AddAttribute(1, "class", "table");
				builder.OpenElement(2, "tbody");
				builder.OpenElement(3, "tr");
				foreach(DataColumn col in tabEmployee.Columns)
				{
					builder.OpenElement(4, "th");
					builder.AddContent(5, col.ColumnName);
					builder.CloseElement();
				}

				builder.CloseElement();

				foreach(DataRow row in tabEmployee.Rows)
				{
					builder.OpenElement(6, "tr");
					foreach(DataColumn col in tabEmployee.Columns)
					{
						builder.OpenElement(7, "td");
						builder.AddContent(8, row[col.ColumnName]);
						builder.CloseElement();
					}

					if(_showEdit)
					{
						builder.OpenElement(9, "td");
						builder.OpenElement(10, "a");
						builder.AddAttribute(11, "href", $"{_ComponentName}Edit/{row[0]}");
						builder.AddContent(12, "Edit");
						builder.CloseElement();
						builder.CloseElement();
					}

					if(_showDelete)
					{
						builder.OpenElement(13, "td");
						builder.OpenElement(14, "a");
						builder.AddAttribute(15, "href", $"{_ComponentName}Delete/{row[0]}");
						builder.AddContent(16, "Delete");
						builder.CloseElement();
						builder.CloseElement();
					}

					builder.CloseElement();
				}

				builder.CloseElement();
				builder.CloseElement();
			}

			return RenderFragment;
		}
		#endregion
	}
}
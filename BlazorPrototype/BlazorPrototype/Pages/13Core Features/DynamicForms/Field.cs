using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorPrototype
{
	public class Field : ComponentBase
	{
		#region Properties
		[Parameter]
		public string ControlType { get; set; }

		[Parameter]
		public string LabelText { get; set; }

		[Parameter]
		public string BindingField { get; set; }

		[Parameter]
		public object Bind { get; set; }

		[Parameter]
		public string Code { get; set; }

		[Parameter]
		public object Obj { get; set; }
		#endregion

		#region Protecteds
		protected override void BuildRenderTree(RenderTreeBuilder builder)
		{
			base.BuildRenderTree(builder);
			switch(ControlType)
			{
				case "TBText":
					builder.AddMarkupContent(0, $"<label>{this.LabelText}</label><br />");
					builder.OpenElement(1, "input");
					builder.AddAttribute(2, "type", "text");
					builder.AddAttribute(3, "value", this.Bind);
					builder.AddAttribute(4, "onchange", EventCallback.Factory.CreateBinder(this.Obj,
					                                                                       ValueChangeEvent, this.Bind.ToString(), CultureInfo.InvariantCulture));
					builder.CloseElement();
					builder.AddMarkupContent(5, "<br />");
					break;

				case "TBNumber":
					builder.AddMarkupContent(0, $"<label>{this.LabelText}</label><br />");
					builder.OpenElement(1, "input");
					builder.AddAttribute(2, "type", "number");
					builder.AddAttribute(3, "value", this.Bind);
					builder.AddAttribute(4, "onchange", EventCallback.Factory.CreateBinder(this.Obj,
					                                                                       _value => ValueChangeEvent(_value), (int)this.Bind, CultureInfo.InvariantCulture));
					builder.CloseElement();
					builder.AddMarkupContent(5, "<br />");
					break;
			}

			
		}

		public void ValueChangeEvent(object obj)
		{
			// DataTable
			DataRow row = this.Obj as DataRow;
			if(row != null)
			{
				row[this.LabelText] = obj;
				return;
			}

			// POCO members
			PropertyInfo[] pro = this.Obj.GetType().GetProperties();
			PropertyInfo p = pro.FirstOrDefault(info => info.Name.Equals(this.LabelText));
			p?.SetValue(this.Obj, obj, null);
		}
		#endregion
	}
}
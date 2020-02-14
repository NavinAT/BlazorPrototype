using System;
using System.Collections.Generic;
using EmployeeManagement.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace EmployeeManagement
{
    public class EditEmployeeBase : ComponentBase
    {
        #region Fields

        protected EmployeeInformation employee = new EmployeeInformation();
        protected List<string> DropDownValues;

        #endregion

        #region Properties

        [Parameter] public Guid EmployeeNumber { get; set; }

        [Parameter] public bool IsAllowToDisplay { get; set; }

        [Inject] public EmployeeDetails EmployeeDetails { get; set; }

        [Parameter] public EventCallback OnClick { get; set; }

        [Inject] protected NavigationManager NavigationManager { get; set; }

        [Inject] protected IJSRuntime JSRuntime { get; set; }

        private Guid qEmployeeNumber { get; set; }

        #endregion

        #region Protecteds

        protected override void OnInitialized()
        {
            employee = EmployeeCRUD.FetchSingleEmployee(EmployeeNumber);

            var strTableName = nameof(employee.City);
            DropDownValues = EmployeeCRUD.FetchDropDownList(strTableName);
        }

        protected override void OnParametersSet()
        {
            qEmployeeNumber = EmployeeNumber;
        }

        protected void Cancel()
        {
            NavigationManager.NavigateTo("createemployee");
            NavigationManager.NavigateTo("listemployees");
        }

        #endregion
    }
}
function DeleteConfirmation(EmployeeId) {
    var result = confirm("Do you want to Delete");

    if (result) {
        DotNet.invokeMethodAsync("EmployeeManagement.Data", "DeleteEmployee", EmployeeId);

        alert("Employee record deleted");
    }
}

function ChangeElementColor() {
    var headerElement = document.getElementById("myheader");

    headerElement.addEventListener("mouseover",
        function changeTheColorOfHeader()
        {
            headerElement.style.color = "chocolate";
            headerElement.style.fontFamily = "-apple-system";
        });
    headerElement.addEventListener("mouseout",
        function changeTheColorToNormal()
        {
            headerElement.style.color = "black";
            headerElement.style.fontFamily = "'Helvetica Neue', Helvetica, Arial, sans-serif";
        });

}

function ValidationAlert() {
    alert('Validated successfully');
}
--ForUC3--
Create Procedure UpdateSalaryProcedure
(
@EmployeeId int,
@EmployeeName varchar(255),
@BasicPay float
)
As
Begin
Update Employee
Set BasicPay=@BasicPay where EmployeeID=@EmployeeId AND EmployeeName=@EmployeeName
End



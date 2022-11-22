--ForUC4--
Create Procedure UpdateSalaryProcedure_ByName
(
@EmployeeName varchar(255),
@BasicPay float
)
As
Begin
Update Employee
Set BasicPay=@BasicPay where EmployeeName=@EmployeeName
End

--ForUC5--

Create Procedure EmployeeBetweenDates
(
@SDate Date,
@EDate Date
)
As
Begin
select * from Employee where StartDate Between CAST(@SDate AS DATE) And CAST(@EDate AS DATE)
End

--ForUC7--
create procedure InsertEmployee
(
@EmployeeName varchar(255),
@EmployeePhoneNumber varchar(255),
@EmployeeAddress varchar(255),
@EmployeeDepartment varchar(255),
@EmployeeGender char(1),
@Basicpay float,
@Deduction float,
@TaxablePay float,
@Tax float,
@NetPay float,
@StartDate date,
@City varchar(255),
@Country varchar(255)
)
As
Begin
Insert Into Employee values(@EmployeeName,@EmployeePhoneNumber,@EmployeeAddress,@EmployeeDepartment,@EmployeeGender,@Basicpay,@Deduction,@TaxablePay,@Tax,@NetPay,@StartDate,@City,@Country)
Insert Into Employee values('Terrisa',789654123,'Juhu','Finance','F',10000,200,100,100,200,'2019/03/10','Kolhapur','India')
END

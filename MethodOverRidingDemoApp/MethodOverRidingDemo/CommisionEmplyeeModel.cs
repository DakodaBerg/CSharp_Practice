namespace MethodOverRidingDemo
{
    public class  CommisionEmplyeeModel : EmployeeModel

    {
        public decimal CommissionAmount { get; set; }

        public override decimal GetPaycheckAmount(int hoursWorked)
        {
            decimal initialPay = base.GetPaycheckAmount(hoursWorked);
            return initialPay + CommissionAmount;
        }
    }
}

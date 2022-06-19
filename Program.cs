using Ques_1;
Console.WriteLine("Welcome to Employee Wage Computation program");
int r = Wage.Rndm();            //Calling a static function
if (r == 1)
{
    Console.WriteLine("Employee is Present");
    Console.WriteLine("Daily wage of the employee is = " + (Wage.wagee()));
}
else
{
    Console.WriteLine("Employee is Absent");
}

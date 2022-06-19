using Ques_1;
Console.WriteLine("Welcome to Employee Wage Computation program");
Wage random = new Wage();         //creating object for class wage for non-static functions
int r = random.rndm();            //Calling a non-static function
if (r == 1)
{
    Console.WriteLine("Employee is Present");
    int wa = Wage.wage();
    if (wa != 0)
        Console.WriteLine("Daily wage of the employee is = " + wa);
}
else
{
    Console.WriteLine("Employee is Absent");
}
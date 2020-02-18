class Exercise
{
    void ShowEmployee(int employeeNumber, string fullName, string gender, double hourlySalary)
    {
        System.Console.WriteLine("Employee Record");
        System.Console.WriteLine("-----------------------------");
        System.Console.Write("Employee #:    ");
        System.Console.WriteLine(employeeNumber); // นำพารามิเตอร์มาแสดงที่หน้าจอ
        System.Console.Write("Full Name:     ");
        System.Console.WriteLine(fullName); // นำพารามิเตอร์มาแสดงที่หน้าจอ
        System.Console.Write("Gender:        ");
        System.Console.WriteLine(gender);   // นำพารามิเตอร์มาแสดงที่หน้าจอ
        System.Console.Write("Hourly Salary: ");
        System.Console.WriteLine(hourlySalary); // นำพารามิเตอร์มาแสดงที่หน้าจอ
    }
    static int Main()
    {
        Exercise exo = new Exercise();
        // เรียกใช้งานโดยส่งพารามิเตอร์ทั้ง 4 ตัวไปให้เมธอด
        exo.ShowEmployee(572948, "Sompong Jaidee", "M", 450.00D);

        System.Console.ReadKey();
        return 0;
    }
}
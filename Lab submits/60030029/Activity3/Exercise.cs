class Exercise
{
    void ShowEmployee(int employeeNumber, string fullName, string gender, double hourlySalary = 500.00D)
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

        // เรียกใช้เมธอดโดยระบุชื่อพารามิเตอร์ทั้ง 4 ตัวตามลำดับโดยระบุชื่อพารามิเตอร์
        exo.ShowEmployee(fullName: "Somsri Jaiorn", gender: "F", employeeNumber: 84654);

        // เรียกใช้เมธอดโดยระบุชื่อพารามิเตอร์และไม่สนใจลำดับ พร้อมละ default parameter
        exo.ShowEmployee(fullName: "Somsri Jaiorn", gender: "F", employeeNumber: 84654);


        System.Console.ReadKey();
        return 0;
    }
}
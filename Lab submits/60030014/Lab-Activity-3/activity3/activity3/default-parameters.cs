class Exercise
{
    void ShowEmployee(int employeeNumber, string fullName, string gender, double hourlySalary = 500.00D)
    {
        ...
        // ไม่ต้องแก้ไข method body
        ...
    }

    static int Main()
    {
        Exercise exo = new Exercise();
        // เรียกใช้งานโดยส่งพารามิเตอร์ทั้ง 4 ตัวไปให้เมธอด
        exo.ShowEmployee(572948, "Sompong Jaidee", "M", 450.00D);
        // ละพารามิเตอร์ 1 ตัว จากด้านขวามือสุด
        exo.ShowEmployee(572948, "Somchai Jaided", "M");
        // ละพารามิเตอร์ 2 ตัว จากด้านขวามือสุด
        exo.ShowEmployee(572948, "Sommai Jaisoo");

        System.Console.ReadKey();
        return 0;
    }
}
class Exercise
{
    ...
    // ไม่ต้องแก้ไขเมธอด ShowEmployee
    ...

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
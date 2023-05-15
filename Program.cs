using System;

class Program 
{    
    static void Main(string[] args) 
    {
        int vMax = int.Parse(Console.ReadLine()); //ความจุของถังน้ำ
        int vDrink = int.Parse(Console.ReadLine()); //ปริมาตรน้ำเฉลี่ยที่ผู้เข้าร่วมโครงการดื่มในแต่ละช่วงพัก
        int vFill = int.Parse(Console.ReadLine()); //ปริมาตรน้ำที่เติมได้ในแต่ละรอบเติมน้ำ

        int tDrink = int.Parse(Console.ReadLine()); //ระยะเวลาคั่นระหว่างช่วงพัก
        int tFill = int.Parse(Console.ReadLine()); //ระยะเวลาคั่นระหว่างรอบเติมน้ำ
        int tDay = int.Parse(Console.ReadLine()); //ระยะเวลารวมของกิจกรรมตั้งแต่เริ่มจนจบวัน

        if(vMax >= 0 && vDrink >= 0 && vFill >= 0 && tDrink >= 0 && tFill >= 0 && tDay >= 0)
        {

            if(vMax + (vFill * vFill) > vDrink * (tDay / tDrink))
            {
                Console.WriteLine("Enough Water");
            }
            else
            {
                Console.WriteLine("Not Enough");
            }
        }
        else
        {
            Console.WriteLine("Input Positive Number"); // test
        }
        if((tDay / tFill) * vFill > vMax + ((tDay / tFill)* vFill))
        {
            Console.WriteLine("Overflow Water");
        }
        else
        {
            Console.WriteLine("");
        }
    }
}

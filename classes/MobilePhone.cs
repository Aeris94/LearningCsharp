using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Net;

//Define a class, which contains information about a mobile phone: model, manufacturer, price, 
//owner, features of the battery(model, idle time and hours talk) and features of the 
//screen(size and colors).

//Declare several constructors for each of the classes created by the previous task, 
//which have different lists of parameters(for complete information about a student or part of it).
//Data fields that are unknown have to be initialized respectively with null or 0.

//To the class of mobile phone in the previous two tasks, add a static field nokiaN95, 
//which stores information about mobile phone model Nokia N95.Add a method to the same class, 
//which displays information about this static field.

//Add an enumeration BatteryType, which contains the values for type of the 
//battery(Li-Ion, NiMH, NiCd, …) and use it as a new field for the class Battery.

//Create a class Call, which contains information about a call made via mobile phone.
//It should contain information about date, time of start and duration of the call.

//Add a property for keeping a call history – CallHistory, which holds a list of call records.

//In GSM class add methods for adding and deleting calls(Call) in the archive of mobile phone calls.
//Add method, which deletes all calls from the archive.

namespace Program
{ 
    public class MobilePhone
    {
        private static MobilePhone NokiaN95 = new MobilePhone("N95", "Nokia", new Battery(Battery.BatteryType.Li_Ion, 100, 200), new Screen(3.5, 10000));

        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Screen screen;
        private List<Call> callHistory;

        public List<Call> CallHistory { get { return this.callHistory; } }
        public string Model { get { return this.model; } }
        public string Manufacurer { get { return this.manufacturer; }}
        public double? Price { get { return this.price; } set { this.price = value; } }
        public string Owner { get { return this.owner; } set { this.owner = value; } }

        public MobilePhone() : this(null, null, null, null, null, null)
        {
        }

        public MobilePhone(string model, string manufacturer, Battery battery, Screen screen) : this(model, manufacturer, null, null, battery, screen)
        {
        }

        public MobilePhone(string model, string manufacturer, double? price, string owner, Battery battery, Screen screen)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.screen = screen;
        }

        public static void InfoNokia95()
        {
            Console.WriteLine("Model: {0} {1}", NokiaN95.Manufacurer, NokiaN95.Model);
            Console.WriteLine("Battery: {0}", NokiaN95.battery.Model);
            Console.WriteLine("IdleTime: {0}", NokiaN95.battery.IdleTime);
            Console.WriteLine("HoursTalk: {0}", NokiaN95.battery.HoursTalk);
            Console.WriteLine("Screen: Size: {0} Colors: {1}", NokiaN95.screen.Size, NokiaN95.screen.Colors);
        }

        public override string ToString()
        {
            string Info = $"Model: {this.manufacturer} {this.model} \nPrice: {this.price}" +
                $" \nOwner: {this.owner} \nBattery: {this.battery.Model}"
                + $"\nIdle Time: {this.battery.IdleTime} \nHours Talk: {this.battery.HoursTalk}" +
                $"\nScreen: Size: {this.screen.Size} Colors: {this.screen.Colors}";
            return Info;
        }

        public void DeleteCall(int index)
        {
            this.callHistory.RemoveAt(index);
        }

        public void ShowCallHistory()
        {
            foreach(Call c in callHistory)
            {
                Console.WriteLine("Begining: {0} Duration: {1}", c.StartTime, c.Duration);
            }
        }

        public void DeleteAllCalls()
        {
            this.callHistory.Clear();
        }

    }

    public class Battery
    {
        public enum BatteryType {Li_Ion, NiMH, NiCd };
        private BatteryType? model;
        private int? idleTime;
        private int? hoursTalk;

        public BatteryType? Model { get { return this.model; } }
        public int? IdleTime { get { return this.idleTime; } }
        public int? HoursTalk { get { return this.hoursTalk; } }

        public Battery() : this(null, null, null)
        {
        }

        public Battery(BatteryType? model) : this(model, null, null)
        {
        }

        public Battery(BatteryType? model, int? idleTime) : this(model, idleTime, null)
        {
        }

        public Battery(BatteryType? model, int? idleTime, int? hoursTalk)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.hoursTalk = hoursTalk;
        }
    }

    public class Screen
    {
        private double? size;
        private int? colors;

        public double? Size { get { return this.size; } }
        public int? Colors { get { return this.colors; } }

        public Screen() : this(null, null)
        {
        }
        
        public Screen(double? size) : this(size, null)
        {
        }

        public Screen(double? size, int? colors)
        {
            this.size = size;
            this.colors = colors;
        }
    }

    public class Call
    {
        private DateTime startTime;
        private DateTime duration;

        public DateTime StartTime { get { return this.startTime; } }
        public DateTime Duration { get { return this.duration; } }

        public Call(DateTime startTime, DateTime duration)
        {
            this.startTime = startTime;
            this.duration = duration;
        }
    }

    class Program
    {  
        static void Main(string[] args)
        {
            MobilePhone.InfoNokia95();
        }
    } 
}

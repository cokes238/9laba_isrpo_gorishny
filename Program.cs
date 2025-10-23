//using System;

//namespace _9laba_isrpo_gorishny
//{
//    //{
//    //    internal class Program
//    //    {
//    //        static void Main(string[] args)
//    //        {
//    //            int? number = null;
//    //            Console.WriteLine(number);
//    //            number = 23;
//    //            Console.WriteLine(number);
//    //string? name = null;
//    //string result = name ?? "Default";
//    //Console.WriteLine(name!.Length);
//    //}
//    //static async Task Main()
//    //{

//    //    Console.WriteLine("Введите URL сайта");
//    //    string? url = Console.ReadLine();
//    //    if (string.IsNullOrWhiteSpace(url))
//    //    {
//    //        try
//    //        {
//    //            HttpClient client = new HttpClient();
//    //            string html = await client.GetStringAsync(url);
//    //            HtmlDocument doc = new HtmlDocument();
//    //            doc.LoadHtml(html);
//    //            var titleNode = doc.DocumentNode.SelectNodes("//title");
//    //        }
//    //    catch { Exception ex}
//    //    {
//    //        Console.WriteLine("URL не может быть пустым"){
//    //    }
//    //    else 
//    //    {
//    //        C
//    //    }
//    //}



//    //    Fruit apple = new() { Name = "Apple", Quantity = 10 };
//    //    //Person person = new("Denis");
//    //    string json = 
//    //        JsonConvert.SerializeObject(apple);
//    //    Console.WriteLine(json);
//    //    var deserialized =
//    //        JsonConvert.DeserializeObject<Fruit>(json);
//    //    Console.WriteLine(deserialized);
//    //}
//    //}
//    //public class Fruit
//    //{
//    //    public string Name { get; set; }
//    //    public int Quantity { get; set; }
//    //}
//    //}
//    //}

//    static void Main(string[] args)
//    {
//        // Создаем датчики
//        var tempSensor = new TemperatureSensor();
//        var motionSensor = new MotionSensor();
//        // Подписываем методы на события
//        tempSensor.OnOverheat += Notifier.SendTemperatureAlert;
//        motionSensor.OnMotionDetected += Notifier.LogMotionEvent;
//        // Симуляция работы датчиков
//        Console.WriteLine("=== Симуляция умного дома ===");
//        tempSensor.CheckTemperature(15); // Hорма
//        tempSensor.CheckTemperature(35);
//        // Перегрев -> вызовет OnOverheat
//        motionSensor.DetectMotion(false);
//        // Ничего
//        motionSensor.DetectMotion(true);
//        // Движение - вызовет ОпMotion Detected
//        // Создаем датчики
//        var tempSensor = new Temperature Sensor();
//        var motionSensor = new Motion Sensor();
//        var smartLight = new SmartLight();
//        // Подписываем методы на события
//        tempSensor.OnOverheat += Notifier.Send TemperatureAlert;
//        motionSensor.OnMotion Detected += Notifier.LogMotionEvent;
//        motionSensor.OnMotion Detected += smartLight.TurnOn;
//        // Симуляция работы датчиков
//        Console.WriteLine("=== Симуляция умного дома ===");
//        motionSensor.DetectMotion(true);
//        smartLight.TurnOn("Обнаружение движение");
//        Thread.Sleep(3000);
//        smartLight.TurnOff();

//    }








//    public delegate void TemperatureEventHandler(string message);
//    public delegate void MotionEventHandler(string message);
//    public class TemperatureSensor
//    {

//        public event TemperatureEventHandler OnOverheat;

//        public void CheckTemperature(int currentTemp)
//        {
//            if (currentTemp > 30)
//            {
//                OnOverheat?.Invoke($"Температура критическая {currentTemp}");


//            }


//        }



//    }
//}

namespace PR4
{
 
    class Package
    {
        public string Description { get; set; }
        public int Weight { get; set; }
        public Package(string description, int weight)
        {
            Weight = weight;
            Description = description;
        }
    }
    class Delivery
    {
        public int WeightLimit { get; set; }
        private int TotalWeight { get; set; }

        public Delivery(int weightLimit)
        {
            WeightLimit = weightLimit;
            TotalWeight = 0;
        }
        public void SendPackage(Package package)
        {
            if (TotalWeight + package.Weight > WeightLimit)
            {
                Console.WriteLine($"Недопустимо! Нельзя отправить посылку, которая превышает допустимый вес! Допустимый вес: {WeightLimit}, вес посылки: {package.Weight}");
                return;
            }
            TotalWeight += package.Weight;
            Console.WriteLine($"Ваша посылка отправлена!!! Вес посылки: {package.Weight} описание: {package.Description}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Delivery myMailService = new Delivery(10);
            Package package01 = new Package("Посылка с банановым соком ", 2);
            myMailService.SendPackage(package01);
            Package package02 = new Package("Холодильник ", 20);
            myMailService.SendPackage(package02);
            Package package03 = new Package("Коробка чипсов LAYS ",3);
            myMailService.SendPackage(package03);

            Console.ReadKey(true);
        }
    }
}

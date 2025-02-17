using System;

class Program {
    static void Main() {
        while (true) {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Возвести a в степень n");
            Console.WriteLine("2 - Трансформировать число x");
            Console.WriteLine("3 - Выйти");
            Console.Write("Ваш выбор: ");
            
            string choice = Console.ReadLine();
            
            switch (choice) {
                case "1": 
                    Power(); 
                    break;
                case "2": 
                    TransformNumber(); 
                    break;
                case "3": 
                    Console.WriteLine("Выход из программы.");; 
                    return;
                default: 
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.\n"); 
                    break;

            }
        }
    }

    // Функция для вычисления a^n 
    static void Power() {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        
        
        int result = 1;
        for (int i = 0; i < n; i++) {
            result *= a; 
        }

        Console.WriteLine($"{a}^{n} = {result}\n");
    }

    // Функция для переноса второй цифры в конец
    static void TransformNumber() {
        Console.Write("Введите x (x >= 100): ");
        int x = int.Parse(Console.ReadLine());
        
        
        string numStr = x.ToString();
        if (numStr.Length < 3) throw new ArgumentException("Число должно быть >= 100");

        char secondDigit = numStr[1]; 
        string newStr = numStr.Remove(1, 1) + secondDigit; 

        Console.WriteLine($"Преобразованное число: {newStr}\n");
    }
}

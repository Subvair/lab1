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
            
            if (choice == "1") {
                Console.Write("Введите a: ");
                int a = int.Parse(Console.ReadLine());
                
                Console.Write("Введите n: ");
                int n = int.Parse(Console.ReadLine());
                
                int powerResult = Power(a, n);
                Console.WriteLine($"{a}^{n} = {powerResult}\n");
            } 
            else if (choice == "2") {
                Console.Write("Введите x (x >= 100): ");
                int x = int.Parse(Console.ReadLine());
                
                int transformedNumber = TransformNumber(x);
                Console.WriteLine($"Преобразованное число: {transformedNumber}\n");
            } 
            else if (choice == "3") {
                Console.WriteLine("Выход из программы.");
                break;
            } 
            else {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.\n");
            }
        }
    }

    // Функция для вычисления a^n без использования других операций, кроме умножения
    static int Power(int a, int n) {
        int result = 1;
        for (int i = 0; i < n; i++) {
            result *= a; // Единственная разрешённая операция — умножение
        }
        return result;
    }

    // Функция для обработки числа x: удаление второй цифры и её перенос в конец
    static int TransformNumber(int x) {
        string numStr = x.ToString();
        if (numStr.Length < 3) throw new ArgumentException("Число должно быть >= 100");

        char secondDigit = numStr[1]; // Вторая цифра
        string newStr = numStr.Remove(1, 1) + secondDigit; // Удалить вторую цифру и добавить её в конец

        return int.Parse(newStr);
    }
}

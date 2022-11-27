using System;

namespace ConsoleApp_Master
{
    class Program
    {

        static void Main(string[] args)
        {
            //if

            /*
            if (условие)
            {
                выполняемые инструкции
            }
            */
            /*
            //1 - пример
            int num1 = 8;
            int num2 = 6;
            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            
            //1.1 - Если блок if содержит одну инструкцию, то мы можем его сократить, убрав фигурные скобки:
            if (num1 > num2) Console.WriteLine($"Число {num1} больше числа {num2}");
            
            //2 - Также мы можем соединить сразу несколько условий, используя логические операторы:
            int num1 = 8;
            int num2 = 6;
            if (num1 > num2 && num1 == 8)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            
            //3 - Выражение else
            int num1 = 8;
            int num2 = 6;
            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            else
            {
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            }
            
            //3.1 - Блок else выполняется, если условие после if ложно, то есть равно false. Если блок else содержит толко одну инструкцию, то оять же мы можем его сократить, убрав фигурные скобки:
            int num1 = 8;
            int num2 = 6;
            if (num1 > num2)
                Console.WriteLine($"Число {num1} больше числа {num2}");
            else
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            
            //4 - else if
            int num1 = 8;
            int num2 = 6;
            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            }
            else
            {
                Console.WriteLine("Число num1 равно числу num2");
            }
            
            //4.1 - При необходимости можно добавить несколько выражений else if:
            string name = "Alex";

            if (name == "Tom")
                Console.WriteLine("Вас зовут Tomas");
            else if (name == "Bob")
                Console.WriteLine("Вас зовут Robert");
            else if (name == "Mike")
                Console.WriteLine("Вас зовут Michael");
            else
                Console.WriteLine("Неизвестное имя");
            
            //5 - Бонус! Тернарная операция!
            // [первый операнд -условие] ? [второй операнд] : [третий операнд]
            int x = 3;
            int y = 2;

            int z = x < y ? (x + y) : (x - y);
            Console.WriteLine(z);   // 1
            */

            //switch
            /*
            switch (выражение)
            {
                case значение1:
                    код,выполняемый если выражение имеет значение1
                    break;
                case значение2:
                    код,выполняемый если выражение имеет значение1
                    break;
                //.............
                case значениеN:
                    код, выполняемый если выражение имеет значениеN
                    break;
                default:
                    код, выполняемый если выражение не имеет ни одно из выше указанных значений
                    break;
            }
            */
            /*
            После ключевого слова switch в скобках идет сравниваемое выражение. 
            Значение этого выражения последовательно сравнивается со значениями, помещенными после оператора сase. 
            И если совпадение будет найдено, то будет выполняться определенный блок сase.
            В конце каждого блока сase должен ставиться один из операторов перехода: break, goto case, return или throw. 
            Как правило, используется оператор break. 
            При его применении другие блоки case выполняться не будут.
             */
            /*
            //1 - Пример
            string name = "Tom";

            switch (name)
            {
                case "Bob":
                    Console.WriteLine("Ваше имя - Bob");
                    break;
                case "Tom":
                    Console.WriteLine("Ваше имя - Tom");
                    break;
                case "Sam":
                    Console.WriteLine("Ваше имя - Sam");
                    break;
            }

            //Если значение переменной name не совпадает ни с каким значением после операторов case, то ни один из блоков case не выполняется. 
            //Однако если даже в этом случае нам все равно надо выполнить какие-нибудь действия, то мы можем добавить в конструкцию switch необязательный блок default. 
            */
            /*
            //2 - go to - Однако если мы хотим, чтобы, наоборот, после выполнения текущего блока case выполнялся другой блок case, то мы можем использовать вместо break оператор goto case:
            int number = 1;
            switch (number)
            {
                case 1:
                    Console.WriteLine("case 1");
                    goto case 5; // переход к case 5
                case 3:
                    Console.WriteLine("case 3");
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            */
            /*
            //3 - Возвращение значения из switch - Конструкция switch позволяет возвращать некоторое значение. Для возвращения значения в блоках case может применятся оператор return. Например, определим следующий метод:
            int DoOperation(int op, int a, int b)
            {
                switch (op)
                {
                    case 1: return a + b;
                    case 2: return a - b;
                    case 3: return a * b;
                    default: return 0;
                }
            }

            int result1 = DoOperation(1, 10, 5); // 15
            Console.WriteLine(result1);         // 15

            int result2 = DoOperation(3, 10, 5); // 50
            Console.WriteLine(result2);
            */
            /*
            //4 - Получение результата из switch - Хотя конструкция switch в примере выше прекрасно работает, тем не менее мы ее можем сократить и получить результат неосредственно из конструкции switch:
            int DoOperation(int op, int a, int b)
            {
                int result = op switch
                {
                    1 => a + b,
                    2 => a - b,
                    3 => a * b,
                    _ => 0
                };
                return result;
            }

            int result1 = DoOperation(1, 10, 5); // 15
            Console.WriteLine(result1);         // 15

            int result2 = DoOperation(3, 10, 5); // 50
            Console.WriteLine(result2);
            */
            /*
            //4.1 - короче
            int DoOperation(int op, int a, int b)
            {
                return op switch
                {
                    1 => a + b,
                    2 => a - b,
                    3 => a * b,
                    _ => 0
                };
            }

            int result1 = DoOperation(1, 10, 5); // 15
            Console.WriteLine(result1);         // 15

            int result2 = DoOperation(3, 10, 5); // 50
            Console.WriteLine(result2);
            */
            /*
            //4.2 - еще короче - Обращаю внимание, что данное упрощение касается лишь таких конструкций switch, которые возвращают некоторые значения, как в примере выше.
            int DoOperation(int op, int a, int b) => op switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                _ => 0
            };

            int result1 = DoOperation(1, 10, 5); // 15
            Console.WriteLine(result1);         // 15

            int result2 = DoOperation(3, 10, 5); // 50
            Console.WriteLine(result2);
            */
            /*
            //5 - Стоит отметить, что при возвращении значения из метода, метод должен в любом случае возвращать значение. Например, следующая версия метода не будет работать
            int DoOperation(int op, int a, int b)
            {
                return op switch
                {
                    1 => a + b,
                    2 => a - b,
                    3 => a * b
                };
            }
            
            Эта версия метода возвращает значение, если код операции равен 1, 2 или 3. Но что, если будет передано значение 4 или какое-то другое? 
            Поэтому данная версия метода даже не скомпилируется. 
            Поэтому нам надо предусмотреть возвращение значения из метода при всех возможных вариантах. 
            То есть, мы можем, как в примере выше, добавить в конструкцию switch блок default, в котором будет возвращаться значение при всех остальных случаях.
            */
            

            /*
            //Работа с отладчиком
            int a = 5;

            int b = 6;
            //
            //
            //
            //
            //
            int c;

            c = a + b;

            Console.WriteLine(c);
            */


        }

    }
}


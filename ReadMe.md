FinalHomework
--
*Задача* : Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

**Решение**: Задаются два массива одинаковой длины. С помощью метода, в котором цикл равный длине массива, внутри цикла проводится проверка условия : ( <=3 ), если "да", то элемент первого массива заносится в count элемент второго массива. Для этого вводим переменную "count". После присвоения увеличивается переменная "count" на 1 и возвращается к циклу "for" в котором "i" увеличивается на 1. И так проверяется до конца.
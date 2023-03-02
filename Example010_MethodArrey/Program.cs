﻿// Допустим, у нас есть массив array, в котором n элементов. Найдём элемент, совпадающий с
// некоторым значением, который определяет пользователей.
// 1. Сохраним его в переменную find. Затем установим счётчик в нулевую позицию.
// 2. Если на текущей позиции элемент совпал с find, операцию можно завершить, потому
// что мы нашли позицию.
// 15
// 3. Если элемент не совпал с find, увеличиваем значение счётчика index на 1 и переходим
// на предыдущий шаг.
// 4. Сравниваем снова. И если элемент совпал с find, значит, алгоритм закончил работу.
// 5. Если элемент совпал с find, снова увеличиваем индекс. Смотрим результат.
// 6. В результате если элемент находится, операция завершается успешно. А если этого
// элемента так и нет, надо сообщить об этом


int[] ar = { 1, 2, 3, 18, 5, 6, 7, 18, };

int n = ar.Length;
int find = 18;

int index = 0;

while (index < n)
{
     if (ar[index] == find)
     {
        Console.WriteLine(index);
        break; 
     }
    
    //index = index + 1
    index++;
}

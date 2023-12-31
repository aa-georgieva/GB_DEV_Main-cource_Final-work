# GeekBrains. Разработчик. Контрольная работа по основному блоку
Привет! Это итоговая работа по основному курсу программы «Разработчик» от GeekBrains. Сама программа содержится в файле **Program.cs**, там же содержатся комментарии на английском. Здесь же я прокомментирую ход решения и ещё кое-какие нюансы.

## Условия задачи
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:<br>
*[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]<br>
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]<br>
[“Russia”, “Denmark”, “Kazan”] → []*

## Блок-схема
В файле **Flowchart.png** можно найти примерную (упрощённую) схему решения задачи<br>

![Блок-схема](Flowchart.png "Примерная блок-схема решения")

Схему я рисовала в программе [Flowgorithm](http://www.flowgorithm.org/), которая создаёт блок-схему и одновременно пишет псевдокод на «всех языках сразу», так что кое-каких специфических возможностей языка С# в ней просто нет. Hапример, на блок-схеме видно, что проверка длины элемента массива *WordStore[i].Length <= 3* не считывается программой корректно, потому что она не знает, что такое *.length*, а я не знаю, как объяснить ей это на понятном языке. На всякий случай прикладываю в репозиторий файл с блок-схемой в формате Flowgorithm (**Flowchart.fprg**), если есть желание,можно на него глянуть.

## Структура решения
Решение задачи написано на языке C# и включаетя в себя несколько методов, а также основное тело программы. Кратко рассмотрим сначала методы, а потом и саму программу.

### Метод ManFillArray (строки 3-10)
Метод обладает типом void (поскольку не выдаёт ничего нового, а просто преобразовывает полученный на вход пустой массив). Он служит для заполнения стартового массива со словами для проверки вручную, пользователем с клавиатуры.

### Метод SymbolCounter (строки 12-21)
Метод подсчитывает количество элементов массива, длина которых меньше или равна трём символам. Это необходимо для того, чтобы создать итоговый массив нужного размера. Отдаёт результат в виде целого числа.

 > Хотелось бы, конечно, как-то совместить его со следующим методом, чтобы не гонять счётчик два раза с одной и той же проверкой, но как-то мне не придумалось, как это сделать.

### Метод FillResArray (строки 23-36)
Принимает на вход изначальный массив, введённый пользователем вручную, а также размер нового массива, полученный через метод *SymbolCounter*. Создаёт новый пустой массив заданного размера и заполняет его, последовательно проверяя длину каждого элемента старого массива и записывая в новый только те, что меньше и равны трём символам. Поскольку до этого мы уже подсчитали количество таких элементов с помощью метода *SymbolCounter*, они как раз ровно заполняют все ячейки нового массива.

### Метод PrintArray (строки 38-41)
Выводит на экран итоговый массив в квадратных скобках. Если в массиве нет элементов, меньших или равных трём символам, то выводит пустые квадратные скобки.

### Основное тело программы (строки 43-52)
В основном теле программа представляется, объясняет, что она может, и предлагает пользователю задать число изначального массива (строки 45-46). Затем создаёт пустой строковый массив заданного пользователем размера (строка 47), вызывает метод *ManFillArray* и передаёт в него созданный пустой массив (строка 48), создаёт переменную для размера нового массива и вызывает для присвоения ей значения метод *SymbolCounter* (строка 49). Далее создаётся новый пустой массив размера, полученного в результате работы метода *SymbolCounter* (строка 50). В строке 51 новый массив заполняется с помощью вызова метода *FillResArray*, в 52-й— выводится на экран с помощью вызова метода *PrintArray*.

## Заключение
Наверно, решение можно было сделать изящней. Кроме того, мне кажется, что я где-то насоздавала лишних переменных. В любом случае буду очень рада фидбэку!


/*
    Задача: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
            В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
            Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

    Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)

    Пример:

    входные данные:
    data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
    info = {2, 3, 3, 1 }

    выходные данные:
    1, 7, 0, 1
*/
void ConvertToDecimal(){
    int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1};
    int[] info = {2, 3, 3, 1};
    
    int binaryStart = 0, binaryFinish = 0;

    for(int i = 0; i < info.Length; i++){
        int count = info[i];
        double result = 0;

        binaryFinish = binaryStart + info[i];
        for(int j = binaryStart; j < binaryFinish; j++){

            result += data[j] * Math.Pow(2, --count);
        }
        binaryStart += info[i];

        Console.Write($"{(int)result} ");
    }
}

ConvertToDecimal();
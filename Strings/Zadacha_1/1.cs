//Задайте двумерный массив символов (тип char [,]). 
//Создать строку из символов этого массива.


string GetStringFromCharArray(char [] chars){
    string res = "";
    foreach (char elem in chars){
        res += elem;
    }
    return res;
}

char [] chars = {'a','d','c','b'};
string str = GetStringFromCharArray(chars);
Console.WriteLine(str);
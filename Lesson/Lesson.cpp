#include <iostream>
#include <random>
#include <ctime>
using namespace std;
int n;
int c = 0;
int* arr = new int[n];
int arrc[100];



int main() {
    //указывание размера массива и заполнения массива счёта видов нулями
    srand(time(0));
    cout << "Enter massive size" << endl;
    cin >> n;
    for (int i = 0; i < n;i++)
        arrc[i] = 0;
    for (int i = 0;i < n;i++) {
        arr[i] = rand() % 5;
        cout << arr[i] << " ";
    }
    //Заполнение второго массива(видов) количеством повторений перового
    for (int i = 0;i < n;i++) {
        if (arr[i] == 0)
            arrc[0]++;
        if (arr[i] == 1)
            arrc[1]++;
        if (arr[i] == 2)
            arrc[2]++;
        if (arr[i] == 3)
            arrc[3]++;
        if (arr[i] == 4)
            arrc[4]++;
    }
    //Поиск максимального значение и индекса(номера ячейки во втором массиве)
    int max = arrc[0];
    int maxind = 0;
    for (int i = 1;i < n;i++) {
        if (arrc[i] > max) {
            max = arrc[i];
            maxind = i;
        }
    }
    //
    cout << endl << arrc[0] << " " << arrc[1] << " " << arrc[2] << " " << arrc[3] << " " << arrc[4] << " " << endl; //Вывод второго массива
    cout << endl << maxind+1;//вывод максимального индекса
}

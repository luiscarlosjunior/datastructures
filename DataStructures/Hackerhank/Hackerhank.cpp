// Hackerhank.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
#include <vector>

using namespace std;

int main() {

    vector<int> bob {10, 20, 30};
    vector<int> alice { 1, 2, 3};
    int points[2];

    if (bob[0] > alice[0])
    {
        points[0] = 1;
    }
    else if (bob[1] > alice[1])
    {
        points[0] += 1;
    }
    else if (bob[2] > alice[2])
    {
        points[0] += 1;
    }

    cout << "Valor: " << points[0] << endl;

    cout << "Hello World!\n";
}


// Hackerhank.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//
#include <map>
#include <iostream>
#include <vector>

using namespace std;

int main() {
    
    mostFrequent();
   
}

/// More frequently number
void mostFrequent()
{
    int tamanho = 10;
    int dados[] = { 1, 2, 2, 3, 5, 4, 2, 1, 4, 1 };
    map<int, int> count;

    for (size_t i = 0; i < tamanho; i++)
    {
        if (!dados[i] == count[i])
        {
            count[i] = 1;
        }
        else
        {
            count[i] += 1;
        }
    }
    
}

void test()
{

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

#include<iostream>
using namespace std;
int main()
{
    int number,sum=0;
    do
    {
        cout<<"Bir sayi girin(durdurmak icin 0): ";
        cin>>number;
        sum +=number;
    } while (number!=0);
    cout<<"Toplam: "<<sum<<endl;    
}
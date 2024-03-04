#include<iostream>
#include<string>
using namespace std;

string oyuncu1,oyuncu2,kelime,gizlikelime;
char tahmin;
int yanlis=0;

int main()
{
    cout<<"----------ADAM ASMACA OYUNUNA HOSGELDİNİZ----------"<<endl;
    cout<<"1. oyuncu isim gir: "<<endl;
    cin>>oyuncu1;
    cout<<"2. oyuncu isim gir: "<<endl;
    cin>>oyuncu2;

    cout<<oyuncu1<<" lutfen "<<oyuncu2<<" nin tahmin edebilmesi icin bir kelime gir: ";
    cin>>kelime;

    while(gizlikelime.size()!=kelime.size())
    {
        gizlikelime.push_back('?');
    }
    for(int i=0;i<30;i++)
    {
        cout<<endl;
    }
    cout<<"Girilen kelimenin gorulmemesi icin bosluk birakildi!!!"<<endl;

    do{
        cout<<"Bulunan harfler: ";
        cout<<gizlikelime;
        cout<<"Tahmin gir: "<<endl;
        cin>>tahmin;

        int x=kelime.length();

        for(int i=0;i<x;i++)
        {
            if(tahmin==kelime[i])
            {
                gizlikelime[i]=tahmin;
                yanlis--;
            }
        }
        yanlis++;

        if(gizlikelime==kelime)
        {
            cout<<oyuncu1<<" OYUNU KAZANDIN !!!  "<<endl;
            break;
        }
        
        if(yanlis==1)
        {
            cout<<"|"<<endl;
            cout<<endl;
        }
        else if(yanlis==2)
        {
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<endl;
        }
        else if(yanlis==3)
        {
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<endl;
        }
        else if(yanlis==4)
        {
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<endl;
        }
        else if(yanlis==5)
        {
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<endl;
        }
        else if(yanlis==6)
        {
            cout<<"|***"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<endl;
        }
        else if(yanlis==7)
        {
            cout<<"|***"<<endl;
            cout<<"|   O"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<endl;
        }
        else if(yanlis==8)
        {
            cout<<"|***"<<endl;
            cout<<"|   O"<<endl;
            cout<<"|   |"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<endl;
        }
        else if(yanlis==9)
        {
            cout<<"|***"<<endl;
            cout<<"|   O"<<endl;
            cout<<"|  -|-"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<endl;
        }
        else if(yanlis==10)
        {
            cout<<"|***"<<endl;
            cout<<"|   O"<<endl;
            cout<<"|  -|-"<<endl;
            cout<<"|   |"<<endl;
            cout<<"|"<<endl;
            cout<<"|"<<endl;
            cout<<endl;
        }
        else if(yanlis==11)
        {
            cout<<"|***"<<endl;
            cout<<"|   O"<<endl;
            cout<<"|  -|-"<<endl;
            cout<<"|   |"<<endl;
            cout<<"|  /"<<endl;
            cout<<"|"<<endl;
            cout<<endl;
        }
        else if(yanlis==12)
        {
            cout<<"|***"<<endl;
            cout<<"|   O"<<endl;
            cout<<"|  -|-"<<endl;
            cout<<"|   |"<<endl;
            cout<<"|  / \\";
            cout<<endl;
        }
    }
    while(yanlis<12);
    if(gizlikelime!=kelime)
        {
            cout<<oyuncu1<<" OYUNU KAYBETTIN !!!  "<<endl;
        }
}

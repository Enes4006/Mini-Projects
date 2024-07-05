#include<iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

int main()
{
    int oyuncu=0;
    int bilgisayar=0;

    srand(time(NULL));
    
    //güven:1 ihanet:0
    //iki oyuncu da güven puanlar=2
    // ihanet ihanet puanlar=0
    //oyuncu güven rakip ihanet puanlar= -1 +3
    //oyuncu ihanet rakip güven puanlar= +3 -1
    //oyuncu 10 puana ulaşırsa, oyuncu kazanır.
    //rakip 10 puana ulaşırsa, oyuncu kaybeder.
    //her iki oyuncu da 10 puana ulaşırsa, oyun berabere biter ve "Dostluk KAZANDI" mesajı verilir
    // 10 puanda oyun biter

    while(oyuncu<10 && bilgisayar<10)
    {
        int secim;
        
        cout<<"Bir sayi seciniz:(0/1)\n";
        cout<<"1:guven\n0:ihanet\n"<<endl;
        cin>>secim;

        if(secim!=1 && secim!=0)
        {
            cout<<"Yanlis secim girildi!!"<<endl;
            break;
        }

    
        int bilgisayarSecim=rand() % 2;
        cout<<"Bilgisayar secimi: "<<bilgisayarSecim<<endl;

        if(secim==1 && bilgisayarSecim==1)
        {
            cout<<"Iki oyuncu da birbirine guvendi\n"<<endl;
            oyuncu+=2;
            bilgisayar+=2;
        }
        else if(secim==0 && bilgisayarSecim==0)
        {
            cout<<"Iki oyuncu da birbirine guvenmedi"<<endl;
            oyuncu+=0;
            bilgisayar+=0;
        }
        else if(secim==1 && bilgisayarSecim==0)
        {
            cout<<"Oyuncu guvendi, bilgisayar guvenmedi"<<endl;
            oyuncu-=1;
            bilgisayar+=3;
        }
        else if(secim==0 && bilgisayarSecim==1)
        {
            cout<<"Oyuncu guvenmedi, bilgisayar guvendi"<<endl;
            oyuncu+=3;
            bilgisayar-=1;
        }



        if(oyuncu>=10)
        {
            cout<<"Oyuncu kazandi"<<endl;
            cout<<"Puani: "<<oyuncu<<endl;
            cout<<"Kaybedenin puani: "<<bilgisayar<<endl;
        }        
        else if(bilgisayar>=10)
        {
            cout<<"Bilgisayar kazandi"<<endl;
            cout<<"Puani: "<<bilgisayar<<endl;
            cout<<"Kaybedenin puani: "<<oyuncu<<endl;
    
        }
        else if (oyuncu>=10 && bilgisayar>=10)
        {
            cout<<"Dostluk kazandi"<<endl;
            cout<<"Puanlar oyuncu: "<<oyuncu<<endl;
            cout<<"Puanlar bilgisayar: "<<bilgisayar<<endl;
        }
    }

    return 0;
}
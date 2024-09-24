import random

rastgelesayi=random.randint(1,10)

sayac=1

while True:
    sayi=int(input("Bir sayi giriniz: "))
    if(sayi==rastgelesayi):
        print(f"Tebrikler {sayac} hamlede bildiniz")
        break
    elif(sayi<rastgelesayi):
        print("Yukarı")
        sayac=sayac+1
    elif(sayi>rastgelesayi):
        print("Aşağı")
        sayac=sayac+1
    else:
        print("Doğru sayı giriniz")

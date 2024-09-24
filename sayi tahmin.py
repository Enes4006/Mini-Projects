import random

rastgelesayi=random.randint(1,100)


while True:
    sayi=int(input("Bir sayi giriniz: "))
    if(sayi==rastgelesayi):
        print("Tebrikler kazandiniz")
        break
    elif(sayi<rastgelesayi):
        print("Yukarı")
    elif(sayi>rastgelesayi):
        print("Aşağı")
    else:
        print("Doğru sayı giriniz")
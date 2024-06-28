#include <iostream>
#include <iomanip>

int main()
{
    // Tablo başlıkları
    std::cout << std::setw(4) << "*" << " |";
    for(int j = 0; j < 10; j++)
    {
        std::cout << std::setw(4) << j;
    }
    std::cout << std::endl;
    
    // Ayırıcı çizgi
    std::cout << std::string(45, '-') << std::endl;

    for(int i = 0; i < 10; i++)
    {
        std::cout << std::setw(4) << i << " |";
        for(int j = 0; j < 10; j++)
        {
            std::cout << std::setw(4) << i * j;
        }
        std::cout << std::endl;
    }
    
    return 0;
}

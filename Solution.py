from typing import List

class Solution:
    def canPlaceFlowers(self, flowerbed: List[int], n: int) -> bool:
        for i in range(len(flowerbed)):
            # Перевіряємо, чи можна посадити квітку на позиції i
            if flowerbed[i] == 0:
                # Перевірка сусідніх ділянок або меж
                empty_left = (i == 0 or flowerbed[i - 1] == 0)
                empty_right = (i == len(flowerbed) - 1 or flowerbed[i + 1] == 0)
                
                if empty_left and empty_right:
                    # "Садимо" квітку і зменшуємо n
                    flowerbed[i] = 1
                    n -= 1
                    
                    # Якщо всі необхідні квіти посаджені, повертаємо True
                    if n == 0:
                        return True
                        
        # Якщо не вдалося посадити всі квіти, повертаємо False
        return n == 0
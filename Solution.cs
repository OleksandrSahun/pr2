public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;
        
        for (int i = 0; i < flowerbed.Length; i++) {
            // Перевіряємо, чи поточна позиція порожня і чи можна посадити квітку
            if (flowerbed[i] == 0 && 
                (i == 0 || flowerbed[i - 1] == 0) && 
                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)) {
                
                // Садимо квітку
                flowerbed[i] = 1;
                count++;
                
                // Перевіряємо, чи достатньо квітів уже посаджено
                if (count >= n) {
                    return true;
                }
            }
        }
        
        return count >= n;
    }
}

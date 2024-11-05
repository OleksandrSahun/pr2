/**
 * Determines whether it is possible to plant `n` flowers in the given flowerbed.
 *
 * The flowerbed is represented as an array of integers, where 0 represents an empty spot and 1 represents a flower.
 * The function checks if it is possible to plant `n` flowers in the flowerbed without violating the rule that no two adjacent flowers can be planted.
 *
 * @param flowerbed - An array of integers representing the flowerbed.
 * @param n - The number of flowers to be planted.
 * @returns `true` if it is possible to plant `n` flowers in the flowerbed, `false` otherwise.
 */

function canPlaceFlowers(flowerbed: number[], n: number): boolean {
    let count = 0;

    for (let i = 0; i < flowerbed.length; i++) {
        // Перевіряємо, чи поточна позиція порожня і чи можна посадити квітку
        if (flowerbed[i] === 0 && 
            (i === 0 || flowerbed[i - 1] === 0) && 
            (i === flowerbed.length - 1 || flowerbed[i + 1] === 0)) {
                
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
/**
 * Alternative solution that doesn't modify the input array.
 * Uses a counter approach by checking consecutive empty plots.
 *
 * @param flowerbed - An array of integers representing the flowerbed.
 * @param n - The number of flowers to be planted.
 * @returns `true` if it is possible to plant `n` flowers in the flowerbed, `false` otherwise.
 */
function canPlaceFlowersAlternative(flowerbed: number[], n: number): boolean {
    if (n === 0) return true;
    
    const bed = [0, ...flowerbed, 0];
    let possiblePlots = 0;
    
    for (let i = 1; i < bed.length - 1; i++) {
        if (bed[i - 1] === 0 && bed[i] === 0 && bed[i + 1] === 0) {
            bed[i] = 1;
            possiblePlots++;
            
            if (possiblePlots >= n) {
                return true;
            }
        }
    }
    
    return false;
}

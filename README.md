# Опис функції `canPlaceFlowers`

Функція `canPlaceFlowers` перевіряє можливість посадки заданої кількості квітів у клумбу, дотримуючись правила "без сусідніх квітів".

## Принцип роботи

Функція приймає два параметри:

- `flowerbed`: масив, де `0` означає порожнє місце, а `1` — посаджена квітка.
- `n`: кількість квітів, які потрібно посадити.

## Алгоритм

1. Проходить по кожній позиції в масиві `flowerbed`.
2. Перевіряє, чи можна посадити квітку в поточну позицію:
   - Поточне місце має бути порожнім (`0`).
   - Сусідні місця зліва та справа мають бути порожніми або не існувати (краї клумби).
3. При можливості садить квітку (змінює `0` на `1`).
4. Підраховує кількість посаджених квітів.
5. Якщо кількість посаджених квітів досягає або перевищує `n`, функція повертає `true`.

## Результат

- Повертає `true`, якщо можливо посадити всі `n` квітів.
- Повертає `false`, якщо посадити задану кількість квітів неможливо.

### Приклад

```typescript
const flowerbed = [1, 0, 0, 0, 1];
const n = 1;
console.log(canPlaceFlowers(flowerbed, n)); // Виведе: true

const n2 = 2;
console.log(canPlaceFlowers(flowerbed, n2)); // Виведе: false

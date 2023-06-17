# DreamCraftTest
Тестовое задание студии DreamCraft.

![hippo]([https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExdXJtd2NtZ3phOTV0eHE5Z3kyYnJoOHJmYnhrYzhkcHZjam9mNDVqNiZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/6nRJ8Y6aVzYZDohJsm/giphy.gif])

<details>
<summary>Задание</summary>
<br>
Игра состоит из следующих компонентов:
Игрок управляет героем, героя можно контролировать стрелочками или кнопками wasd.

У героя есть оружие из которого вылетают пули и при нажатии левой кнопки мышки герой начинает стрелять в сторону указателя.

Необходимо реализовать хотя бы 2 вида оружия и свободное переключение между ними (например оружие которое стреляет залпом и в одну точку).

Враги хаотично появляются за экраном и бегут прямо к герою. Когда враги касаются героя у него отнимаются жизни. Приветствуется создание нескольких видов врагов.

После того, как кончились жизни, игра заканчивается.

На графическую составляющую не стоит тратить много времени, она мало влияет на оценку решения. Можно использовать готовые ассеты или простые фигуры.

Требования к коду:
1) Стараться не использовать готовые решения.
2) Zenject использовать нельзя, любое самописное внедрение зависимостей приветствуется.
3) В процессе выполнения тестового задания стоит помнить о расширяемости кода, а также о производительности результата, насколько это возможно в условиях лимитированного времени.
4) Если из-за нехватки времени не получилось исправить все проблемы, достаточно их просто описать
</details>

# Основные особенности проекта:
1) Игра подходит для игры на пк и для игры на андройде без изменения кода (на андройде активируется джойстик для управления)
2) Самописный DI контейнер, сделанный по аналогии Zenject. Гибкий в использовании и удобный за счет жесткой очереди на bind and inject
3) Создание новых уровней удобно реализовано с помощью SO
<details>
<summary>Настройка оружия игрока на уровень</summary>
<br>
<img width="458" alt="image" src="https://github.com/Vanolim/DreamCraftTest/assets/60060770/7428a547-a3ba-4154-a8cd-92486f746c63">
</details>
<details>
<summary>Настройка волн врагов на уровень</summary>
<br>
<img width="458" alt="image" src="https://github.com/Vanolim/DreamCraftTest/assets/60060770/6bd44a62-5c4d-4371-ac2b-02be5a14e7a0">
</details>
4) Используются пулы для врагов и пуль. (пулы также передаются через DI)

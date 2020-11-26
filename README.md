# Объектно-ориентированные технологии

Лекции и материалы по курсу ООТ в ЧелГУ, группы МИВТ-101, МИТ-101.

[Присоединиться к слаку](https://join.slack.com/t/csuoot/shared_invite/zt-hklo03gk-7MQslsUFKmsTVzvzh~ydIg)

## Лекции

### 1. Введение в ООТ

[Презентация](https://docs.google.com/presentation/d/1GHh-BulJamQcb-XhXllAbtCEKMQC33mXX9w4XyVj8WQ/edit?usp=sharing)

**Литература**
1. Стив Макконнелл. Совершенный код
2. Эндрю Троелсен. Язык программирования C#

**Задача**

В компании работают менеджеры, техники и водители:

* Менеджеры и техники получают фиксированную ежемесячную зарплату.
* У водителей оплата почасовая.
* Заработная плата техников и водителей зависит от их категории (A, B или C). Категория предоставляет коэффициент от базовой зарплаты: A - 125%, B - 115%, С - 100%.
* Все работники могут получить фиксированную премию за месяц, которая прибавляется к их основной заработной плате.

Напишите программу, которая получает информацию о работниках компании и вычисляет, сколько компания должна выплатить своим сотрудникам в конце месяца.

[Код решения](exercises/01-payroll)


### 2. Принципы разработки ПО

[Презентация](https://docs.google.com/presentation/d/1AYDo-koXLtNgOB-SZSJTagFq4u7Viy5kZxFh-9-bV8M/edit?usp=sharing)

**Литература**
1. Эндрю Хант, Дэвид Томмс. Программист - прагматик. Путь от подмастерья к мастеру
2. [97 вещей, которые должен знать каждый программист](https://97-things-every-x-should-know.gitbooks.io/97-things-every-programmer-should-know/content/ru/)

**Задача**

Написать программу со следующими сущностями: точка на плоскости, круг, прямоугольник. Для круга и прямоугольника реализовать:

* Вычисление площади
* Проверку на то, что точка лежит внутри фигуры

[Код решения](exercises/02-shapes)


### 3. Практика

[Презентация](https://docs.google.com/presentation/d/1cUcijEHsNAJkW8Coe1h-wEQH9zyzZ8V4zJ2_XQcqqK8/edit?usp=sharing)

**Задача**

Написать класс для игры в крестики-нолики: поле 3x3, два игрока по очереди ставят крестик и нолик.

Игра должна проверять корректность действий:
1) Не давать крестику или нолику сходить не в свой ход
2) Не давать сходить в занятую клетку
3) Не давать сделать ход после завершения игры

Игра должна иметь минимальный необходимый интерфейс и не давать сломать свои данные снаружи.


### 4. Проектирование модулей

[Презентация](https://docs.google.com/presentation/d/1keyYJneEvHIiyqDj62vhegthm7lPVYyMoTRPjxypflY/edit?usp=sharing)

**Задача**

Написать консольный туду-лист с возможностью сохранять состояние в файле.

Код для туду-листа уже есть, надо разделить его на модули.

[Код, который надо отрефакторить](exercises/04-todo-list)


### 5. Принципы SOLID

[Презентация](https://docs.google.com/presentation/d/1bnWZ02mPhRJFYMO1XcMMDzWDxceIhK9Pn-V0isRj8bY/edit?usp=sharing)

**Литература**
1. Роберт Мартин. Принципы, паттерны и методики гибкой разработки на языке C#
2. [Серия постов Сергея Теплякова про SOLID](http://sergeyteplyakov.blogspot.com/2014/10/solid.html)
3. [Серия постов Александра Бындю про SOLID](https://blog.byndyu.ru/2009/12/blog-post.html)


### 6. Паттерны проектирования

[Презентация](https://docs.google.com/presentation/d/1sGJELMhHPoTqw-5UCzEsST_GQrqT9ybKkEIftq4afzk/edit?usp=sharing)

**Литература**
1. Эрих Гамма, Ричард Хелм, Ральф Джонсон, Джон Влиссидес. Приемы объектно-ориентированного проектирования. Паттерны проектирования
2. Эрик Фримен, Элизабет Фримен, Кэтти Сьерра, Берт Бейтс. Паттерны проектирования
3. [Паттерны проектирования на refactoring.guru](https://refactoring.guru/ru/design-patterns)


### 7. Практика по паттернам

[Репозиторий с задачами](https://github.com/csu-iit/programming-Patterms.CSharp)


### 8. Тестирование и TDD

[Презентация](https://docs.google.com/presentation/d/1QtVW0UrfqPkLUfeHXBNj4lHq_RC5nMItLAuN5VGGyU0/edit?usp=sharing)

**Задача**

С использованием подхода TDD написать программу для перевода римских чисел в обычные. В программе должно быть два модуля: 

1. Модуль, который переводит римское число в обычное
2. Модуль, который читает документ и переводит все римские числа из него в обычные с помощью первого модуля


[Код решения](exercises/08-roman-numerals)


### 9. Концепции C#

[Презентация](https://docs.google.com/presentation/d/1qU4zF-BZVfMkORms6xvsgAL0NgAH0gmqhOegTadDwXU/edit?usp=sharing)


### 10. Технический долг

[Презентация](https://docs.google.com/presentation/d/12yDoozHEte7Or0GFJE0vUiP4wSF2Y7UT45raPXhq2TI/edit?usp=sharing)

**Литература**
1. Мартин Фаулер. Рефакторинг
2. [Каталог рефакторингов на refactoring.guru](https://refactoring.guru/ru/refactoring)
3. [Подкаст «Подлодка» с Александром Бындю о техдолге](https://soundcloud.com/podlodka/podlodka-77-tekhnicheskiy-dolg)
4. [Статья Александра Бындю про технический долг](https://blog.byndyu.ru/2008/12/blog-post.html)
5. [Синдром рефакторинга](http://sergeyteplyakov.blogspot.com/2011/05/blog-post_26.html)


### 11. Практика

**Задача**

Реализовать модуль корзины для вычисления общей стоимости заказа в пиццерии:

1. Пиццерия продает два вида товаров: пиццы и напитки
2. Заказ можно забрать в пицерии или оформить доставку
3. Доставка действует только для заказов, содержащих хотя бы одну пиццу, и стоит 150 рублей, заказы от 1000 рублей доставляются бесплатно. А напитки можно возить от 100 литров бесплатно.
4. Есть промокоды: на конкретную пиццу бесплатно, на бесплатную доставку, на скидку X%, на скидку X рублей
5. Есть акция: при покупке четырех больших пицц пиццерия дарит одну любую маленькую пиццу
6. Есть еще акция: при покупке четырех средних пицц пиццерия дарит один любой напиток объемом 1 л.
7. Система должна быть расширяемой: легко добавить новые правила, скидки, виды промокодов и товаров

[Код решения](exercises/11-pizza-shop)


## Практика

### Задача 1. Родственные связи

Напишите программу, которая моделирует родственные связи. Программа позволяет создать объекты типа `Person` и указывать, кто из людей кому является родителем и кто с кем состоит в браке.

Должны быть функции, позволяющие для каждого человека получить список:
* Родителей
* Двоюродных братьев и сестер
* Дядюшек и тетушек
* In-laws (cвекра и свекрови или тестя и тещи)


### Задача 2. Книжный магазин

Реализовать модуль корзины для вычисления общей стоимости заказа в книжном интернет-магазине:

1. Два вида книг: бумажные и электронные
2. Для бумажных книг доставка от 1000 рублей бесплатная, иначе 200 рублей. Для электронных всегда бесплатная
3. Есть промокоды: на конкретную книгу бесплатно, на бесплатную доставку, на скидку X%, на скидку X рублей
4. Есть акция: при покупке двух бумажных книг одного автора одна электронная книга того же автора в подарок
5. Система должна быть расширяемой: легко добавить новые правила, скидки, виды промокодов и книг


### Задача 3. Бинарное дерево поиска

Реализовать структуру данных «словарь» на основе [бинарного дерева поиска](https://ru.wikipedia.org/wiki/Двоичное_дерево_поиска). Структура данных должна:

1. Реализовывать интерфейс [IDictionary<TKey,TValue>](https://docs.microsoft.com/ru-ru/dotnet/api/system.collections.generic.idictionary-2?view=netcore-3.1)
2. Поддерживать сохранение в файл и загрузку из файла (можно использовать встроенный механизм сериализации)
3. Быть покрыта юнит-тестами


### Дедлайны по практике

1. Все задачи сданы до **10 декабря** включительно → экзамен без практики
2. Все задачи сданы до конца семестра → допуск к экзамену
3. Задачи не сданы до конца семестра → недопуск к экзамену


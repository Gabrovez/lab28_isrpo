# GamesApi — Лабораторная работа №28

## 1. Название и описание проекта
**Название:** GamesApi (Список любимых игр с полным управлением)

**Описание:** Веб-сервер на ASP.NET Core (Web API), предоставляющий CRUD-операции для управления списком видеоигр. Данные хранятся в памяти сервера (`List<Game>`). Проект демонстрирует использование контроллеров, HTTP-методов (GET, POST, PUT, DELETE) и корректных статусов ответа (200, 201, 204, 400, 404).

## 2. Инструкция по запуску
Для запуска сервера выполните в терминале одну команду, находясь в папке `GamesApi`:
```bash
dotnet run
```

## 3. Таблица всех маршрутов

| Метод | Маршрут | Описание | Статус |
| :--- | :--- | :--- | :--- |
| **GET** | `/api/games` | Получить список всех игр | 200 OK |
| **GET** | `/api/games/{id}` | Получить игру по  id | 200 OK / 404 Not Found |
| **POST** | `/api/games` | Добавить игру  | 201 Created  |
| **DELETE** | `/api/games/{id}` | Удалить игру  | 204 No Content / 404 Not Found |

## 4. Примеры curl-команд для каждого маршрута

*Замените `{port}` на порт вашего сервера.

### Получить все игры (GET)
```bash
curl http://localhost:{port}/api/games
```

### Получить избранные игры (GET)
```bash
curl http://localhost:{port}/api/games/favourites
```

### Получить одну игру по ID (GET)
```bash
# Существующая игра
curl http://localhost:{port}/api/games/2
# Несуществующая игра (вернет 404)
curl -i http://localhost:{port}/api/games/99
```

### Добавить новую игру (POST)
*При добавлении можно указать `isFavourite: true`*
```bash
curl -X POST http://localhost:{port}/api/games \
  -H "Content-Type: application/json" \
  -d '{"title": "Cyberpunk 2077", "genre": "Action RPG", "releaseYear": 2020, "isFavourite": true}'

# Проверка на пустое название (вернет 400 Bad Request)
curl -X POST http://localhost:{port}/api/games \
  -H "Content-Type: application/json" \
  -d '{"title": "", "genre": "RPG", "releaseYear": 2020}'
```

### Обновить игру (PUT)
```bash
curl -X PUT http://localhost:{port}/api/games/2 \
  -H "Content-Type: application/json" \
  -d '{"title": "The Witcher 3: Wild Hunt", "genre": "RPG", "releaseYear": 2015, "isFavourite": false}'
```

### Удалить игру (DELETE)
```bash
# Успешное удаление (вернет пустой ответ)
curl -X DELETE http://localhost:{port}/api/games/1

# Попытка удалить несуществующую игру (вернет 404 с JSON-ошибкой)
curl -i -X DELETE http://localhost:{port}/api/games/99
```
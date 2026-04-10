using GamesApi.Models;

namespace GamesApi.Data;

public static class GamesStore {
    private static int _nextId = 4;
    public static List<Game> Games = new() {        
        new Game { Id = 1, Title = "The Elder Scrolls IV: Oblivion", Genre = "RPG", ReleaseYear = 2006, },
        new Game { Id = 2, Title = "The Witcher 3", Genre = "RPG", ReleaseYear = 2015, },
        new Game { Id = 3, Title = "Cyberpunk 2077", Genre = "Action RPG", ReleaseYear = 2020, },
        new Game { Id = 4, Title = "Elden Ring", Genre = "Action RPG", ReleaseYear = 2022 } 
    };

    public static int NextId() => _nextId++;
}
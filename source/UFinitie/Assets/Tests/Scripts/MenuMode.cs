public enum MenuMode
{
    MainMenu,
    NewGame,
    Settings,
    Exit
}

public static class MenuModeService
{
    public static MenuMode Mode { get; set; } = MenuMode.MainMenu;
}
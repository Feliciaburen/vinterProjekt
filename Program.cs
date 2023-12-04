namespace vinterProjekt;
using Raylib_cs;

class Program
{
    private Circle points = new Circle();

    static void Main(string[] args)
    {

        Raylib.InitWindow(800, 600, "Pac-Man");
        Raylib.SetTargetFPS(60);
        
        Texture2D PacMan = Raylib.LoadTexture(@"resurser/pacman.png");

        Raylib.DrawTexture(PacMan, 40, 300, Color.WHITE);
        
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);
            
            Raylib.EndDrawing();
        }
    }
}

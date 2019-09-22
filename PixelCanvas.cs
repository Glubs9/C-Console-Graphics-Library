using System;
using System.Linq;

namespace PixelCanvasInclude{
static class PixelCanvas{

    private static ConsoleColor[,] board;
    private static int boardHeight; 
    private static int boardWidth;
    private static ConsoleColor background;

    public static void Init(int boardWidthIn, int boardHeightIn, ConsoleColor BaseColour){

        boardHeight = boardHeightIn;
        boardWidth = boardWidthIn;
        background = BaseColour;
        board = new ConsoleColor[boardWidth,boardHeight];
        DrawRect(0,0,boardWidth,boardHeight,BaseColour);

    }

    public static void Output(){

        for (int y = 0; y < boardHeight; y++){
            for (int x = 0; x < boardWidth; x++){
                Console.BackgroundColor = board[x,y];
                Console.Write("  ");
            }
            Console.WriteLine();
        }
        Console.ResetColor();

    }

    public static void OutPutAndClear(){
        Console.Clear();
        Output();
    }

    public static void SetPixel(int x, int y, ConsoleColor color){
        board[x,y] = color;
    }

    public static ConsoleColor GetPixel(int x, int y){
        return board[x,y];
    }

    public static void DeletePixel(int x, int y){
        SetPixel(x,y,background);
    }

    public static void DrawRect(int xin, int yin, int width, int height, ConsoleColor color){
        for (int y = yin; y < yin + height; y++){
            for (int x = xin; x < xin + width; x++){
                board[x,y] = color;
            }
        }
    }

    public static void ClearRect(int xin, int yin, int width, int height){
        DrawRect(xin,yin,width,height,background);
    }

    public static void Clear(){
        ClearRect(0,0,boardWidth,boardHeight);
    }

    public static void SetBackground(ConsoleColor BackgroundInput){
        background = BackgroundInput;
    }

    /*public static void Main(string[] args){
        Init(50,50,ConsoleColor.Black);
        Output();
        SetPixel(5,5,ConsoleColor.Cyan);
        Output();
        DrawRect(25,25,10,10,ConsoleColor.White);
        Output();
        Clear();
        Output();
    }*/

}
}

using System;
using System.Linq;

namespace PixelCanvasInclude{
class PixelCanvas{

    private ConsoleColor[,] board; 
    private int boardHeight; 
    private int boardWidth;
    private ConsoleColor background;

    public PixelCanvas(int boardWidthIn, int boardHeightIn, ConsoleColor BaseColour){

        boardHeight = boardHeightIn;
        boardWidth = boardWidthIn;
        background = BaseColour;
        board = new ConsoleColor[boardWidth,boardHeight];
        DrawRect(0,0,boardWidth,boardHeight,BaseColour);

    }

    public void Output(){

        for (int y = 0; y < boardHeight; y++){
            for (int x = 0; x < boardWidth; x++){
                Console.BackgroundColor = board[x,y];
                Console.Write("  ");
            }
            Console.WriteLine();
        }
        Console.ResetColor();

    }

    public void OutputAndClear(){
        Console.Clear();
        Output();
    }

    public void SetPixel(int x, int y, ConsoleColor color){
        board[x,y] = color;
    }

    public ConsoleColor GetPixel(int x, int y){
        return board[x,y];
    }

    public void DeletePixel(int x, int y){
        SetPixel(x,y,background);
    }

    public void DrawRect(int xin, int yin, int width, int height, ConsoleColor color){
        for (int y = yin; y < yin + height; y++){
            for (int x = xin; x < xin + width; x++){
                board[x,y] = color;
            }
        }
    }

    public void ClearRect(int xin, int yin, int width, int height){
        DrawRect(xin,yin,width,height,background);
    }

    public void Clear(){
        ClearRect(0,0,boardWidth,boardHeight);
    }

    public void SetBackground(ConsoleColor BackgroundInput){
        background = BackgroundInput;
    }

}
}

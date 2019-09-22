# Quick Note: I accidentally mistyped, this is a c# console graphics library not a c console graphics library
# C#-Console-Graphics-Library
a graphics library to use for colour pixel graphics (not images) in the cmd for c#.

To use: download PixelCanvas.cs; then when compiling link it to the original file (if compiling in the console just write it in the compiler. if in visual studio i have no clue)
Note: I have no clue if this works on windows though it probably does

To use in the file import PixelCanvasInclude using the 'using'
eg: using PixelCanvasInclude

then you can create a new PixelCanvas with the arguments for the constructor, the width of the canvas, the height and the background/base colour using the ConsoleColor enum in the system include.

to output the canvas call Output()

to clear the screen and then output call OutputAndClear()

SetPixel(x,y,color) sets pixels, use the arguments pixel x, pixel y and the colour of the pixel using the ConsoleColor enum

GetPixel(x,y) gets a color value at a pixel

DeletePixel(x,y) sets a pixel to the base/background color

DrawRect(x,y,width,height,color): with the x being the left x and y as the top height, point (x,y) being the top left corner of the rectangle. width is the width of the rectangle and height is the height and color is a ConsoleColor variable that is the colour to draw the rectangle.

ClearRect(x,y,width,height): effectively the same as drawrect just with the base/background as the colour

Clear(): set the canvas to the background colour

SetBackground(color): changes the background colour

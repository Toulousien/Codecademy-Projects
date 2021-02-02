using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {


    public new static void UpdatePosition(string keyPressed, out int xChange, out int yChange)
    {
      xChange = 0;
      yChange = 0;
      switch (keyPressed)
      {
        case "LeftArrow":
        xChange -= 1;
        break;
        case "RightArrow":
        xChange += 1;
        break;
        case "UpArrow":
        yChange -= 1;
        break;
        case "DownArrow":
        yChange += 1;
        break;
      }
    }

      public new static char UpdateCursor(string keyPressed)
      {
        char direction = '0';
        switch(keyPressed)
        {
          case "LeftArrow":
          direction = '<';
          break;
          case "RightArrow":
          direction = '>';
          break;
          case "UpArrow":
          direction = '^';
          break;
          case "DownArrow":
          direction = 'v';
          break;
        }
        return direction;
      }

    public new static int KeepInBounds(int coordinate, int maxValue)
    {
      if (coordinate < 0)
      {
        coordinate = 0;
      }
      else if (coordinate >= maxValue)
      {
        coordinate = maxValue;
      }
      return coordinate;
    }

    public new static bool DidScore(int xChar, int yChar, int xFruit, int yFruit)
    {
      int score = 0;
      if (xChar == xFruit && yChar == yFruit)
      {
        score++;
        return true;
      }
      else {
        return false;
      }
    }
  }
}
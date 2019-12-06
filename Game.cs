using System;

namespace TreehouseDefense
{
  class Game 
  {
    public void Main()
    {
      Map map = new Map(8,5);
      Point point = new Point(4, 2);
      // int area = map.Width * map.Height;
      bool isOnMap = map.OnMap(point);
      Tower tower = new Tower();
      Console.WriteLine(isOnMap);

      point = new Point(8,5);
      isOnMap = map.OnMap(point);
      
    }
  }
}
using System;

namespace TreehousDefense
{
  class Project
  {
     static void Main(string[] args)
    {
      Map map = new Map(8,5);

/*       Point point = new Point(4, 2);
      int area = map.Width * map.Height;
      bool isOnMap = map.OnMap(point);
      Console.WriteLine(isOnMap);

      point = new Point(8,5);
      isOnMap = map.OnMap(point);
      Console.WriteLine(isOnMap);

      Tower tower = new Tower(); */

      Point point = new Point(4,2);
      Console.WriteLine(point.DistanceTo(5,5));
     
    }
  }
}
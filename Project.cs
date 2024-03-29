using System;

namespace TreehouseDefense
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

      // Point point = new Point(4,2);
      // Console.WriteLine(point.DistanceTo(5,5));

// even though x is now a map location this varible x will still work the maplocation class doesnt have a distanceto method directly but it inherits it from the point class. We could even assign maplocation to a point.
    /*   MapLocation x = new MapLocation(4,2);
      
      Point x = new Maplocation(3,1);

      Point p = x;

      Console.WriteLine(x.DistanceTo(5,5));

      map.OnMap(new MapLocation(0,0));
 */
  try{

      Path path = new Path(
       new [] {
          new MapLocation(0,2,map),
          new MapLocation(1,2,map),
          new MapLocation(2,2,map),
          new MapLocation(3,2,map),
          new MapLocation(4,2,map),
          new MapLocation(5,2,map),
          new MapLocation(6,2,map),
          new MapLocation(7,2,map)
        }
      );
/*       Invader invader = new Invader();
      MapLocation location = new MapLocation(0,0,map);
      // MapLocation location = path.GetLocationAt(8);
      // if(location != null){
      // Console.WriteLine(location.X + "," + location.Y);
      // }

      invader.Location = location;
      // this is not setting the location field directly this is calling the calling the settein insider the location property
      Location = invader.Location; */
  }
  catch(OutOfBoundsException ex)
  {
     Console.WriteLine(ex.Message);
  }
   catch(TreehouseDefenseException)
  {
     Console.WriteLine("Unhandled TreeHouseDefenseException");
  }
  catch(Exception ex)
  {
     Console.WriteLine("Unhandled Exception " + ex);
  }
    }
  }
}
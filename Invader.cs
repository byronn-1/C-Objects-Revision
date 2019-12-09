using System;

namespace TreehouseDefense
{
    class Invader
    {
      private MapLocation _location;

     /*  public MapLocation GetLocation()
      {
        return _location;
      }

      public void SetLocation(MapLocation value)
      {
        _location = value;
      } */

      public MapLocation Location
      {
        get 
        {
          return _location;
        }
        set
        {
          _location = value;
          // System.Console.WriteLine("location changed");
        }
      }
    }
}

//Team_Treehouse_C__Objects
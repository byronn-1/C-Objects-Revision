using System;

namespace TreehouseDefense
{
  class Path
  {
    private MapLocation[] _path;
  
      public Path(MapLocation[] path)
      {
        _path = path;
      }

      public MapLocation GetLocationAt(int pathStep)
      {
        if(pathStep < _path.Length)
        {
          return _path[pathStep];
        }
        else
        {
          return null;
        }
      }
  }
}
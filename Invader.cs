using System;

namespace TreehouseDefense
{
    class Invader
    {
      // private MapLocation _location;

     /*  public MapLocation GetLocation()
      {
        return _location;
      }

      public void SetLocation(MapLocation value)
      {
        _location = value;
      } */

/*       public MapLocation Location
      {
        get 
        {
          return _location;
        }
        set
        {
          _location = value;
          // System.Console.WriteLine("location changed");
        } */

  private readonly Path _path;
  private int _pathStep = 0;
  public int _health = 100;
  public MapLocation Location =>  _path.GetLocationAt(_pathStep);

  public Invader (Path path)
  {
    _path = path;
  }

  public void Move() => _pathStep += 1;


// invader health ......
// variable to store how much health the invader has 
// invader has to start out with an amount of health
// tower class to decrease the health of the invader IF (they succsesfully hit it)

    public int Health { get; private set; } = 2;
      
    public void DecreaseHealth(int factor)
    {
      Health -= factor;
    }

    public bool HasScored {get{ return _pathStep >= _path.Length; } };
    
    public bool IsNeutralized => Health <= 0;

    public bool IsActive => !(IsNeutralized || HasScored);
  }
}
//Team_Treehouse_C__Objects
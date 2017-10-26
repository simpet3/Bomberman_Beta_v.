using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.coordinates;

//PAKEICIAU KLASE I INTERFEISA, KAD GAUTUSI FACTORY PATERNAS
namespace BomberManProject.tile
{
    interface IWallTile : ITile
    {
        bool Immovable { get; set; }
    }

    //class WallTile : ITile
    //{
    //    public TileCoordinates coordinates { get; private set; }
    //    bool Immovable { get; set; }


    //    public WallTile(TileCoordinates coordinates)
    //    {
    //        this.coordinates = coordinates;
    //        this.Immovable = false;
    //    }

    //    public void makeImmovable()
    //    {
    //        this.Immovable = true;
    //    }

    //    public TileCoordinates getCoordinates()
    //    {
    //        return this.coordinates;
    //    }
    //}
}

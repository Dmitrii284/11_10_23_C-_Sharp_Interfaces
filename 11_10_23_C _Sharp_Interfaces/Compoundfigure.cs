using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_10_23_C__Sharp_Interfaces
{
    internal class CompoundFigure : ISimpleSquare
    {
        public float Height { get; set; }
        public float Base { get; set; }
        public float Angle { get; set; }
        public float NumberSide { get; set; }
        public float SideLengths { get; set; }
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public float CompoundFigure();
        
        public List<ISimpleSquare> polygons;
        public CompoundFigure() 
        {
            poligons = new List<CompoundFigure>();
        }
    }
}

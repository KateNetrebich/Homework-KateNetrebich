using System;
using System.Collections.Generic;
using System.Text;

namespace LinqHomeworkPart2
{
    class Film : ArtObject
    {

        public int Length { get; set; }
        public IEnumerable<Actor> Actors { get; set; }
    }
}

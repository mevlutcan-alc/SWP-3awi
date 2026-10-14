using System;
using System.Collections.Generic;
using System.Text;

namespace ObjektOrientierungTeil1 {
    public class KUH { string _name; string _colour;
        public string Name { get { return _name; } 
            set { _name = value; } 
        } public string Colour { get { return _colour; } 
            set { _colour = value; } 
        } public KUH (string Name, string Colour) 
        { _name = Name; _colour = Colour; } } }

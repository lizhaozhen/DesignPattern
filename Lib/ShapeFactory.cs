using System;

namespace Lib
{
    public class ShapeFactory
    {
        public IShape getShape(string shapeType){
            if(shapeType == null){
                return null;
            }		
            if(shapeType.Equals("CIRCLE")){
                return new Circle();
                
            } else if(shapeType.Equals("RECTANGLE")){
                return new Rectangle();
                
            } else if(shapeType.Equals("SQUARE")){
                return new Square();
            }
            
            return null;
        }
    }
}
